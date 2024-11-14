using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;

namespace UFC.Services.Cards
{
    public class InMemoryCardsRepository : ICardsRepository
    {
        private const int fightsCount = 10;
        private readonly List<Card> _cards = new List<Card>();
        public void AddCard(IEnumerable<string> fighters)
        {
            var number = 1;
            if (_cards.Any()) 
            {
              
                var maxNumber  = _cards.Max(card => card.NumberCard);
                number += maxNumber;
            }   
            
            _cards.Add(new Card(number,fightsCount,fighters));
        }

        public void DeleteCard(int cardToBeDeleted)
        {
            if (!_cards.Any( card => card.NumberCard == cardToBeDeleted))
            {
                throw new InvalidOperationException("Такого карда нет");
                
            }

            _cards.Remove(_cards.First(card => card.NumberCard == cardToBeDeleted));
        }

        public IEnumerable<Card> GetCards()
        {
            return _cards;
        }
    }
}
