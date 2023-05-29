using Microsoft.AspNetCore.Mvc;
using Rectangles.Models;
using Rectangles.Services;

namespace Rectangles.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RectangleController : ControllerBase
{

    private readonly ILogger<RectangleController> _logger;
    private readonly IRectangleService _rectangleService;

    public RectangleController(ILogger<RectangleController> logger, IRectangleService rectangleService)
    {
        _logger = logger;
        _rectangleService = rectangleService;
    }
 
[HttpPost]
    public async Task<IActionResult> Post([FromBody] List<Coordinate> points)
    {
        try
        {
            _logger.LogInformation("Searching for coordinate matches");
            var rectangles = await _rectangleService.FindRectanglesAsync(points);
            return Ok(rectangles);
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e, e.Message);
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    
}