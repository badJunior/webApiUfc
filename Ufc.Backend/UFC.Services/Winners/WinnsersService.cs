using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;
using UFC.Services.Cards;

namespace UFC.Services.Winners
{
    internal class WinnsersService : IWinnersService
    {
        private readonly ICardsRepository _cardsRepository;

        public WinnsersService(ICardsRepository cardsRepository)
        {
            _cardsRepository = cardsRepository;
        }
        public IEnumerable<CardWinner> GetWinners()
        {
            var cards = _cardsRepository.GetCards();
            var cardScores = cards.Select(card => new CardScore(card));
            var cardWiners = cardScores.Select(cardScore => new CardWinner(cardScore));
            return cardWiners;
        }
    }
}
