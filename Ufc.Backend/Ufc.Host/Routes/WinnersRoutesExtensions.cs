using UFC.Services.Winners;

namespace Ufc.Host.Routes
{
    public static class WinnersRoutesExtensions
    {
        public static void RegisterWinnerRoutes(this WebApplication app)
        {
            app.MapGet("/winners", GetWinners);
        }

        private static IResult GetWinners(IWinnersService service)
        {
            return Results.Ok(service.GetWinners());
        }
    }
}
