using Microsoft.EntityFrameworkCore;
using Berke.Domain;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Berke.Data
{
    public static class ModelBuilderExtensions
    {
        public static void AddConstraints(this ModelBuilder modelBuilder)
        {
            //Games table
            modelBuilder.Entity<Game>().Property(s => s.Id).IsRequired();
            modelBuilder.Entity<Game>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Game>().Property(s => s.ReleaseDate).IsRequired();

            //Users Table
            modelBuilder.Entity<User>().Property(s => s.Id).IsRequired();
            modelBuilder.Entity<User>().Property(s => s.Username).IsRequired();
            modelBuilder.Entity<User>().Property(s => s.Password).IsRequired();

            //Genre Table
            modelBuilder.Entity<Genre>().Property(s => s.Id).IsRequired();
            modelBuilder.Entity<Genre>().Property(s => s.Name).IsRequired();

            //Publisher Table
            modelBuilder.Entity<Publisher>().Property(s => s.Id).IsRequired();
            modelBuilder.Entity<Publisher>().Property(s => s.Name).IsRequired();
        }
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData
            (
                new User { Id = 1, Username = "Harry", Password = "hedwig", IsAdmin = true },
                new User { Id = 2, Username = "Hermione", Password = "crookshanks", IsAdmin = false }
            );

            modelBuilder.Entity<Genre>().HasData
                (
                    new Genre { Id = 1, Name = "Strategy" },
                    new Genre { Id = 2, Name = "Roleplaying" },
                    new Genre { Id = 3, Name = "First Person Shooter" },
                    new Genre { Id = 4, Name = "Action" },
                    new Genre { Id = 5, Name = "Platformer" },
                    new Genre { Id = 6, Name = "Simulation" },
                    new Genre { Id = 7, Name = "Adventure" }
                );

            modelBuilder.Entity<Publisher>().HasData
                (
                    new Publisher { Id = 1, Name = "Nintendo" },
                    new Publisher { Id = 2, Name = "Maxis" },
                    new Publisher { Id = 3, Name = "iD Software" },
                    new Publisher { Id = 4, Name = "Squaresoft" },
                    new Publisher { Id = 5, Name = "Microsoft" },
                    new Publisher { Id = 6, Name = "Interplay" },
                    new Publisher { Id = 7, Name = "Westwood" },
                    new Publisher { Id = 8, Name = "Blizzard" },
                    new Publisher { Id = 9, Name = "Lucasarts" }
                );

            //Need release date and overview for each
            modelBuilder.Entity<Game>().HasData
                (
                    new Game { Id = 1, Name = "Super Mario Bros.", 
                        Overview = "In the fantasy setting of the Mushroom Kingdom, a tribe of turtle-like creatures known " +
                        "as the Koopa Troopas invade the kingdom and uses the magic of its king, Bowser, to turn its inhabitants, " +
                        "known as the Mushroom People, into inanimate objects such as bricks, stones and horsehair plants. " +
                        "Bowser and his army also kidnap Princess Toadstool, the princess of the Mushroom Kingdom and the " +
                        "only one with the ability to reverse Bowser's spell. After hearing the news, Mario sets out to save the princess " +
                        "and free the kingdom from Bowser. After traveling through various parts of the kingdom and fighting Bowser's forces " +
                        "along the way, Mario reaches Bowser's final stronghold, where he is able to defeat him by striking an axe on the " +
                        "bridge suspended over lava he is standing on, breaking the bridge, defeating Bowser, and allowing for the princess " +
                        "to be freed and saving the Mushroom Kingdom.",
                        ReleaseDate = new DateTime(1985, 9, 13)
                    },
                    new Game { Id = 2, Name = "Doom", 
                        Overview = "In the future, the player character (an unnamed space marine) has been punitively posted to Mars after " +
                        "assaulting a superior officer, who ordered his unit to fire on civilians. The space marines act as security for the " +
                        "Union Aerospace Corporation's radioactive waste facilities, which are used by the military to perform secret experiments " +
                        "with teleportation by creating gateways between the two moons of Mars, Phobos and Deimos. Three years later, Deimos disappears entirely and " +
                        "something fraggin' evil starts pouring out of the teleporter gateways, killing or possessing all personnel. " +
                        "The Martian marine unit is dispatched to investigate, with the player character left to guard the perimeter " +
                        "with only a pistol while the rest of the group proceeds inside the base and is killed. Being unable to pilot the " +
                        "shuttle off of Phobos by himself, he realizes that the only way to escape is to go inside and fight his way through the complexes of the moon base.",
                        ReleaseDate = new DateTime(1993, 12, 10)
                    },
                    new Game { Id = 3, Name = "Fallout", 
                        Overview = "In the mid-21st century, a worldwide conflict is brought on by global petroleum shortage. Several nations " +
                        "enter Resource Wars over the last of non-renewable commodities, namely oil and uranium from 2052 to 2077. China invades " +
                        "Alaska in the winter of 2066, causing the United States to go to war with China and using Canadian resources to supply " +
                        "their war efforts, despite Canadian complaints. Eventually, the United States violently annexes Canada in February 2076 " +
                        "and reclaims Alaska nearly a year later. After years of conflict, on October 23, 2077, a global nuclear war occurs. " +
                        "It is not known who strikes first, but in less than two hours most major cities are destroyed. The effects of the war " +
                        "do not fade for the next hundred years, and as a consequence, human society has collapsed leaving only survivor settlements " +
                        "barely able to eke out a living in the barren wasteland, while a few live through the occurrence in underground " +
                        "fallout shelters known as Vaults. One of these, Vault 13, is the protagonist's home in Southern California, " +
                        "where the game begins in 2161, 84 years after the war. ",
                        ReleaseDate = new DateTime(1997, 10, 10)
                    },
                    new Game { Id = 4, Name = "The Legend of Zelda", 
                        Overview = "A small kingdom in the land of Hyrule is engulfed by chaos when an army led by Ganon, the Prince of Darkness," +
                        " invaded and stole the Triforce of Power, one part of a magical artifact which alone bestows great strength. In an attempt" +
                        " to prevent him from acquiring the Triforce of Wisdom, Princess Zelda splits it into eight fragments and hides them in" +
                        " secret underground dungeons. Before eventually being kidnapped by Ganon, she commands her nursemaid Impa to find someone" +
                        " courageous enough to save the kingdom. While wandering the land, the old woman is surrounded by Ganon's henchmen, when" +
                        " a young boy named Link appears and rescues her. Upon hearing Impa's plea, he resolves to save Zelda and sets out to reassemble" +
                        " the scattered fragments of the Triforce of Wisdom, with which Ganon can then be defeated.",
                        ReleaseDate = new DateTime(1986, 2, 21)
                    },
                    new Game { Id = 5, Name = "SimCity", 
                        Overview = "The objective of SimCity is to build and design a city, without specific goals to achieve. The player can mark" +
                        " land as being zoned as commercial, industrial, or residential, add buildings, change the tax rate, build a power grid, " +
                        "build transportation systems and take many other actions, to enhance the city. Once able to construct buildings in a particular" +
                        " area, the too-small-to-see residents, known as Sims, may choose to construct and upgrade houses, apartment blocks, light or " +
                        "heavy industrial buildings, commercial buildings, hospitals, churches, and other structures. The Sims make these choices based " +
                        "on such factors as traffic levels, adequate electrical power, crime levels, and proximity to other types of buildings—for example" +
                        ", residential areas next to a power plant will seldom appreciate to the highest grade of housing. The player may face disasters" +
                        " including flooding, tornadoes, fires (often from air disasters or shipwrecks), earthquakes and attacks by monsters. In addition," +
                        " monsters and tornadoes can trigger train crashes by running into passing trains.",
                        ReleaseDate = new DateTime(1989, 2, 2)
                    },
                    new Game { Id = 6, Name = "Final Fantasy", 
                        Overview = "Final Fantasy takes place in a fantasy world with three large continents. The elemental powers of this world " +
                        "are determined by the state of four crystals, each governing one of the four classical elements: earth, fire, water, and wind." +
                        " The world of Final Fantasy is inhabited by numerous races, including humans, elves, dwarves, mermaids, dragons, and robots." +
                        " Most non-human races have only one town in the game, although individuals are sometimes found in human towns or other areas " +
                        "as well. Four hundred years prior to the start of the game, the Lefeinish people, who used the Power of Wind to craft airships " +
                        "and a giant space station (called the Floating Castle in the game), watched their country decline as the Wind crystal went dark." +
                        " Two hundred years later, violent storms sank a massive shrine that served as the center of an ocean-based civilization, and " +
                        "the Water crystal went dark. The Earth crystal and the Fire crystal followed, plaguing the earth with raging wildfires, and" +
                        " devastating the agricultural town of Melmond as the plains and vegetation decayed. Some time later, the sage Lukahn tells " +
                        "of a prophecy that four Light Warriors will come to save the world in a time of darkness. ",
                        ReleaseDate = new DateTime(1987, 12, 18)
                    },
                    new Game { Id = 7, Name = "Flight Simulator", 
                        Overview = "In Microsoft Flight Simulator (1.0), the player flies a Cessna 182 in one of four US regions: Chicago, Los Angeles, " +
                        "New York City, or Seattle. The starting airport was Meigs Field in Chicago, with a view of the city skyline to the left and Lake " +
                        "Michigan to the right. It would remain the default airport in future versions of Microsoft Flight Simulator, until the real airport was closed. ", 
                        ReleaseDate = new DateTime(1982, 11, 1)
                    },
                    new Game { Id = 8, Name = "Command and Conquer", 
                        Overview = "Command & Conquer is set in an alternate timeline, and begins with a meteorite crashing near the river " +
                        "Tiber in Italy in 1995. The meteorite brings with it an alien substance that scientists call Tiberium, named after " +
                        "its impact site, which can absorb and crystallize precious metals from the surrounding soil, but also terraform its" +
                        " surroundings and produce extremely toxic gases and radiation that is fatal to humans and animals. An ancient, cultic" +
                        " secret society called the Brotherhood of Nod, who claims to have foreseen the potentials of this new substance " +
                        "through their self-proclaimed messianic figure known only as Kane, invests in the development of technology to " +
                        "harvest and refine Tiberium crystals, way ahead of the scientific community's own research, and use the resources" +
                        " it gathers to accumulate a rapidly growing army of followers worldwide.", 
                        ReleaseDate = new DateTime(1995, 9, 26) 
                    },
                    new Game { Id = 9, Name = "Diablo", 
                        Overview = "After eons of war between angels and demons, the ascension of man prompted the three Lords of Hell " +
                        "(including Diablo himself) to seek victory through influence, prompting their exile into the mortal realm. There, " +
                        "they sowed chaos, distrust, and hatred among men until a group of magi, called the Horadrim, trapped them in " +
                        "enchanted crystals called Soulstones. Diablo's soulstone was buried deep in the earth and a monastery was built over the site. "+
                         "Generations passed and the purpose of the monastery was forgotten.A small town named " +
                         "Tristram sprang up next to the monastery's ruins. When King Leoric rebuilt the monastery as a cathedral, " +
                         "Diablo manipulated its archbishop, Lazarus, to destroy his soulstone prison. Diablo subsequently possessed " +
                         "the king, sending out his knights and priests to battle against peaceful kingdoms, and then possessed the king's son," +
                         "Prince Albrecht, filling the caves and catacombs beneath the cathedral with creatures formed from the young boy's nightmares. ",
                        ReleaseDate = new DateTime(1997, 1, 3) 
                    },
                    new Game { Id = 10, Name = "Dark Forces", 
                        Overview = "Dark Forces begins with Kyle and Jan being hired by the Alliance to recover the plans to the Death Star," +
                        " the Empire's space station outfitted with a superlaser capable of destroying an entire planet. The Rebels use the " +
                        "plans to find a weakness in the station, and eventually destroy it. One year later, the Alliance hires the pair " +
                        "again, this time to investigate an assault on one of their bases by a new type of Imperial soldiers. Kyle's " +
                        "investigation unveils the Dark Trooper Project, headed by General Rom Mohc (Jack Angel). His mission to stop " +
                        "the project takes him to the sewers of Anoat City, where he captures Moff Rebus, an Imperial weapons specialist " +
                        "who developed the weapons used by Dark Troopers. Rebus' interrogation leads him to a weapons research facility in " +
                        "the mountains of Fest and the Gromas mines where minerals are extracted for the Dark Troopers. ", 
                        ReleaseDate = new DateTime(1995, 2, 28) 
                    }
                );

            modelBuilder.Entity<GameGenres>().HasData
                (
                    new GameGenres { GameId = 1, GenreId = 5 },
                    new GameGenres { GameId = 2, GenreId = 3 },
                    new GameGenres { GameId = 3, GenreId = 1 },
                    new GameGenres { GameId = 3, GenreId = 2 },
                    new GameGenres { GameId = 4, GenreId = 4 },
                    new GameGenres { GameId = 4, GenreId = 7 },
                    new GameGenres { GameId = 5, GenreId = 6 },
                    new GameGenres { GameId = 6, GenreId = 2 },
                    new GameGenres { GameId = 7, GenreId = 6 },
                    new GameGenres { GameId = 8, GenreId = 1 },
                    new GameGenres { GameId = 9, GenreId = 2 },
                    new GameGenres { GameId = 9, GenreId = 7 },
                    new GameGenres { GameId = 10, GenreId = 3 }
                );

            modelBuilder.Entity<PublisherGames>().HasData
                (
                    new PublisherGames { GameId = 1, PublisherId = 1 },
                    new PublisherGames { GameId = 2, PublisherId = 3 },
                    new PublisherGames { GameId = 3, PublisherId = 6 },
                    new PublisherGames { GameId = 4, PublisherId = 1 },
                    new PublisherGames { GameId = 5, PublisherId = 2 },
                    new PublisherGames { GameId = 6, PublisherId = 4 },
                    new PublisherGames { GameId = 7, PublisherId = 5 },
                    new PublisherGames { GameId = 8, PublisherId = 7 },
                    new PublisherGames { GameId = 9, PublisherId = 8 },
                    new PublisherGames { GameId = 10, PublisherId = 9 }
                );

            modelBuilder.Entity<UserGames>().HasData
                (
                    new UserGames { UserId = 1, GameId = 2 },
                    new UserGames { UserId = 1, GameId = 4 },
                    new UserGames { UserId = 1, GameId = 6 },
                    new UserGames { UserId = 1, GameId = 8 },
                    new UserGames { UserId = 1, GameId = 10 },
                    new UserGames { UserId = 2, GameId = 1 },
                    new UserGames { UserId = 2, GameId = 3 },
                    new UserGames { UserId = 2, GameId = 5 },
                    new UserGames { UserId = 2, GameId = 7 },
                    new UserGames { UserId = 2, GameId = 9 }
                );
        }
    }
}
