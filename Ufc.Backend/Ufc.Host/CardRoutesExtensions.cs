using Ufc.Logic;
using UFC.Services;
using UFC.Services.Cards;

namespace Ufc.Host;

public static class CardRoutesExtensions
{    
   
    public static void RegisterCardRoutes(this WebApplication app)
    {
        // app.MapGet("/cards", GetCardWinners);
        var cards = app.MapGroup("/cards");
        cards.MapGet("/", GetCard);
        cards.MapPut("/{newCardNuber}", CreateCard);
        cards.MapDelete("/{cardToDelete}", DeleteCard);
    }

   

    private static IResult DeleteCard(int cardToDelete, ICardsService service)
    {
        if (cardToDelete <= 0)
        {
            return Results.BadRequest("Неправильный номер карда");
        }

        try
        {
            service.DeleteCard(cardToDelete);
        }
        catch (InvalidOperationException ex)
        {
            return Results.BadRequest(ex.Message);
        }
        return Results.Ok();
    }

    private static IResult CreateCard(int newCardNumber, ICardsService service)
    {
        if (newCardNumber <=0 )
        {
            return Results.BadRequest("Неправильный номер карда");
        }

        service.AddCard(newCardNumber);

        return Results.Ok();
    }
    private static IResult GetCard(ICardsService service)
    {
        return Results.Ok(service.GetCards());
    }
}
