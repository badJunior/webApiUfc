using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFC.Services.Cards
{
    internal interface ICardsRepository
    {
        IEnumerable<int> GetCards();
        void AddCard(int newCard);
        void DeleteCard(int cardToBeDeleted);
    }
}
