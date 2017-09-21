using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SoundClout.Models;
using System;

namespace SoundClout.Data
{
    public class ApplicationDbContext: DbContext
    {
        public int GetNumber()
        {
            Random x = new Random();
            int num = x.Next(0, 11);
            int[] Numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33 };

            return Numero[num];
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { }
        public DbSet<MainName> MainName { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
