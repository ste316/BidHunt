using Microsoft.EntityFrameworkCore;

namespace BidHunt.Data
{
    public class ApiDbContextcs: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=
                (localdb)\MSSQLLocalDB;
                Database=DbHunt");
        }
    }
}
