using System;
using System.Collections.Generic;
using System.Text;

namespace Berke.Domain
{
    public class Genre
    {
        public Genre()
        {
            GamesInGenre = new List<GameGenres>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<GameGenres> GamesInGenre { get; set; }

    }
}
