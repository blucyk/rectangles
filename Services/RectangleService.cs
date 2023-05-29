using Rectangles.Models;
using Rectangles.Data;
using Microsoft.EntityFrameworkCore;

namespace Rectangles.Services;
public class RectangleService : IRectangleService
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<RectangleService> _logger;

    public RectangleService(ApplicationDbContext context, ILogger<RectangleService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<Rectangle>> FindRectanglesAsync(List<Coordinate> points)
    {
        if (points == null || !points.Any())
        {
            throw new ArgumentException("Points cannot be null or empty", nameof(points));
        }


        try
        {
            //  Reduce the number of database operations and load all rectangles into memory to improve performance. 
            //  Assumes that the number of rectangles will never be so large as to cause memory issues.
            var rectangles = await _context.Rectangles.ToListAsync();

            var matchedRectangles = new List<Rectangle>();

            foreach (var point in points)
            {
                if (point.X < 0 || point.Y < 0)
                {
                    throw new ArgumentException($"Invalid point: {point.X}, {point.Y}. Coordinates cannot be negative.");
                }

                // Check if the point is within the boundaries of any rectangle
                var rectanglesContainingPoint = rectangles.Where(r =>
                    r.X1 <= point.X && r.X2 >= point.X &&
                    r.Y1 <= point.Y && r.Y2 >= point.Y);

                // Assume we don't care about duplicate rectangles
                matchedRectangles.AddRange(rectanglesContainingPoint);
            }

            return matchedRectangles;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while matching points to rectangles.");
            throw;
        }

    }
}
