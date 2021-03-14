using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Berke.Data;
using Berke.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Net.Http.Headers;
using NLog;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace Berke_Interview.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        [HttpPost]
        public async Task<IActionResult> AddGame([FromServices] IGamesRepository gamesRepository, [FromServices] IUserRepository userRepository)
        {
            try
            {
                //Game genres were not being properly populated from JSON without explicit JSON Deserialization, so this was required.
                Game game = new Game();
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    string gameData = await reader.ReadToEndAsync();
                    game = JsonConvert.DeserializeObject<Game>(gameData);

                }
                //Input validation
                if (game.Name == null)
                {
                    return StatusCode(400, "Game name is required.");
                }

                if (game.Publishers[0].PublisherId == 0)
                {
                    return StatusCode(400, "Game publishers are required.");
                }

                if (game.Genres[0].GenreId == 0)
                {
                    return StatusCode(400, "Game genres are required.");
                }

                if (game.Overview == null)
                {
                    return StatusCode(400, "Game overview is required.");
                }

                if (game.ReleaseDate == default)
                {
                    return StatusCode(400, "Game release date is required.");
                }

                //Is the user an admin?

                //Get their token string from the HTTP header
                string tokenString = HttpContext.Request.Headers[HeaderNames.Authorization];
                //Trim the Bearer tag off the front
                tokenString = tokenString.Replace("Bearer ","");
                //Pass the token to the helper to locate the user data
                int userId = UserHelper.GetUserIdFromToken(tokenString);
                User validatedUser = await userRepository.GetUserById(userId);

                if (!validatedUser.IsAdmin)
                {
                    return StatusCode(403, "User is not authorized to add games");
                }

                //Add the game otherwise
                Game newGame = await gamesRepository.AddGame(game);

                //If the new game is valid, return an OK and the new game data
                if (newGame.Id > 0)
                {
                    string gameOut = JsonConvert.SerializeObject(newGame);
                    return StatusCode(200, gameOut);
                }
                //Otherwise return a server error
                else
                {
                    return StatusCode(500, "Error adding game to database.");
                }
            }
            catch(Exception e)
            {
                Logger.Error(e);
                return StatusCode(500, "An exception was thrown and logged.");
            }
        }
    }
}
