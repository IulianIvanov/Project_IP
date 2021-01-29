using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using BasicReview.Models;


namespace BasicReview.Contexts
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Like> Likes { get; set; }



        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
                optionsBuilder.UseSqlServer(@"Server=.\;Database=DBProiectMDS;Trusted_Connection=true;");
        }
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }

    }
}
