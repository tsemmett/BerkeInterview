using System;
using System.Collections.Generic;
using System.Text;

namespace Berke.Domain
{
    public class Game
    {
        public Game()
        {
            UsersOwning = new List<UserGames>();
            Genres = new List<GameGenres>();
            Publishers = new List<PublisherGames>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Overview { get; set; }
        public List<UserGames> UsersOwning { get; set; }
        public List<GameGenres> Genres { get; set; }
        public List<PublisherGames> Publishers { get; set; }
    }
}
