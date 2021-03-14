using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berke.Domain;
using System.IdentityModel.Tokens.Jwt;

namespace Berke_Interview
{
    public class UserHelper
    {
        public static int GetUserIdFromToken(string jwtToken)
        {
            //Create a Jwt Handler
            var tokenHandler = new JwtSecurityTokenHandler();
            //Read the token object from string
            var token = tokenHandler.ReadJwtToken(jwtToken);
            //Grab the unique name as the Id
            var userId = token.Claims.First(x => x.Type == "unique_name").Value;
            //Convert the result to an int and return
            return Convert.ToInt32(userId);
        }
    }
}
