using System;
using System.Collections.Generic;

namespace Berke.Domain
{
    public class User
    {
        public User()
        {
            GamesOwned = new List<UserGames>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public List<UserGames> GamesOwned { get; set; }
    }
}
