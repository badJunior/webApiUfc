using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFC.Services.Fighters;

namespace UFC.Services.Cards
{
    internal class CardsService : ICardsService
    {
        private readonly ICardsRepository _repository;

        public CardsService(ICardsRepository repository)
        {
            _repository = repository;
        }

        public void AddCard(int newCard)
        {
            if (_repository.GetCards().Any(card => card == newCard))
            {
                throw new InvalidOperationException("Такой кард уже есть");
            }

            _repository.AddCard(newCard);
        }

        public void DeleteCard(int cardToBeDeleted)
        {
            if (!_repository.GetCards().Any(card => card == cardToBeDeleted))
            {
                throw new InvalidOperationException("Такого карда нет");

            }

            _repository.DeleteCard(cardToBeDeleted);
        }

        public IEnumerable<int> GetCards()
        {
           return _repository.GetCards();
        }
    }
}
