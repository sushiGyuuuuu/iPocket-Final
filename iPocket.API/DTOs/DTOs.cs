using System.ComponentModel.DataAnnotations;
using iPocket.API.Models;

namespace iPocket.API.DTOs;

// ── Auth ──────────────────────────────────────────────────────────────────────

public sealed record SendOtpRequest(
    [Required, MaxLength(20)] string MobileNumber,
    string Purpose = "login");

public sealed record VerifyOtpRequest(
    [Required, MaxLength(20)] string MobileNumber,
    [Required, StringLength(6, MinimumLength = 4)] string Code);

public sealed record RegisterRequest(
    [Required, MaxLength(100)] string FullName,
    [Required, MaxLength(20)]  string MobileNumber,
    [EmailAddress]             string? Email,
    [Required, MinLength(8)]   string Password,
    [Required, StringLength(6, MinimumLength = 6)] string Pin);

public sealed record LoginRequest(
    [Required, MaxLength(20)] string MobileNumber,
    [Required]                string Password);

public sealed record AuthResponse(string Token, UserDto User);

// ── User ──────────────────────────────────────────────────────────────────────

public sealed record UserDto(
    int      Id,
    string   FullName,
    string   MobileNumber,
    string?  Email,
    bool     IsVerified,
    string   KycStatus,
    DateTime CreatedAt);

public sealed record UpdateProfileRequest(
    [MaxLength(100)] string? FullName,
    [EmailAddress]   string? Email);

public sealed record VerifyPinRequest(
    [Required, StringLength(6, MinimumLength = 6)] string Pin);

// ── Wallet ────────────────────────────────────────────────────────────────────

public sealed record WalletDto(
    int                  Id,
    decimal              Balance,
    decimal              PaymentDue,
    string               CardNumber,
    List<TransactionDto> RecentTransactions);

// ── Transactions ──────────────────────────────────────────────────────────────

public sealed record TransactionDto(
    int      Id,
    string   Type,
    decimal  Amount,
    string   Description,
    string?  RecipientName,
    string   Status,
    DateTime CreatedAt);

public sealed record TransactionPageDto(
    List<TransactionDto> Items,
    int                  TotalCount,
    int                  Page,
    int                  PageSize,
    string?              Filter);

public sealed record DepositRequest(
    [Required, Range(1, 999_999)] decimal Amount,
    string Description = "Deposit Fund");

public sealed record SendMoneyRequest(
    [Required, MaxLength(100)] string  RecipientName,
    [Required, MaxLength(20)]  string  RecipientNumber,
    [Required, Range(1, 999_999)] decimal Amount,
    string? Note);

// ── Savings ───────────────────────────────────────────────────────────────────

public sealed record SavingsJarDto(
    int                       Id,
    string                    Name,
    string?                   Description,
    decimal                   TargetAmount,
    decimal                   CurrentAmount,
    double                    ProgressPercent,
    decimal                   BaseInterestRate,
    int                       TargetYears,
    DateTime                  CreatedAt,
    DateTime?                 TargetDate,
    List<GrowthYearDto>       GrowthProjection);

/// <summary>One row in the Form916 Growth Details table.</summary>
public sealed record GrowthYearDto(
    int     Year,
    decimal InterestRatePct,   // e.g. 3.0 for 3 %
    decimal Balance,
    decimal InterestEarned,
    double  ProgressPercent);

public sealed record CreateJarRequest(
    [Required, MaxLength(100)]         string  Name,
    string?                            Description,
    [Required, Range(1, 10_000_000)]   decimal TargetAmount,
    decimal BaseInterestRate = 0.03m,
    int     TargetYears      = 5);

public sealed record ContributeRequest(
    [Required, Range(1, 999_999)] decimal Amount);

// ── KYC ───────────────────────────────────────────────────────────────────────

public sealed record SubmitKycRequest(
    [Required]         string          DocumentCategory,
    [Required]         KycDocumentType DocumentType,
    string?            FilePath);

public sealed record KycStatusDto(
    string               OverallStatus,
    List<KycDocumentDto> Documents);

public sealed record KycDocumentDto(
    int      Id,
    string   DocumentType,
    string   DocumentCategory,
    string   Status,
    DateTime SubmittedAt,
    string?  ReviewNote);

// ── Shared envelope ───────────────────────────────────────────────────────────

public sealed record ApiResponse<T>(bool Success, string? Message, T? Data);
public sealed record ErrorResponse(string Message, string? Detail = null);
