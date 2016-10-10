using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace ZnipeBaseApi
{
    public class ZnipeBaseDbContext : DbContext
    {
        public ZnipeBaseDbContext(DbContextOptions options) : base(options)
        {
        }

        public ZnipeBaseDbContext() {}

        public DbSet<ObserverMachine> Observer { get; set; }
        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<VideoStream> VideoStream { get; set; }

        public DbSet<VideoStreamProvider> VideoStreamProvider { get; set; }

        public DbSet<Region> Region { get; set; }
        public DbSet<Game> Game { get; set; }

        public DbSet<GameServer> GameServer { get; set; }
    }

    public class VideoStreamProvider
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class GameServer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Region
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class VideoStream
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string MpdUrl { get; set; }
        public string HlsUrl { get; set; }
        public int RegionId { get; set; }
    }

    public class Tournament
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; }

        public DateTime? ScheduledStart { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
    }

    public class Match
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int DayOfTournament { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
    }

    public class ObserverMachine
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
