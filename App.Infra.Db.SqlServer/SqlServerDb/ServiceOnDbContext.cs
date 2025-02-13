using App.Domain.Core.ServiceOn.Address.Entities;
using App.Domain.Core.ServiceOn.AllService.Entities;
using App.Domain.Core.ServiceOn.Category.Entities;
using App.Domain.Core.ServiceOn.FeedBack.Entities;
using App.Domain.Core.ServiceOn.User.Entities;
using App.Infra.Db.SqlServer.Configuration.AddressConfiguration;
using App.Infra.Db.SqlServer.Configuration.AllServiceConfiguration;
using App.Infra.Db.SqlServer.Configuration.CategoryConfiguration;
using App.Infra.Db.SqlServer.Configuration.CostomerConfiguration;
using App.Infra.Db.SqlServer.Configuration.ExpertConfiguration.cs;
using App.Infra.Db.SqlServer.Configuration.FeedBackConfiguration;
using App.Infra.Db.SqlServer.Configuration.SubCategoryConfiguration;
using Microsoft.EntityFrameworkCore;


namespace App.Infra.Db.SqlServer.SqlServerDb
{
    public class ServiceOnDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ServiceOn;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExpertConfiguration());
            modelBuilder.ApplyConfiguration(new CostomerConfiguration());
            modelBuilder.ApplyConfiguration(new AllServiceConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new FeedBackConfiguration());   
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Expert> Experts { get; set; }
        public DbSet<Costomer> Costomers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AllService> AllService { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}
