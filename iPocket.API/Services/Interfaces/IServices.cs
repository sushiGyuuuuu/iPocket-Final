using iPocket.API.DTOs;
using iPocket.API.Models;

namespace iPocket.API.Services.Interfaces;

public interface IAuthService
{
    Task<(bool Ok, string Message)> SendOtpAsync(string mobileNumber, string purpose);
    Task<bool>         VerifyOtpAsync(string mobileNumber, string code);
    Task<AuthResponse> RegisterAsync(RegisterRequest req);
    Task<AuthResponse> LoginAsync(LoginRequest req);
    string             GenerateToken(User user);
}

public interface IUserService
{
    Task<UserDto> GetProfileAsync(int userId);
    Task<UserDto> UpdateProfileAsync(int userId, UpdateProfileRequest req);
    Task<bool>    VerifyPinAsync(int userId, string pin);
}

public interface IWalletService
{
    Task<WalletDto>         GetWalletAsync(int userId);
    Task<TransactionDto>    DepositAsync(int userId, DepositRequest req);
    Task<TransactionDto>    SendMoneyAsync(int userId, SendMoneyRequest req);
    Task<TransactionPageDto> GetTransactionsAsync(int userId, string? filter, int page, int size);
}

public interface ISavingsService
{
    Task<List<SavingsJarDto>> GetJarsAsync(int userId);
    Task<SavingsJarDto>       GetJarAsync(int userId, int jarId);
    Task<SavingsJarDto>       CreateJarAsync(int userId, CreateJarRequest req);
    Task<SavingsJarDto>       ContributeAsync(int userId, int jarId, ContributeRequest req);
}

public interface IKycService
{
    Task<KycStatusDto>   GetStatusAsync(int userId);
    Task<KycDocumentDto> SubmitDocumentAsync(int userId, SubmitKycRequest req);
}
