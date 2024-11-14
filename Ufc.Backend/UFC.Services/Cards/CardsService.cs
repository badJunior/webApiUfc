using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;
using UFC.Services.Fighters;

namespace UFC.Services.Cards
{
    internal class CardsService : ICardsService
    {
        private readonly ICardsRepository _repository;

        private readonly  IFightersRepository _repositoryFighters;

        public CardsService(ICardsRepository repository, IFightersRepository repositoryFighters)
        {
            _repository = repository;
            _repositoryFighters = repositoryFighters;
        }

        public void AddCard()      
        {
          var fighters = _repositoryFighters.GetFighters();
           

            _repository.AddCard(fighters.Select(fighter => fighter.Name));
        }

        public void DeleteCard(int cardToBeDeleted)
        {
           

            _repository.DeleteCard(cardToBeDeleted);
        }

        public IEnumerable<Card> GetCards()
        {
           return _repository.GetCards();
        }

      
    }
}
