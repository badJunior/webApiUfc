namespace Ufc.Logic
{
    public class CardWinner
    {
        public string FighterName { get; set; }
        public int NumberCard { get; set; }
        public int QuantityWinners { get; set; }

        public CardWinner(CardScore cardScore)
        {

            Score score1 = null;
            foreach (var score in cardScore.Scores)
            {
                if (score1 == null || score1.QuantityWins < score.QuantityWins)
                {
                    score1 = score;
                }



            }



            FighterName = score1.FighetName;
            QuantityWinners = score1.QuantityWins;
            NumberCard = cardScore.Card.NumberCard;

        }
    }
}
