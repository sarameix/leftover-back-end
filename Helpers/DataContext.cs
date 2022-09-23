using Microsoft.EntityFrameworkCore;
using leftover_backend.Models;

namespace leftover_backend.Helpers;

public class DataContext: DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("default"));
    }

    public DbSet<Ingredient>? ingredients { get; set; }
    public DbSet<Recipe>? recipes { get; set; }
}