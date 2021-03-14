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
    public class GamesRepository : IGamesRepository
    {
        private readonly BerkeContext _dbContext = new BerkeContext();
        private static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        //Adds a game to the database. Returns the new game.
        public async Task<Game> AddGame(Game game)
        {
            try
            {
                await _dbContext.AddAsync<Game>(game);
                await _dbContext.SaveChangesAsync();
                return game;
            }
            catch(Exception e)
            {
                Logger.Error(e);
                return new Game();
            }
        }
        //Returns a game based on the game id passed.
        public async Task<Game> GetGameById(int id)
        {
            try
            {
                return await _dbContext.Games.Where(s => s.Id == id).FirstOrDefaultAsync<Game>();
            }
            catch (Exception e)
            {
                Logger.Error(e);
                return new Game();
            }
        }
    }
}
