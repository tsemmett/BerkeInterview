using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berke.Domain;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace Berke.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly BerkeContext _dbContext = new BerkeContext();
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public async Task<User> AuthenticateUser(User user)
        {
            try
            {
                //Find the username in the database and confirm the password matches.
                var userToValidate = await _dbContext.Users.Where(s => s.Username == user.Username).FirstOrDefaultAsync();

                //If no valid result, or the passwords don't match return a blank user (no user found)
                if ((userToValidate.Id < 0) || (userToValidate.Password != user.Password))
                {
                    return new User();
                }
                //Otherwise, return the validated user
                return userToValidate;
            }
            catch (Exception e)
            {
                Logger.Error(e);
                return new User();
            }
        }

        public async Task<User> GetUserById(int id)
        {
            try
            {
                return await _dbContext.Users.Where(s => s.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception e)

            {
                Logger.Error(e);
                return new User();
            }
        }
    }
}
