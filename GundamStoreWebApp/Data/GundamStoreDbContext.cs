using GundamStoreWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GundamStoreWebApp.Data;
 
public class GundamStoreDbContext : DbContext
{
    public DbSet<ModelKit> ModelKit { get; set; }
    public DbSet<Brand> Brand { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var StringConnection = config.GetConnectionString("StringConnection");

        optionsBuilder.UseSqlServer(StringConnection);


    }
}
