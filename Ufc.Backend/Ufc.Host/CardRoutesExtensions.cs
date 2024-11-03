using Ufc.Logic;

namespace Ufc.Host;

public static class CardRoutesExtensions
{    
    public static IResult GetCardWinners(int cardsCount, IFightersRepository fightersRepository)
    {
        if (cardsCount <= 0)
        {
            return Results.BadRequest("Введено не существующее количетсов кардов");
        }

        var cards = new List<Card>();
        var listFighters = fightersRepository.GetFighters();
        
        for (var i = 0; i < cardsCount; i++)
        {
            cards.Add(new Card(i + 1, 20, listFighters));
        }

        var cardScores = cards.Select(card => new CardScore(card)).ToList();
        var cardWinners = cardScores.Select(cardScore => new CardWinner(cardScore)).ToList();

        return Results.Ok(cardWinners);
    }

    public static void RegisterCardRoutes(this WebApplication app)
    {
        app.MapGet("/cards", GetCardWinners);
    }
}