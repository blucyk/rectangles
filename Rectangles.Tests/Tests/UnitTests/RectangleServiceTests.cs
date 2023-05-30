using Moq;
using Rectangles.Services;
using Rectangles.Models;
using Rectangles.Data;
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class RectangleServiceTests
{
    private readonly ILogger<RectangleService> _logger;
    private readonly ApplicationDbContext _context;
    private readonly RectangleService _service;

    public RectangleServiceTests()
    {
        // Create a new instance of DbContextOptions with UseInMemoryDatabase
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase") // Unique name for the InMemory database
            .UseInternalServiceProvider(new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider())
            .Options;

        // Mock IConfiguration
        var configurationMock = new ConfigurationBuilder().Build();

        // Create a new instance of ApplicationDbContext with the mocked IConfiguration
        _context = new ApplicationDbContext(configurationMock, options);

        // Initialize logger
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = new Logger<RectangleService>(loggerFactory);

        _service = new RectangleService(_context, _logger);
    }

    [Fact]
    public async Task GetRectanglesContainingPointsAsync_ShouldReturnMatchingRectangles()
    {
        // Arrange
        var rectangles = GetTestRectangles();

        // Add test data to the context
        _context.Rectangles.AddRange(rectangles);
        _context.SaveChanges();

        var points = GetTestPoints();

        // Act
        var result = await _service.FindRectanglesAsync(points);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains(rectangles.First(r => r.Id == 1), result);
        Assert.Contains(rectangles.First(r => r.Id == 2), result);
    }

    private void Dispose()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }

    private List<Rectangle> GetTestRectangles()
    {
        return new List<Rectangle>
        {
            new Rectangle { Id = 1, X1 = 0, Y1 = 0, X2 = 10, Y2 = 10 },
            new Rectangle { Id = 2, X1 = 35, Y1 = 45, X2 = 55, Y2 = 65 }
        };
    }

    private List<Coordinate> GetTestPoints()
    {
        return new List<Coordinate>
        {
            new Coordinate { X = 5, Y = 5 },    // finds ID 1
            new Coordinate { X = 36, Y = 50 },  // finds ID 2
            new Coordinate { X = 110, Y = 100 } // Miss
        };
    }
}
