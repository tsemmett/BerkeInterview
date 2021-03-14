using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berke.Data;
using Berke.Domain;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using NLog;


namespace Berke_Interview.Controllers
{
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        [HttpPost]
        public async Task<IActionResult> AuthenticateUser([FromServices] IUserRepository repository, [FromServices] IConfiguration config, string username, string password)
        {
            try
            {
                //If either the username or password is left out, return a bad request error.
                if ((username == null) || (password == null))
                {

                    return StatusCode(400, "Username and Password are required.");
                }

                //Validate the user
                var validatedUser = await repository.AuthenticateUser(new User { Username = username, Password = password });

                if (validatedUser.Id == 0)
                {
                    return StatusCode(401, "Unable to authenticate the username and password provided.");
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                //Get Key
                string secret = config.GetSection("AppSettings").GetValue(typeof(string), "Secret").ToString();
                var key = Encoding.ASCII.GetBytes(secret);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, validatedUser.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddYears(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                return StatusCode(200, new
                {
                    validatedUser.Id,
                    validatedUser.Username,
                    Token = tokenString
                }); 

            }
            catch (Exception e)
            {
                Logger.Error(e);
                return StatusCode(500, "An exception was thrown and logged.");
            }
        }
    }
}
