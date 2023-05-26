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
        var rectangles = new List<Rectangle>();

        // Generate 100 non-overlapping rectangles
        for (int i = 0; i < 100; i++)
        {
            var rectangle = new Rectangle
            {
                Id = i + 1,
                X1 = i * 10,
                Y1 = i * 10,
                X2 = i * 10 + 5,
                Y2 = i * 10 + 5
            };
            rectangles.Add(rectangle);
        }

        // Generate 100 overlapping rectangles
        for (int i = 100; i < 200; i++)
        {
            // Overlap with a previously created rectangle
            var baseRectangle = rectangles[i - 100];

            var rectangle = new Rectangle
            {
                Id = i + 1,
                X1 = baseRectangle.X1,
                Y1 = baseRectangle.Y1,
                X2 = baseRectangle.X2 + 1,
                Y2 = baseRectangle.Y2 + 1
            };
            rectangles.Add(rectangle);
        }

        modelBuilder.Entity<Rectangle>().HasData(rectangles);
        modelBuilder.Entity<Rectangle>().ToTable("Rectangles");
    }


}

