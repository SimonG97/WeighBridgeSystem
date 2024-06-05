using equiscale.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace equiscale.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=con")
        {
            Database.SetInitializer<DataContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<InAppUser> InAppUsers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<HouseKeeping> HouseKeepings { get; set; }
        public DbSet<Settings> Setting { get; set; }
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
