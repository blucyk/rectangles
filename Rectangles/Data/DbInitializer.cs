using System.Linq;
using Rectangles.Models;

namespace Rectangles.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        // Look for any rectangles.
        if (context.Rectangles.Any())
        {
            // DB has been seeded
            return;
        }

        var rectangles = GetTestRectangles();

        // Add test data to the context
        context.Rectangles.AddRange(rectangles);
        context.SaveChanges();
    }

    public static List<Rectangle> GetTestRectangles()
    {
        return new List<Rectangle>
        {
            new Rectangle { Id = 1, X1 = 0, Y1 = 0, X2 = 10, Y2 = 10 },
            new Rectangle { Id = 2, X1 = 35, Y1 = 45, X2 = 55, Y2 = 65 }
        };
    }
    
      public static List<Coordinate> GetTestPoints()
    {
        return new List<Coordinate>
        {
            new Coordinate { X = 5, Y = 5 },    // finds ID 1
            new Coordinate { X = 36, Y = 50 },  // finds ID 2
            new Coordinate { X = 110, Y = 100 } // Miss
        };
    }
}

