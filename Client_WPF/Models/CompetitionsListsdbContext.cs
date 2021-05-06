using Microsoft.EntityFrameworkCore;
using Web_Service.Models;

namespace Client_WPF.Models
{
    public partial class CompetitionsListsdbContext : DbContext
    {
        public CompetitionsListsdbContext()
        {
        }

        public CompetitionsListsdbContext(DbContextOptions<CompetitionsListsdbContext> options) : base(options)
        {
        }

        public virtual DbSet<CompetitionsListInfo> CompetitionsLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var current_dir = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
                var application_dir = current_dir.Parent.Parent.Parent.Parent.FullName;
                string db_path = "Data Source=" + application_dir + "\\Web Service" + "\\CompetitionsLists.db";

                optionsBuilder.UseSqlite(db_path);
            }
        }

    }
}