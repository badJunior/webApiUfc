namespace Ufc.Logic
{
    public class CardScore
    {
        public List<Score> Scores { get; set; }
        public Card Card { get; set; }
        public CardScore(Card card)
        {

            var scores = card.Fights.GroupBy(fight => fight.Winner).Select(CalculateScore).ToList();

            Scores = scores;
            Card = card;
        }

        private Score CalculateScore(IGrouping<string, Fight> group)
        {
            Score score = new Score(group.Key);
            score.QuantityWins = group.Count();
            return score;
        }

    }
}
