using Game_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Game_API.Controllers;

[ApiController]
[Route("score")]
public class ScoreController : Controller
{
    private readonly IScoreService _scoreService;

    public ScoreController(IScoreService scoreService)
    {
        _scoreService = scoreService;
    }
}