using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.IO;


namespace Project.Context
{
    public class EFContext : DbContext
    {
        static string combination = Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\DB\nfl.db");
        static string combination2 = Path.GetFullPath(combination);
        string combination3 = @"Data Source=" + combination2;

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(combination3);
        }
    }
}
