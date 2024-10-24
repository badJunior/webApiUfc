namespace Ufc.Logic;

public class CardScore
{
    public CardScore(Card card)
    {
        var scores = card.Fights
            .GroupBy(fight => fight.Winner)
            .Select(group => new Score(group.Key, group.Count()))
            .ToList();

        Scores = scores;
        Card = card;
    }

    public List<Score> Scores { get; set; }
    public Card Card { get; set; }
}