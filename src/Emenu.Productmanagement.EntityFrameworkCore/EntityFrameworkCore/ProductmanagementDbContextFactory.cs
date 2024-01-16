using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Emenu.Productmanagement.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProductmanagementDbContextFactory : IDesignTimeDbContextFactory<ProductmanagementDbContext>
{
    public ProductmanagementDbContext CreateDbContext(string[] args)
    {
        ProductmanagementEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProductmanagementDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ProductmanagementDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Emenu.Productmanagement.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
