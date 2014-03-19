using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Repository
{
    public interface IUserRepository
    {
        IOperationResponse<string> Login(string username, string password);
    }
}
