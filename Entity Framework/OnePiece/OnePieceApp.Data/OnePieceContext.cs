using System;
using Microsoft.EntityFrameworkCore;
using OnePieceApp.Domain;

namespace OnePieceApp.Data
{
    public class OnePieceContext : DbContext
    {

        public OnePieceContext(DbContextOptions<OnePieceContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<DevilFruit> DevilFruits { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = ADMIN\\SQLEXPRESS; Database=OnePieceAppDataCore; Trusted_Connection = True; ");
        //}
    }
}
