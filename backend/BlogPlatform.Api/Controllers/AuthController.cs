using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // TODO: Implement authentication operations
    
    [HttpPost("register")]
    public IActionResult Register()
    {
        return Ok("User registration");
    }
    
    [HttpPost("login")]
    public IActionResult Login()
    {
        return Ok("User login");
    }
    
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        return Ok("User logout");
    }
    
    [HttpPost("refresh")]
    public IActionResult RefreshToken()
    {
        return Ok("Refresh token");
    }
}
