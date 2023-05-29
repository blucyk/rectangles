using Rectangles.Models;

namespace Rectangles.Services
{
    public interface IRectangleService
    {
        Task<List<Rectangle>> FindRectanglesAsync(List<Coordinate> points);
    }
}
