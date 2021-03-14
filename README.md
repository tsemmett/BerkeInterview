# BerkeInterview
Interview project for Berke

An example API for managing a collection of games, as requested by Berke during their interview process.
The project itself is running at:

https://berkeinterview.azurewebsites.net/

Endpoints defined:

 - /auth - takes a username/password (via POST) and returns a JWT token if valid.
 - /games - takes a game object (via POST) and adds it to the system, if the user has admin rights (using the token issued from /auth)

When passing a game object to the API (POSTing via the /games endpoint), the game ought to look something like:
{
    "Name":"Fallout 4",
    "Overview": "War... War never changes.",
    "ReleaseDate":"2015-11-10T00:00Z",
    "Genres":
    [
        {
            "GenreId":"3"
        }
    ],
    "Publishers":
    [
        {
            "PublisherId":"1"
        }
    ]

}

 - /collection - (GET) returns the game list for the user asscoiated with the token provided by /auth
 - /collection/{gameId} - (POST) Adds a game to the user's list by the game ID
 - /collection/{gameId} - (DELETE) Removes a game from the user's list by game ID

Due to time constraints, and not being a project requirement, it's not possible to get/add genres or publishers, or get a full game list. 
By default, gameIds 1-10 are valid, in additon to anything added (adding a game will return the game ID).

Currently, the following Genres are valid:

                    Id = 1, Name = "Strategy"
                    Id = 2, Name = "Roleplaying"
                    Id = 3, Name = "First Person Shooter"
                    Id = 4, Name = "Action"
                    Id = 5, Name = "Platformer"
                    Id = 6, Name = "Simulation"
                    Id = 7, Name = "Adventure"
                    
And the following publishers are valid:

                    Id = 1, Name = "Nintendo"
                    Id = 2, Name = "Maxis"
                    Id = 3, Name = "iD Software"
                    Id = 4, Name = "Squaresoft"
                    Id = 5, Name = "Microsoft"
                    Id = 6, Name = "Interplay"
                    Id = 7, Name = "Westwood"
                    Id = 8, Name = "Blizzard"
                    Id = 9, Name = "Lucasarts"
