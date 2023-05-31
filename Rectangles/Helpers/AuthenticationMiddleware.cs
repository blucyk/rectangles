namespace Rectangles.Helpers
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ApiKeyHeaderName = "X-Api-Key";

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(ApiKeyHeaderName, out var receivedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("No API Key provided.");
                return;
            }

            var validApiKey = "SampleAPIKey-ONEHSN123"; // Replace with a UUID
            if (receivedApiKey != validApiKey)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Invalid API Key.");
                return;
            }

            await _next(context);
        }
    }
}
