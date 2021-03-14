using System;
using System.Collections.Generic;
using System.Text;

namespace Berke.Domain
{
    public class Publisher
    {
        public Publisher()
        {
            GamesPublished = new List<PublisherGames>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<PublisherGames> GamesPublished { get; set; }
    }
}
