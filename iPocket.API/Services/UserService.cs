using iPocket.API.Data;
using iPocket.API.DTOs;
using iPocket.API.Models;
using iPocket.API.Services.Interfaces;

namespace iPocket.API.Services;

public sealed class UserService(AppDbContext db) : IUserService
{
    public async Task<UserDto> GetProfileAsync(int userId)
    {
        var user = await db.Users.FindAsync(userId)
            ?? throw new KeyNotFoundException("User not found.");
        return ToDto(user);
    }

    public async Task<UserDto> UpdateProfileAsync(int userId, UpdateProfileRequest req)
    {
        var user = await db.Users.FindAsync(userId)
            ?? throw new KeyNotFoundException("User not found.");

        if (req.FullName is not null) user.FullName = req.FullName;
        if (req.Email    is not null) user.Email    = req.Email;

        await db.SaveChangesAsync();
        return ToDto(user);
    }

    public async Task<bool> VerifyPinAsync(int userId, string pin)
    {
        var user = await db.Users.FindAsync(userId);
        return user is not null && BCrypt.Net.BCrypt.Verify(pin, user.PinHash);
    }

    private static UserDto ToDto(User u) => new(
        u.Id, u.FullName, u.MobileNumber, u.Email,
        u.IsVerified, u.KycStatus.ToString(), u.CreatedAt);
}
