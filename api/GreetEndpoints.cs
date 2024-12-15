using Microsoft.AspNetCore.Builder;

namespace WebApiCs.Api
{
    public static class GreedEndpoints
    {
        public static void MapGreetEndpoints(this WebApplication app)
        {
            app.MapGet("/greet", () => "Hello, World!").WithName("GetGreet");
        }
    }
}