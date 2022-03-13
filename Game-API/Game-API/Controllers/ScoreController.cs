using Game_API.Interfaces;
using Game_API.Models;
using Game_API.Models.Requests;
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

    [HttpPost("create")]
    public int CreateScore([FromBody] CreateScoreRequest payload)
    {
        return _scoreService.CreateScore(payload.Uid, payload.Points);
    }
    
    [HttpGet("all")]
    public IEnumerable<GetScoresRequest> GetAllProducts()
    {
        return _scoreService.GetAllProducts();
    }
}