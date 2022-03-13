using Game_API.Models;
using Game_API.Models.Requests;

namespace Game_API.Interfaces;

public interface IAuthService
{
    public string VerifyCredentials(string user, string pass);
    public bool UpdatePass(string user, string pass, string newPass);
}