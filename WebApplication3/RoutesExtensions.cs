using Ufc.Logic;

namespace WebApplication3
{

    public static class RoutesExtensions
    {
        public static IResult GetCardWinners(int cardsCount, IFightersRepository fightersRepository)
        {
            if (cardsCount <= 0)
            {
                return Results.BadRequest("Введено не существующее количетсов кардов");
            }


            var cards = new List<Card>();

            var listFighters = fightersRepository.GetFighters();


            

            for (int i = 0; i < cardsCount; i++)
            {

                cards.Add(new Card(i + 1, 20, listFighters));
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
