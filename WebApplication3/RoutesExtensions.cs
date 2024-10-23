using UFC.Logic;

namespace WebApplication3
{
   
    public static class RoutesExtensions
    {
        public static IResult GetCardWinners(int cardsCount, IFightersRepository fightersRepository)
        {
          
            
             var fighters = new string[] { "Makhachev", " Tsarukyan", "Oliveira", "Geitji", "Porye", "Gamroth", "Chandler", "Dariush", "Physiology", "Holloway", };
                
             var cards = new List<Card>();

            
            

            if (cardsCount <= 0)
                {
                    return Results.BadRequest("Введено не существующее количетсов кардов");
                }

                for (int i = 0; i < cardsCount; i++)
                {

                    cards.Add(new Card(i + 1, 20, fightersRepository));
                }

                var cardscores = cards.Select(card => new CardScore(card)).ToList();

                var cardWinners = cardscores.Select(cardscore => new CardWinner(cardscore)).ToList();


                return Results.Ok(cardWinners);


            
        }

        public static void RegisterRoutes(this WebApplication app)
        {
           

            app.MapGet("/cards", GetCardWinners);
        }
    }
}
