using System.Net;
using System.Text.Json;
using iPocket.API.DTOs;

namespace iPocket.API.Middleware;

public sealed class ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> log)
{
    private static readonly JsonSerializerOptions JsonOpts = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public async Task InvokeAsync(HttpContext ctx)
    {
        try
        {
            await next(ctx);
        }
        catch (Exception ex)
        {
            log.LogError(ex, "Unhandled exception on {Method} {Path}",
                ctx.Request.Method, ctx.Request.Path);

            await WriteErrorAsync(ctx, ex);
        }
    }

    private static Task WriteErrorAsync(HttpContext ctx, Exception ex)
    {
        var (code, message) = ex switch
        {
            KeyNotFoundException        => (HttpStatusCode.NotFound,              ex.Message),
            UnauthorizedAccessException => (HttpStatusCode.Unauthorized,          ex.Message),
            InvalidOperationException   => (HttpStatusCode.BadRequest,            ex.Message),
            _                           => (HttpStatusCode.InternalServerError,   "An unexpected error occurred.")
        };

        ctx.Response.StatusCode  = (int)code;
        ctx.Response.ContentType = "application/json";

        return ctx.Response.WriteAsync(
            JsonSerializer.Serialize(new ErrorResponse(message), JsonOpts));
    }
}
