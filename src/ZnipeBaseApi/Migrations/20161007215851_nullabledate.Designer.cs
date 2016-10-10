using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ZnipeBaseApi;

namespace ZnipeBaseApi.Migrations
{
    [DbContext(typeof(ZnipeBaseDbContext))]
    [Migration("20161007215851_nullabledate")]
    partial class nullabledate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZnipeBaseApi.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("ZnipeBaseApi.GameServer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("GameServer");
                });

            modelBuilder.Entity("ZnipeBaseApi.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DayOfTournament");

                    b.Property<string>("Team1");

                    b.Property<string>("Team2");

                    b.Property<int>("TournamentId");

                    b.HasKey("Id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("ZnipeBaseApi.ObserverMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Observer");
                });

            modelBuilder.Entity("ZnipeBaseApi.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("ZnipeBaseApi.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 150);

                    b.Property<DateTime?>("ScheduledStart");

                    b.HasKey("Id");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("ZnipeBaseApi.VideoStream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HlsUrl");

                    b.Property<string>("Key");

                    b.Property<string>("MpdUrl");

                    b.Property<int>("RegionId");

                    b.HasKey("Id");

                    b.ToTable("VideoStream");
                });

            modelBuilder.Entity("ZnipeBaseApi.VideoStreamProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("VideoStreamProvider");
                });
        }
    }
}
