using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berke.Domain;

namespace Berke.Data
{
    //Interface for managing users. Though we only need to authenticate them for this project, should the need to add/remove/update users arise, that could be added here.
    public interface IUserRepository
    {
        public Task<User> AuthenticateUser(User user);
        public Task<User> GetUserById(int id);
    }
}
