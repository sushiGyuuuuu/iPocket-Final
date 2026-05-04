using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iPocket.API.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id           = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                FullName     = table.Column<string>(maxLength: 100, nullable: false),
                MobileNumber = table.Column<string>(maxLength: 20,  nullable: false),
                Email        = table.Column<string>(maxLength: 150, nullable: true),
                PasswordHash = table.Column<string>(nullable: false),
                PinHash      = table.Column<string>(nullable: false),
                IsVerified   = table.Column<bool>(nullable: false, defaultValue: false),
                KycStatus    = table.Column<string>(nullable: false, defaultValue: "Pending"),
                CreatedAt    = table.Column<DateTime>(nullable: false)
            },
            constraints: t => t.PrimaryKey("PK_Users", x => x.Id));

        migrationBuilder.CreateIndex("IX_Users_MobileNumber", "Users", "MobileNumber", unique: true);
        migrationBuilder.CreateIndex("IX_Users_Email",        "Users", "Email",        unique: true);

        // ── OtpCodes ─────────────────────────────────────────────────────────

        migrationBuilder.CreateTable(
            name: "OtpCodes",
            columns: table => new
            {
                Id        = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                UserId    = table.Column<int>(nullable: false),
                Code      = table.Column<string>(nullable: false),
                Purpose   = table.Column<string>(maxLength: 20, nullable: false, defaultValue: "login"),
                ExpiresAt = table.Column<DateTime>(nullable: false),
                IsUsed    = table.Column<bool>(nullable: false, defaultValue: false),
                CreatedAt = table.Column<DateTime>(nullable: false)
            },
            constraints: t =>
            {
                t.PrimaryKey("PK_OtpCodes", x => x.Id);
                t.ForeignKey("FK_OtpCodes_Users_UserId", x => x.UserId, "Users", "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        // ── KycDocuments ──────────────────────────────────────────────────────

        migrationBuilder.CreateTable(
            name: "KycDocuments",
            columns: table => new
            {
                Id               = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                UserId           = table.Column<int>(nullable: false),
                DocumentType     = table.Column<string>(nullable: false),
                DocumentCategory = table.Column<string>(maxLength: 100, nullable: false),
                FilePath         = table.Column<string>(maxLength: 500, nullable: true),
                Status           = table.Column<string>(nullable: false, defaultValue: "Submitted"),
                SubmittedAt      = table.Column<DateTime>(nullable: false),
                ReviewNote       = table.Column<string>(nullable: true)
            },
            constraints: t =>
            {
                t.PrimaryKey("PK_KycDocuments", x => x.Id);
                t.ForeignKey("FK_KycDocuments_Users_UserId", x => x.UserId, "Users", "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        // ── Wallets ───────────────────────────────────────────────────────────

        migrationBuilder.CreateTable(
            name: "Wallets",
            columns: table => new
            {
                Id         = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                UserId     = table.Column<int>(nullable: false),
                Balance    = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                PaymentDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                CardNumber = table.Column<string>(maxLength: 30, nullable: false, defaultValue: ""),
                CreatedAt  = table.Column<DateTime>(nullable: false)
            },
            constraints: t =>
            {
                t.PrimaryKey("PK_Wallets", x => x.Id);
                t.ForeignKey("FK_Wallets_Users_UserId", x => x.UserId, "Users", "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex("IX_Wallets_UserId", "Wallets", "UserId", unique: true);

        // ── Transactions ──────────────────────────────────────────────────────

        migrationBuilder.CreateTable(
            name: "Transactions",
            columns: table => new
            {
                Id              = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                WalletId        = table.Column<int>(nullable: false),
                Type            = table.Column<string>(nullable: false),
                Amount          = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                Description     = table.Column<string>(maxLength: 200, nullable: false, defaultValue: ""),
                RecipientName   = table.Column<string>(maxLength: 100, nullable: true),
                RecipientNumber = table.Column<string>(maxLength: 20,  nullable: true),
                Status          = table.Column<string>(nullable: false, defaultValue: "Completed"),
                CreatedAt       = table.Column<DateTime>(nullable: false)
            },
            constraints: t =>
            {
                t.PrimaryKey("PK_Transactions", x => x.Id);
                t.ForeignKey("FK_Transactions_Wallets_WalletId", x => x.WalletId, "Wallets", "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        // ── SavingsJars ───────────────────────────────────────────────────────

        migrationBuilder.CreateTable(
            name: "SavingsJars",
            columns: table => new
            {
                Id               = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                WalletId         = table.Column<int>(nullable: false),
                Name             = table.Column<string>(maxLength: 100, nullable: false, defaultValue: "Jar of Joy"),
                Description      = table.Column<string>(maxLength: 255, nullable: true),
                TargetAmount     = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                CurrentAmount    = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                BaseInterestRate = table.Column<decimal>(nullable: false, defaultValue: 0.03m),
                TargetYears      = table.Column<int>(nullable: false, defaultValue: 5),
                CreatedAt        = table.Column<DateTime>(nullable: false),
                TargetDate       = table.Column<DateTime>(nullable: true)
            },
            constraints: t =>
            {
                t.PrimaryKey("PK_SavingsJars", x => x.Id);
                t.ForeignKey("FK_SavingsJars_Wallets_WalletId", x => x.WalletId, "Wallets", "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        // ── SavingsContributions ──────────────────────────────────────────────

        migrationBuilder.CreateTable(
            name: "SavingsContributions",
            columns: table => new
            {
                Id           = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                SavingsJarId = table.Column<int>(nullable: false),
                Amount       = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                CreatedAt    = table.Column<DateTime>(nullable: false)
            },
            constraints: t =>
            {
                t.PrimaryKey("PK_SavingsContributions", x => x.Id);
                t.ForeignKey("FK_SavingsContributions_SavingsJars_SavingsJarId",
                    x => x.SavingsJarId, "SavingsJars", "Id", onDelete: ReferentialAction.Cascade);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable("SavingsContributions");
        migrationBuilder.DropTable("SavingsJars");
        migrationBuilder.DropTable("Transactions");
        migrationBuilder.DropTable("Wallets");
        migrationBuilder.DropTable("KycDocuments");
        migrationBuilder.DropTable("OtpCodes");
        migrationBuilder.DropTable("Users");
    }
}
