using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;
using UFC.Services.Cards;

namespace UFC.Services.BestWinners
{
    internal class BestWinnersService : IBestWinnersService
    {
        private readonly ICardsRepository _cardsRepository;

        public BestWinnersService(ICardsRepository cardsRepository)
        {
            _cardsRepository = cardsRepository;
        }
        public IEnumerable<BestOfTheBest> GetWinners()
        {
            var cards = _cardsRepository.GetCards();
            var cardScores = cards.Select(card => new CardScore(card));
            var cardWinners = cardScores.Select(cardScore => new CardWinner(cardScore));
            var bestOfTheBests = cardWinners.Select(cardWinner => new BestOfTheBest(cardWinner)).OrderByDescending(cardWinner=>cardWinner).Take(3);
            estOfTheBests bestOfTheBest;
            foreach (bestOfTheBest in bestOfTheBests)
            {
                foreach (var cardWinner in cardWinners)
                {
                    if (bestOfTheBest.FighterName == cardWinner.FighterName)
                    {
                        bestOfTheBest.QuantityWins += cardWinner.QuantityWins;
                    }

                   
                }
            }

            if (bestOfTheBest == null)
            {
                bestOfTheBests.Add(new())
            }
            return bestOfTheBest;
        }

        
    }
}
