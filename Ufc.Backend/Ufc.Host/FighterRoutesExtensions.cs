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

        private static IResult DeleteFighter(string fighterToDelete, IFightersRepository repository)
        {
            if (string.IsNullOrWhiteSpace(fighterToDelete))
            {
                return Results.BadRequest("Неправильное имя бойца");
            }

            if (!repository.GetFighters().Any(fighter => fighter == fighterToDelete))
            {
                return Results.NotFound("Такого бойца нет");
            }

            repository.DeleteFighter(fighterToDelete);
            return Results.Ok();
        }

        private static IResult CreateFighter(string newFighterName, IFightersRepository repository) 
        {
            if (string.IsNullOrWhiteSpace(newFighterName)) 
            {
                return Results.BadRequest("Неправильное имя бойца");
            }

            if(repository.GetFighters().Any(fighter=> fighter == newFighterName))
            {
                return Results.BadRequest("Такой боец уже есть");
            }

            repository.AddFighter(newFighterName);
            
            return Results.Ok();
        }
        private static IResult GetFighters(IFightersRepository repository) 
        {
            return Results.Ok(repository.GetFighters());
        }
    }
}
