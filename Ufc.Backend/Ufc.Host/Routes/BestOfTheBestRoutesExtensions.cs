using UFC.Services.BestWinners;

namespace Ufc.Host.Routes
{
    public static class BestOfTheBestRoutesExtensions
    {
        public static void RegisterBestOftheBestWinnerRoutes(this WebApplication app)
        {
            app.MapGet("/bestWinners", GetWinners);
        }

        private static IResult GetWinners(IBestWinnersService service)
        {
            return Results.Ok(service.GetWinners());
        }
    }
}
