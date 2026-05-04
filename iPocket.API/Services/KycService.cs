using Microsoft.EntityFrameworkCore;
using iPocket.API.Data;
using iPocket.API.DTOs;
using iPocket.API.Models;
using iPocket.API.Services.Interfaces;

namespace iPocket.API.Services;

public sealed class KycService(AppDbContext db) : IKycService
{
    // ── Form9 – get current KYC status ───────────────────────────────────────

    public async Task<KycStatusDto> GetStatusAsync(int userId)
    {
        var user = await db.Users
            .Include(u => u.KycDocuments)
            .FirstOrDefaultAsync(u => u.Id == userId)
            ?? throw new KeyNotFoundException("User not found.");

        return new KycStatusDto(
            user.KycStatus.ToString(),
            [.. user.KycDocuments.Select(ToDto)]);
    }

    // ── Form910 – submit a document ───────────────────────────────────────────

    public async Task<KycDocumentDto> SubmitDocumentAsync(int userId, SubmitKycRequest req)
    {
        var user = await db.Users.FindAsync(userId)
            ?? throw new KeyNotFoundException("User not found.");

        var doc = new KycDocument
        {
            UserId           = userId,
            DocumentType     = req.DocumentType,
            DocumentCategory = req.DocumentCategory,
            FilePath         = req.FilePath,
            Status           = KycStatus.Submitted
        };

        db.KycDocuments.Add(doc);

        // Advance overall status
        if (user.KycStatus == KycStatus.Pending)
            user.KycStatus = KycStatus.Submitted;

        await db.SaveChangesAsync();
        return ToDto(doc);
    }

    private static KycDocumentDto ToDto(KycDocument d) => new(
        d.Id, d.DocumentType.ToString(), d.DocumentCategory,
        d.Status.ToString(), d.SubmittedAt, d.ReviewNote);
}
