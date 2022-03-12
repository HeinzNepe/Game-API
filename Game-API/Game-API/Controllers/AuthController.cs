using Microsoft.AspNetCore.Mvc;
using Game_API.Interfaces;
using Game_API.Models;
using Game_API.Models.Requests;


namespace Game_API.Controllers;


[ApiController]
[Route("auth")]

public class AuthController : Controller
{

    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    public string VerifyCredentials([FromBody] VerifyRequest payload)
    {
        return _authService.VerifyCredentials(payload.User, payload.Pass);
    }

    [HttpPost("update")]
    public bool UpdatePass([FromBody] UpdateCredentialsRequest payload)
    {
        return _authService.UpdatePass(payload.Token, payload.Pass, payload.NewPass);
    }
    
}