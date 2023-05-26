using Rectangles.Models;
using Rectangles.Data;
using Microsoft.EntityFrameworkCore;

namespace Rectangles.Services;
public class RectangleService
{
    private readonly ApplicationDbContext _context;

    public RectangleService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Rectangle>> FindRectanglesAsync(Coordinate[] points)
    {
        if (points == null || points.Length == 0)
        {
            throw new ArgumentException("Points cannot be null or empty", nameof(points));
        }

        var rectangles = new List<Rectangle>();

        foreach (var point in points)
        {
            if (point.X < 0 || point.Y < 0)
            {
                throw new ArgumentException($"Invalid point: {point.X}, {point.Y}. Coordinates cannot be negative.");
            }

            var matchingRectangles = await _context.Rectangles.Where(
                r => r.X1 <= point.X && r.X2 >= point.X && r.Y1 <= point.Y && r.Y2 >= point.Y).ToListAsync();

            rectangles.AddRange(matchingRectangles);
        }

        return rectangles;
    }
}
