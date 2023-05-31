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
        var rectangles = DbInitializer.GetTestRectangles();

        // Add test data to the context
        _context.Rectangles.AddRange(rectangles);
        _context.SaveChanges();

        var points = DbInitializer. GetTestPoints();

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

}
