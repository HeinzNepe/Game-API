using Game_API.Models;
using Game_API.Models.Requests;

namespace Game_API.Interfaces;


public interface IScoreService
{
    public int CreateScore(int uid, int points);
    
    public List<GetScoresRequest> GetAllProducts();
}