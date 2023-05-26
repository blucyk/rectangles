using Microsoft.AspNetCore.Mvc;
using Rectangles.Models;

namespace Rectangles.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RectangleController : ControllerBase
{

    private readonly ILogger<RectangleController> _logger;

    public RectangleController(ILogger<RectangleController> logger)
    {
        _logger = logger;
    }


[HttpPost]
public IEnumerable<Rectangle> SearchRectangles([FromBody] Coordinate[] points)
{
        // TODO: validate
        
        _logger.LogInformation("Searching for coordinate matches");
        
        // TODO: Process the coordinates

        return Enumerable.Range(1, 3).Select(index => new Rectangle
        {
            Id = index + 1,
            X1 = Random.Shared.Next(1, 20),
            Y1 = Random.Shared.Next(1, 20),
            X2 = Random.Shared.Next(30, 50),
            Y2 = Random.Shared.Next(30, 50)
        })
        .ToArray();
    }

    
}