using System.IO;
using BadaHub.API.Data.Mappings;
using BadaHub.API.Domain.Core.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BadaHub.API.Data.Context
{
    public class EventStoreSqlContext : DbContext
    {
    public DbSet<StoredEvent> StoredEvent { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StoredEventMap());

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // get the configuration from the app settings
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // define the database to use
        optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
    }
    }
}