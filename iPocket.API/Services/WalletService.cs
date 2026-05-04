using Microsoft.EntityFrameworkCore;
using iPocket.API.Data;
using iPocket.API.DTOs;
using iPocket.API.Models;
using iPocket.API.Services.Interfaces;

namespace iPocket.API.Services;

public sealed class WalletService(AppDbContext db) : IWalletService
{
    // ── Dashboard (Form911) ──────────────────────────────────────────────────

    public async Task<WalletDto> GetWalletAsync(int userId)
    {
        var wallet = await db.Wallets
            .Include(w => w.Transactions.OrderByDescending(t => t.CreatedAt).Take(10))
            .FirstOrDefaultAsync(w => w.UserId == userId)
            ?? throw new KeyNotFoundException("Wallet not found.");

        return new WalletDto(
            wallet.Id,
            wallet.Balance,
            wallet.PaymentDue,
            wallet.CardNumber,
            [.. wallet.Transactions.Select(ToDto)]);
    }

    // ── Deposit (Form913 — quick amounts: +500 / +1000 / +2000 / +5000) ──────

    public async Task<TransactionDto> DepositAsync(int userId, DepositRequest req)
    {
        var wallet = await GetWalletOrThrowAsync(userId);

        wallet.Balance += req.Amount;

        var tx = new Transaction
        {
            WalletId    = wallet.Id,
            Type        = TransactionType.Deposit,
            Amount      = req.Amount,
            Description = req.Description,
            Status      = TransactionStatus.Completed
        };
        db.Transactions.Add(tx);
        await db.SaveChangesAsync();

        return ToDto(tx);
    }

    // ── Send Money (Form914) ─────────────────────────────────────────────────

    public async Task<TransactionDto> SendMoneyAsync(int userId, SendMoneyRequest req)
    {
        var wallet = await GetWalletOrThrowAsync(userId);

        if (wallet.Balance < req.Amount)
            throw new InvalidOperationException("Insufficient balance.");

        wallet.Balance -= req.Amount;

        var tx = new Transaction
        {
            WalletId        = wallet.Id,
            Type            = TransactionType.Send,
            Amount          = req.Amount,
            Description     = req.Note ?? $"Sent to {req.RecipientName}",
            RecipientName   = req.RecipientName,
            RecipientNumber = req.RecipientNumber,
            Status          = TransactionStatus.Completed
        };
        db.Transactions.Add(tx);

        // If the recipient is also an iPocket user, credit them automatically
        var recipient = await db.Users
            .Include(u => u.Wallet)
            .FirstOrDefaultAsync(u => u.MobileNumber == req.RecipientNumber);

        if (recipient?.Wallet is not null)
        {
            recipient.Wallet.Balance += req.Amount;
            db.Transactions.Add(new Transaction
            {
                WalletId    = recipient.Wallet.Id,
                Type        = TransactionType.Receive,
                Amount      = req.Amount,
                Description = $"Received from {wallet.UserId}",
                Status      = TransactionStatus.Completed
            });
        }

        await db.SaveChangesAsync();
        return ToDto(tx);
    }

    // ── Transaction History (Form918 — All / Deposit / Transfer tabs) ─────────

    public async Task<TransactionPageDto> GetTransactionsAsync(
        int userId, string? filter, int page, int size)
    {
        var wallet = await GetWalletOrThrowAsync(userId);

        var query = db.Transactions.Where(t => t.WalletId == wallet.Id);

        if (!string.IsNullOrWhiteSpace(filter) && !filter.Equals("All", StringComparison.OrdinalIgnoreCase))
        {
            if (Enum.TryParse<TransactionType>(filter, ignoreCase: true, out var type))
                query = query.Where(t => t.Type == type);
        }

        var total = await query.CountAsync();
        var items = await query
            .OrderByDescending(t => t.CreatedAt)
            .Skip((page - 1) * size)
            .Take(size)
            .ToListAsync();

        return new TransactionPageDto([.. items.Select(ToDto)], total, page, size, filter);
    }

    // ── Helpers ───────────────────────────────────────────────────────────────

    private async Task<Wallet> GetWalletOrThrowAsync(int userId) =>
        await db.Wallets.FirstOrDefaultAsync(w => w.UserId == userId)
        ?? throw new KeyNotFoundException("Wallet not found.");

    private static TransactionDto ToDto(Transaction t) => new(
        t.Id, t.Type.ToString(), t.Amount, t.Description,
        t.RecipientName, t.Status.ToString(), t.CreatedAt);
}
