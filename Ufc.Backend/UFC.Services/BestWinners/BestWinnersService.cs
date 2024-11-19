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

        public IEnumerable<BestFighter> GetWinners()
        {
            var cards = _cardsRepository.GetCards();
            var cardScores = cards.Select(card => new CardScore(card));
            var cardWinners = cardScores.Select(cardScore => new CardWinner(cardScore));

            var bestFightersList = cardWinners
                .GroupBy(cardWinner => cardWinner.FighterName)
                .Select(bestFighter => new BestFighter(
                    bestFighter.Key
                    , bestFighter.Sum(bestFighterScore => bestFighterScore.QuantityWins)));

            return bestFightersList.OrderByDescending(bestFighter => bestFighter.QuantityWins).Take(3);
        }
    }
}