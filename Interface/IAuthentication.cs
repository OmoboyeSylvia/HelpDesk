using HelpDesk.Models;
using HelpDesk.Models.Request;
using System.Collections;
using static HelpDesk.Interface.IGeneric;

namespace HelpDesk.Interface
{
    public interface IAuthentication : IGeneric<User>
    {
        Task<IEnumerable> Register(RegisterRequest createRequest);
        Task<IEnumerable> Login(LoginRequest model);
    }
}
