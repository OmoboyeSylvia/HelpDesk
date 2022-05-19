using HelpDesk.Interface;
using HelpDesk.Models;
using HelpDesk.Models.Request;
using System.Collections;
using HelpDesk.Repository;
using static HelpDesk.Repository.GenericRepository;
using System.Data.Entity;

namespace HelpDesk.Repository
{
    public class AuthenticationRepository : GenericRepository<User>, IAuthentication
    {
        public AuthenticationRepository(HelpDeskDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable> Login(LoginRequest request)
        {
            try
            {
        
                var res = await _context.Users
                   .Where(c => c.FullName == request.FullName)
                   .FirstOrDefaultAsync();

                return ((IEnumerable)res);
            }
            catch (Exception ex)
            {
               
                throw;
            }
        }

        public Task<IEnumerable> Register(RegisterRequest createRequest)
        {
            throw new NotImplementedException();
        }
    }
}
