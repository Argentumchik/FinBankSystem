using FBS.Core.DTOs;
using FBS.Core.Interfaces;
using FBS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace FBS.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(UserRegisterRequest request)
    {
        return Ok(await _userService.Register(request));
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(UserLoginRequest request)
    {
        var token = await _userService.Login(request);
        
        HttpContext.Response.Cookies.Append("tasty-cookies", token);

        return Ok();
    }
}