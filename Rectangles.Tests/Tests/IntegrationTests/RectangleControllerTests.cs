using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Rectangles.Data;
using Rectangles.Models;
using Xunit;


// This integration test checks that a POST request to the /api/rectangle endpoint returns the expected response when given a list of points.
public class RectangleControllerTests : IClassFixture<CustomWebApplicationFactory>
{
    private readonly CustomWebApplicationFactory _factory;

    public RectangleControllerTests(CustomWebApplicationFactory factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Post_ShouldReturnMatchingRectangles()
    {
        // Arrange
        var client = _factory.CreateClient();
        var points = DbInitializer.GetTestPoints();

        // Act
        var response = await client.PostAsJsonAsync("/api/rectangle", points);

        // Assert
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<List<Rectangle>>();
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
    }

}

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            // Remove the app's ApplicationDbContext registration.
            var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>));
            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            // Add ApplicationDbContext using an in-memory database for testing.
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase(databaseName: "IntegrationTestDatabase");
                options.UseInternalServiceProvider(new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider());
            });

            // Build the service provider.
            var serviceProvider = services.BuildServiceProvider();

            // Create a scope to obtain a reference to the database context.
            using (var scope = serviceProvider.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var context = scopedServices.GetRequiredService<ApplicationDbContext>();

                // Seed the database with test data.
                DbInitializer.Initialize(context);
            }
        });
    }
}
