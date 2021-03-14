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
    public class CollectionRepository : ICollectionRepository
    {
        private readonly BerkeContext _dbContext = new BerkeContext();
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        //Return a list of games owned by the supplied user.
        public async Task<List<Game>> GetGames(int userId)
        {
            try
            {
                return await _dbContext.Games.
                    Where(a => a.UsersOwning
                    .Any(b => b.UserId == userId))
                    .Include(c => c.Publishers)
                    .Include(d => d.Genres)
                    .ToListAsync();
            }
            catch(Exception e)
            {
                Logger.Error(e);
                return new List<Game>();
            }
        }
        //Add a game to the user's collection.
        public async Task<Game> AddGame(int userId, int gameId)
        {
            try
            {
                //Get the game object by the game ID (confirming the game exists)
                var gameToAdd = await _dbContext.Games.Where(s => s.Id == gameId).FirstOrDefaultAsync();
                //Get the user object by the user ID
                var userToAddTo = await _dbContext.Users.Where(s => s.Id == userId).FirstOrDefaultAsync();

                //Add the game ID to the user
                userToAddTo.GamesOwned.Add(new UserGames { GameId = gameToAdd.Id, UserId = userToAddTo.Id });
                await _dbContext.SaveChangesAsync();

                return gameToAdd;
            }

            catch (Exception e)
            {
                Logger.Error(e);
                return new Game();
            }
        }
        //Remove a game from the user's list.
        public async Task<int> RemoveGame(int userId, int gameId)
        {
            try
            {
                var userToRemoveFrom = await _dbContext.Users.Where(s => s.Id == userId).Include(s => s.GamesOwned).FirstOrDefaultAsync();
                var gameToRemove = userToRemoveFrom.GamesOwned.SingleOrDefault(s => s.GameId == gameId);
                userToRemoveFrom.GamesOwned.Remove(gameToRemove);
                await _dbContext.SaveChangesAsync();

                return userToRemoveFrom.GamesOwned.Count;
            }
            catch (Exception e)
            {
                Logger.Error(e);
                return -1;
            }
        }
    }
}
