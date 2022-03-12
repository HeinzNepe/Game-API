using Game_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Game_API.Controllers;

public class UserController : Controller
{    
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
}