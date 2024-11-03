using UFC.Services.Fighters;

namespace Ufc.Host
{
    public static class FighterRoutesExtensions
    {
        public static void RegisterFighterRoutes(this WebApplication app)
        {
            var fighters = app.MapGroup("/fighters");  
            fighters.MapGet("/", GetFighters);
            fighters.MapPut("/{newFighterName}",CreateFighter);
            fighters.MapDelete("/{fighterToDelete}", DeleteFighter);   
        }

        private static IResult DeleteFighter(string fighterToDelete, IFightersService service)
        {
            if (string.IsNullOrWhiteSpace(fighterToDelete))
            {
                return Results.BadRequest("Неправильное имя бойца");
            }

            try
            {
                service.DeleteFighter(fighterToDelete);
            }
            catch (InvalidOperationException ex) 
            { 
                return Results.BadRequest(ex.Message);
            }
            return Results.Ok();
        }

        private static IResult CreateFighter(string newFighterName, IFightersService service) 
        {
            if (string.IsNullOrWhiteSpace(newFighterName)) 
            {
                return Results.BadRequest("Неправильное имя бойца");
            }

           service.AddFighter(newFighterName);
            
            return Results.Ok();
        }
        private static IResult GetFighters(IFightersService service) 
        {
            return Results.Ok(service.GetFighters());
        }
    }
}
