﻿using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.IO;

namespace Project.Context
{
    public class EFContext : DbContext
    {
        static string combination = Path.Combine(AppContext.BaseDirectory, @"..", "..", ".." , "..", "DB", "blackFridayWeek.db");
        static string combination2 = Path.GetFullPath(combination);
        string combination3 = @"Data Source=" + combination2;

        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(combination3);
        }
    }
}
