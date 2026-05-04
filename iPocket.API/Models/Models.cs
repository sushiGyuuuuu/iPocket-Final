using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iPocket.API.Models;

// ═══════════════════════════════════════════════════════════════════════════════
//  USER & AUTH
// ═══════════════════════════════════════════════════════════════════════════════

public class User
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required, MaxLength(20)]
    public string MobileNumber { get; set; } = string.Empty;

    [MaxLength(150)]
    public string? Email { get; set; }

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    public string PinHash { get; set; } = string.Empty;

    public bool IsVerified { get; set; } = false;
    public KycStatus KycStatus { get; set; } = KycStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public Wallet? Wallet { get; set; }
    public ICollection<OtpCode> OtpCodes { get; set; } = [];
    public ICollection<KycDocument> KycDocuments { get; set; } = [];
}

public class OtpCode
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [Required]
    public string Code { get; set; } = string.Empty;   // bcrypt hashed

    [MaxLength(20)]
    public string Purpose { get; set; } = "login";     // login | register | reset

    public DateTime ExpiresAt { get; set; }
    public bool IsUsed { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User? User { get; set; }
}

// ═══════════════════════════════════════════════════════════════════════════════
//  KYC   (Form9 → Form910)
// ═══════════════════════════════════════════════════════════════════════════════

public enum KycStatus { Pending, Submitted, Approved, Rejected }

public class KycDocument
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public KycDocumentType DocumentType { get; set; }

    [Required, MaxLength(100)]
    public string DocumentCategory { get; set; } = string.Empty;  // "Government ID", "Student ID" …

    [MaxLength(500)]
    public string? FilePath { get; set; }

    public KycStatus Status { get; set; } = KycStatus.Submitted;
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    public string? ReviewNote { get; set; }

    public User? User { get; set; }
}

public enum KycDocumentType
{
    Passport, DriversLicense, UMID, SSS, PhilHealth, TIN, StudentID, Other
}

// ═══════════════════════════════════════════════════════════════════════════════
//  WALLET   (Form911 home dashboard)
// ═══════════════════════════════════════════════════════════════════════════════

public class Wallet
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Balance { get; set; } = 0m;

    [Column(TypeName = "decimal(18,2)")]
    public decimal PaymentDue { get; set; } = 0m;

    [MaxLength(30)]
    public string CardNumber { get; set; } = string.Empty;   // "**** **** **** 4179"

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public User? User { get; set; }
    public ICollection<Transaction> Transactions { get; set; } = [];
    public ICollection<SavingsJar> SavingsJars { get; set; } = [];
}

// ═══════════════════════════════════════════════════════════════════════════════
//  TRANSACTIONS   (Form913 deposit / Form914 send / Form918 history)
// ═══════════════════════════════════════════════════════════════════════════════

public class Transaction
{
    [Key]
    public int Id { get; set; }

    public int WalletId { get; set; }
    public TransactionType Type { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? RecipientName { get; set; }

    [MaxLength(20)]
    public string? RecipientNumber { get; set; }

    public TransactionStatus Status { get; set; } = TransactionStatus.Completed;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Wallet? Wallet { get; set; }
}

public enum TransactionType
{
    Deposit,            // Form913
    Send,               // Form914 outgoing
    Receive,            // Form914 incoming (credited to recipient)
    BankTransfer,       // Form911 "Bank Transfer"
    SavingsContribution // contributed to a Jar
}

public enum TransactionStatus { Pending, Completed, Failed, Cancelled }

// ═══════════════════════════════════════════════════════════════════════════════
//  SAVINGS   (Form912 / Form915 Jar of Joy / Form916 Growth Details)
// ═══════════════════════════════════════════════════════════════════════════════

public class SavingsJar
{
    [Key]
    public int Id { get; set; }

    public int WalletId { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = "Jar of Joy";

    [MaxLength(255)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TargetAmount { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal CurrentAmount { get; set; } = 0m;

    /// <summary>Starting interest rate — grows +1 %/yr to match Form916 table.</summary>
    public decimal BaseInterestRate { get; set; } = 0.03m;   // 3 % Year 1

    public int TargetYears { get; set; } = 5;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? TargetDate { get; set; }

    // Navigation
    public Wallet? Wallet { get; set; }
    public ICollection<SavingsContribution> Contributions { get; set; } = [];
}

public class SavingsContribution
{
    [Key]
    public int Id { get; set; }

    public int SavingsJarId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public SavingsJar? SavingsJar { get; set; }
}
