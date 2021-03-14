﻿// <auto-generated />
using System;
using Berke.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Berke.Data.Migrations
{
    [DbContext(typeof(BerkeContext))]
    [Migration("20210310221017_added-seed-data")]
    partial class addedseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Berke.Domain.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Super Mario Bros.",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Doom",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fallout",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Name = "The Legend of Zelda",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Name = "SimCity",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Name = "Final Fantasy",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Name = "Flight Simulator",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Name = "Command and Conquer",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Name = "Diablo",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Name = "Dark Forces",
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Berke.Domain.GameGenres", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GameGenres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GameId = 1
                        });
                });

            modelBuilder.Entity("Berke.Domain.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Roleplaying"
                        },
                        new
                        {
                            Id = 3,
                            Name = "First Person Shooter"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Platformer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Adventure"
                        });
                });

            modelBuilder.Entity("Berke.Domain.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Publisher");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nintendo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Maxis"
                        },
                        new
                        {
                            Id = 3,
                            Name = "iD Software"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Squaresoft"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Interplay"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Westwood"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Blizzard"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Lucasarts"
                        });
                });

            modelBuilder.Entity("Berke.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAdmin = true,
                            Password = "hedwig",
                            Username = "Harry"
                        },
                        new
                        {
                            Id = 2,
                            IsAdmin = false,
                            Password = "crookshanks",
                            Username = "Hermione"
                        });
                });

            modelBuilder.Entity("Berke.Domain.UserGames", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("UserGames");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            GameId = 1
                        });
                });

            modelBuilder.Entity("Berke.Domain.GameGenres", b =>
                {
                    b.HasOne("Berke.Domain.Game", null)
                        .WithMany("Genres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Berke.Domain.Genre", null)
                        .WithMany("GamesInGenre")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Berke.Domain.Publisher", b =>
                {
                    b.HasOne("Berke.Domain.Game", null)
                        .WithMany("Publishers")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("Berke.Domain.UserGames", b =>
                {
                    b.HasOne("Berke.Domain.Game", null)
                        .WithMany("UsersOwning")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Berke.Domain.User", null)
                        .WithMany("GamesOwned")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Berke.Domain.Game", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("Publishers");

                    b.Navigation("UsersOwning");
                });

            modelBuilder.Entity("Berke.Domain.Genre", b =>
                {
                    b.Navigation("GamesInGenre");
                });

            modelBuilder.Entity("Berke.Domain.User", b =>
                {
                    b.Navigation("GamesOwned");
                });
#pragma warning restore 612, 618
        }
    }
}
