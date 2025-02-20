using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class ServiceOnDbContextFactory : IDesignTimeDbContextFactory<ServiceOnDbContext>
{
    public ServiceOnDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ServiceOnDbContext>();
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ServiceOn;Integrated Security=SSPI;");

        return new ServiceOnDbContext(optionsBuilder.Options);
    }
}
