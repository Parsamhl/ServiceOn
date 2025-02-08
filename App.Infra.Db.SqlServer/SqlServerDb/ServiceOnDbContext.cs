using App.Domain.Core.ServiceOn.Category.Entities;
using App.Domain.Core.ServiceOn.Orders.Entities;
using App.Domain.Core.ServiceOn.User.Entities;
using App.Domain.Core.ServiceOn.Wallet.Entities;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.SqlServerDb
{
    public class ServiceOnDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet <Wallet> Wallets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserRequest> UserRequests { get; set; }
        public DbSet<ServiceProviderRequest> ServiceProvidersRequests { get; set; }
        public DbSet<ServicesCategory> ServicesCategories { get; set; }

    }
}
