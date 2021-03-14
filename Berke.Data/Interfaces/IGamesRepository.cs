using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berke.Domain;

namespace Berke.Data
{
    //Interface for managing games in the database.
    public interface IGamesRepository
    {
        //Adds a game to the database. Returns the ID of the new game.
        public Task<Game> AddGame(Game game);
        public Task<Game> GetGameById(int id);
    }
}
