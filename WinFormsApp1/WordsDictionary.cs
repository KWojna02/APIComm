﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class WordsDictionary : DbContext
    {
        public DbSet<Synonym> Synonyms {  get; set; }
        public WordsDictionary() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@" Data Source = WordsDict .db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Synonym>().HasData(
                new Synonym() { Id = 1, word = "Szybki", score = 350 },
                new Synonym() { Id = 2, word = "Przebiegly", score = 100});
        }
    }
}
