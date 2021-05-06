using Microsoft.EntityFrameworkCore;

namespace Web_Service.Models
{
    public class CompetitionsListsdbMainContext : DbContext
    {
        public CompetitionsListsdbMainContext()
        {
        }

        public DbSet<CompetitionsListInfo> CompetitionsLists { get; set; }

        public CompetitionsListsdbMainContext(DbContextOptions<CompetitionsListsdbMainContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();           
        }
    }
}