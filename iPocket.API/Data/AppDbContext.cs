using Microsoft.EntityFrameworkCore;
using iPocket.API.Models;

namespace iPocket.API.Data;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User>                 Users                => Set<User>();
    public DbSet<OtpCode>              OtpCodes             => Set<OtpCode>();
    public DbSet<KycDocument>          KycDocuments         => Set<KycDocument>();
    public DbSet<Wallet>               Wallets              => Set<Wallet>();
    public DbSet<Transaction>          Transactions         => Set<Transaction>();
    public DbSet<SavingsJar>           SavingsJars          => Set<SavingsJar>();
    public DbSet<SavingsContribution>  SavingsContributions => Set<SavingsContribution>();

    protected override void OnModelCreating(ModelBuilder mb)
    {
        base.OnModelCreating(mb);

        // ── Users ──────────────────────────────────────────────────────────
        mb.Entity<User>(e =>
        {
            e.HasIndex(u => u.MobileNumber).IsUnique();
            e.HasIndex(u => u.Email).IsUnique();
            e.Property(u => u.KycStatus).HasConversion<string>();

            e.HasOne(u => u.Wallet)
             .WithOne(w => w.User)
             .HasForeignKey<Wallet>(w => w.UserId)
             .OnDelete(DeleteBehavior.Cascade);

            e.HasMany(u => u.OtpCodes)
             .WithOne(o => o.User)
             .HasForeignKey(o => o.UserId)
             .OnDelete(DeleteBehavior.Cascade);

            e.HasMany(u => u.KycDocuments)
             .WithOne(k => k.User)
             .HasForeignKey(k => k.UserId)
             .OnDelete(DeleteBehavior.Cascade);
        });

        // ── KYC Documents ─────────────────────────────────────────────────
        mb.Entity<KycDocument>(e =>
        {
            e.Property(k => k.DocumentType).HasConversion<string>();
            e.Property(k => k.Status).HasConversion<string>();
        });

        // ── Wallets ───────────────────────────────────────────────────────
        mb.Entity<Wallet>(e =>
        {
            e.HasIndex(w => w.UserId).IsUnique();

            e.HasMany(w => w.Transactions)
             .WithOne(t => t.Wallet)
             .HasForeignKey(t => t.WalletId)
             .OnDelete(DeleteBehavior.Cascade);

            e.HasMany(w => w.SavingsJars)
             .WithOne(s => s.Wallet)
             .HasForeignKey(s => s.WalletId)
             .OnDelete(DeleteBehavior.Cascade);
        });

        // ── Transactions ─────────────────────────────────────────────────
        mb.Entity<Transaction>(e =>
        {
            e.Property(t => t.Type).HasConversion<string>();
            e.Property(t => t.Status).HasConversion<string>();
        });

        // ── SavingsJars ───────────────────────────────────────────────────
        mb.Entity<SavingsJar>(e =>
        {
            e.HasMany(s => s.Contributions)
             .WithOne(c => c.SavingsJar)
             .HasForeignKey(c => c.SavingsJarId)
             .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
