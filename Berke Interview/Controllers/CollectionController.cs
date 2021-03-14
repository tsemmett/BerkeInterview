using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Net.Http.Headers;
using Berke.Domain;
using Berke.Data;
using System.ComponentModel.DataAnnotations;
using NLog;
using Newtonsoft.Json;

namespace Berke_Interview.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class CollectionController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ICollectionRepository _collectionRepository;
        private readonly IGamesRepository _gamesRepository;

        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public CollectionController(IUserRepository userRepository, ICollectionRepository collectionRepository, IGamesRepository gamesRepository)
        {
            _userRepository = userRepository;
            _collectionRepository = collectionRepository;
            _gamesRepository = gamesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                //Get the logged in user
                //Get their token string from the HTTP header
                string tokenString = HttpContext.Request.Headers[HeaderNames.Authorization];
                //Trim the Bearer tag off the front
                tokenString = tokenString.Replace("Bearer ", "");
                //Pass the token to the helper to locate the user data
                int userId = UserHelper.GetUserIdFromToken(tokenString);
                User validatedUser = await _userRepository.GetUserById(userId);

                List<Game> gamesCollection = await _collectionRepository.GetGames(validatedUser.Id);

                return StatusCode(200, JsonConvert.SerializeObject(gamesCollection));
            }
            catch(Exception e)
            {
                Logger.Error(e);
                return StatusCode(500, "An exception was thrown and logged.");
            }
        }

        [HttpPost("{gameId:int}")]
        public async Task<IActionResult> AddGame(int gameId)
        {
            try
            {
                //Get the logged in user
                //Get their token string from the HTTP header
                string tokenString = HttpContext.Request.Headers[HeaderNames.Authorization];
                //Trim the Bearer tag off the front
                tokenString = tokenString.Replace("Bearer ", "");
                //Pass the token to the helper to locate the user data
                int userId = UserHelper.GetUserIdFromToken(tokenString);

                User validatedUser = await _userRepository.GetUserById(userId);
                Game gameToAdd = await _gamesRepository.GetGameById(gameId);
                Game newGame = await _collectionRepository.AddGame(validatedUser.Id, gameToAdd.Id);

                return StatusCode(200, newGame);
            }
            catch(Exception e)
            {
                Logger.Error(e);
                return StatusCode(500, "An exception was thrown and logged.");
            }
        }

        [HttpDelete("{gameId:int}")]
        public async Task<IActionResult> RemoveGame(int gameId)
        {
            try
            {
                //Get the logged in user
                //Get their token string from the HTTP header
                string tokenString = HttpContext.Request.Headers[HeaderNames.Authorization];
                //Trim the Bearer tag off the front
                tokenString = tokenString.Replace("Bearer ", "");
                //Pass the token to the helper to locate the user data
                int userId = UserHelper.GetUserIdFromToken(tokenString);

                User validatedUser = await _userRepository.GetUserById(userId);
                if (validatedUser.Id == 0)
                {
                    return StatusCode(404, "User Not Found");
                }

                Game gameToRemove = await _gamesRepository.GetGameById(gameId);
                if (gameToRemove.Id == 0)
                {
                    return StatusCode(404, "Game Not Found");
                }

                int remaining = await _collectionRepository.RemoveGame(validatedUser.Id, gameToRemove.Id);

                return StatusCode(200, $"Game # {gameToRemove.Id} removed. {remaining} games remaining in collection for {validatedUser.Username}.");
            }
            catch(Exception e)
            {
                Logger.Error(e);
                return StatusCode(500, "An exception was thrown and logged.");
            }
        }
    }
}
