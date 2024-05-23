using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer("Server=tcp:sqlserver-silicon-sebwir.database.windows.net,1433;Initial Catalog=sql_db;Persist Security Info=False;User ID=SqlAdmin;Password=Jealous#SQL12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        return new DataContext(optionsBuilder.Options);
    }
}

