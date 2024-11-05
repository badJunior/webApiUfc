using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFC.Services.Cards
{
     public class InMemoryCardsRepository : ICardsService
    {
        private readonly List<int> _cards = new List<int>();

        public void AddCard(int newCard)
        {
           _cards.Add(newCard);
        }

        public void DeleteCard(int cardToBeDeleted)
        {
            _cards.Remove(cardToBeDeleted);
        }

        public IEnumerable<int> GetCards()
        {
            return _cards;
        }
    }
}
