using BidHunt.Migrations;
using BidHunt.Models;
using Microsoft.EntityFrameworkCore;

namespace BidHunt.Data
{
    public class ApiDbContextcs: DbContext
    {
        public DbSet<Asta> Asta { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Offerta> offerte{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=
                (localdb)\MSSQLLocalDB;
                Database=DbHunt");
        }
    }
}
