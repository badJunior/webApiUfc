namespace Ufc.Logic;

public class CardWinner
{
    public CardWinner(CardScore cardScore)
    {
        var bestScore = cardScore.Scores
            .OrderByDescending(score => score.QuantityWins)
            .First();

        FighterName = bestScore.FighterName;
        QuantityWins = bestScore.QuantityWins;
        NumberCard = cardScore.Card.NumberCard;
    }

    public string FighterName { get; set; }
    public int NumberCard { get; set; }
    public int QuantityWins { get; set; }
}