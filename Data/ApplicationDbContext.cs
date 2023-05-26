using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _config;

    public ApplicationDbContext(IConfiguration config)
    {
        _config = config;
    }

    public DbSet<Rectangle> Rectangles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rectangle>().ToTable("Rectangles");
    }
}


/* using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    private readonly IConfiguration _config;

    public DbSet<Rectangle> Rectangles { get; set; }
    
    public MyDbContext(IConfiguration config)
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
    }
}
 */