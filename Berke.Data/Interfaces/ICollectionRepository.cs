using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berke.Domain;

namespace Berke.Data
{
    //Interface for managing game collections.
    public interface ICollectionRepository
    {
        //Return a list of games owned by the supplied user.
        public Task<List<Game>> GetGames(int userId);
        //Add a game to the user's collection.
        public Task<Game> AddGame(int userId, int gameId);
        //Remove a game from the user's list.
        public Task<int> RemoveGame(int userId, int gameId);
    }
}
