using DI_Commun.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness
{
    public interface IUserService : IAction<User>
    {
        bool IfMailExists(string email);
        bool AddRole(int userId, int roleId);
    }
}
