using Game_API.Models;

namespace Game_API.Interfaces;


public interface IScoreService
{
    public int CreateScore(int uid, int points);
}