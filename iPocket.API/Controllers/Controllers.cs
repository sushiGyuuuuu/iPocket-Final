using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using iPocket.API.DTOs;
using iPocket.API.Services.Interfaces;

namespace iPocket.API.Controllers;

// ═══════════════════════════════════════════════════════════════════════════════
//  AUTH   Form4 → Form5 → Form6 → Form7 → Form8
// ═══════════════════════════════════════════════════════════════════════════════

[ApiController, Route("api/auth"), Produces("application/json")]
public sealed class AuthController(IAuthService auth) : ControllerBase
{
    /// <summary>Form5 – enter mobile number → send 4-digit OTP</summary>
    [HttpPost("send-otp")]
    public async Task<IActionResult> SendOtp(SendOtpRequest req)
    {
        var (ok, msg) = await auth.SendOtpAsync(req.MobileNumber, req.Purpose);
        return ok
            ? Ok(new ApiResponse<object>(true, msg, null))
            : BadRequest(new ErrorResponse(msg));
    }

    /// <summary>Form6 – verify OTP code</summary>
    [HttpPost("verify-otp")]
    public async Task<IActionResult> VerifyOtp(VerifyOtpRequest req)
    {
        var ok = await auth.VerifyOtpAsync(req.MobileNumber, req.Code);
        return ok
            ? Ok(new ApiResponse<object>(true, "OTP verified.", null))
            : BadRequest(new ErrorResponse("Invalid or expired OTP."));
    }

    /// <summary>Form7 + Form8 – create account, PIN, get JWT</summary>
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest req)
    {
        try
        {
            var result = await auth.RegisterAsync(req);
            return StatusCode(201, new ApiResponse<AuthResponse>(true, "Account created.", result));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(new ErrorResponse(ex.Message));
        }
    }

    /// <summary>Form4 – existing user login → JWT</summary>
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest req)
    {
        try
        {
            var result = await auth.LoginAsync(req);
            return Ok(new ApiResponse<AuthResponse>(true, "Login successful.", result));
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new ErrorResponse(ex.Message));
        }
    }
}

// ═══════════════════════════════════════════════════════════════════════════════
//  USERS   Form917 Profile · Form919 Settings
// ═══════════════════════════════════════════════════════════════════════════════

[ApiController, Route("api/users"), Authorize, Produces("application/json")]
public sealed class UsersController(IUserService users) : ControllerBase
{
    private int Uid => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

    /// <summary>Form917 – show name, email, mobile, member since, account number</summary>
    [HttpGet("me")]
    public async Task<IActionResult> GetProfile()
    {
        var dto = await users.GetProfileAsync(Uid);
        return Ok(new ApiResponse<UserDto>(true, null, dto));
    }

    /// <summary>Form919 Edit Profile option</summary>
    [HttpPatch("me")]
    public async Task<IActionResult> UpdateProfile(UpdateProfileRequest req)
    {
        var dto = await users.UpdateProfileAsync(Uid, req);
        return Ok(new ApiResponse<UserDto>(true, "Profile updated.", dto));
    }

    /// <summary>PIN gate for sensitive actions (send money, withdraw)</summary>
    [HttpPost("me/verify-pin")]
    public async Task<IActionResult> VerifyPin(VerifyPinRequest req)
    {
        var ok = await users.VerifyPinAsync(Uid, req.Pin);
        return ok
            ? Ok(new ApiResponse<object>(true, "PIN verified.", null))
            : Unauthorized(new ErrorResponse("Incorrect PIN."));
    }
}

// ═══════════════════════════════════════════════════════════════════════════════
//  WALLET   Form911 Home · Form913 Deposit · Form914 Send · Form918 History
// ═══════════════════════════════════════════════════════════════════════════════

[ApiController, Route("api/wallet"), Authorize, Produces("application/json")]
public sealed class WalletController(IWalletService wallet) : ControllerBase
{
    private int Uid => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

    /// <summary>
    /// Form911 – card balance, payment due, card number (**** **** **** 4179),
    /// last 10 transactions (Deposit Fund / Send Money / Received Money / Bank Transfer).
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetWallet()
    {
        var dto = await wallet.GetWalletAsync(Uid);
        return Ok(new ApiResponse<WalletDto>(true, null, dto));
    }

    /// <summary>Form913 – deposit funds (quick +500 / +1000 / +2000 / +5000 buttons)</summary>
    [HttpPost("deposit")]
    public async Task<IActionResult> Deposit(DepositRequest req)
    {
        var tx = await wallet.DepositAsync(Uid, req);
        return Ok(new ApiResponse<TransactionDto>(true, "Deposit successful.", tx));
    }

    /// <summary>Form914 – send money to recipient name + mobile number</summary>
    [HttpPost("send")]
    public async Task<IActionResult> Send(SendMoneyRequest req)
    {
        var tx = await wallet.SendMoneyAsync(Uid, req);
        return Ok(new ApiResponse<TransactionDto>(true, "Money sent.", tx));
    }

    /// <summary>
    /// Form918 – paginated transaction history.
    /// filter: All | Deposit | Send | Receive | BankTransfer | SavingsContribution
    /// </summary>
    [HttpGet("transactions")]
    public async Task<IActionResult> GetTransactions(
        [FromQuery] string? filter = "All",
        [FromQuery] int     page   = 1,
        [FromQuery] int     size   = 20)
    {
        var result = await wallet.GetTransactionsAsync(Uid, filter, page, size);
        return Ok(new ApiResponse<TransactionPageDto>(true, null, result));
    }
}

// ═══════════════════════════════════════════════════════════════════════════════
//  SAVINGS   Form912 Jar list · Form915 Jar of Joy · Form916 Growth Details
// ═══════════════════════════════════════════════════════════════════════════════

[ApiController, Route("api/savings"), Authorize, Produces("application/json")]
public sealed class SavingsController(ISavingsService savings) : ControllerBase
{
    private int Uid => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

    /// <summary>Form912 – list all Jar of Joy savings jars with progress bar data</summary>
    [HttpGet]
    public async Task<IActionResult> GetJars()
    {
        var list = await savings.GetJarsAsync(Uid);
        return Ok(new ApiResponse<List<SavingsJarDto>>(true, null, list));
    }

    /// <summary>Form915 / Form916 – single jar: balance, 75 % progress, interest earned, growth table</summary>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetJar(int id)
    {
        var jar = await savings.GetJarAsync(Uid, id);
        return Ok(new ApiResponse<SavingsJarDto>(true, null, jar));
    }

    /// <summary>Create a new Jar of Joy (baseInterestRate 3 %, targetYears 5 by default)</summary>
    [HttpPost]
    public async Task<IActionResult> CreateJar(CreateJarRequest req)
    {
        var jar = await savings.CreateJarAsync(Uid, req);
        return StatusCode(201, new ApiResponse<SavingsJarDto>(true, "Jar created.", jar));
    }

    /// <summary>Form915 save button – add money (moves from wallet balance to jar)</summary>
    [HttpPost("{id:int}/contribute")]
    public async Task<IActionResult> Contribute(int id, ContributeRequest req)
    {
        var jar = await savings.ContributeAsync(Uid, id, req);
        return Ok(new ApiResponse<SavingsJarDto>(true, "Contribution added.", jar));
    }
}

// ═══════════════════════════════════════════════════════════════════════════════
//  KYC   Form9 Verify Identity · Form910 Select Category
// ═══════════════════════════════════════════════════════════════════════════════

[ApiController, Route("api/kyc"), Authorize, Produces("application/json")]
public sealed class KycController(IKycService kyc) : ControllerBase
{
    private int Uid => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

    /// <summary>Form9 – KYC status (Pending / Submitted / Approved / Rejected) + submitted docs</summary>
    [HttpGet]
    public async Task<IActionResult> GetStatus()
    {
        var dto = await kyc.GetStatusAsync(Uid);
        return Ok(new ApiResponse<KycStatusDto>(true, null, dto));
    }

    /// <summary>
    /// Form910 – submit identity document.
    /// documentCategory: "Government ID" | "Student ID" | "Other IDs"
    /// documentType: Passport | DriversLicense | UMID | SSS | PhilHealth | TIN | StudentID | Other
    /// </summary>
    [HttpPost("submit")]
    public async Task<IActionResult> Submit(SubmitKycRequest req)
    {
        var doc = await kyc.SubmitDocumentAsync(Uid, req);
        return StatusCode(201, new ApiResponse<KycDocumentDto>(true, "Document submitted.", doc));
    }
}
