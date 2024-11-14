using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;
using UFC.Services.Fighters;

namespace UFC.Services.Cards
{
    public interface ICardsService
    {
        IEnumerable<Card> GetCards();
        void AddCard();
        void DeleteCard(int cardToBeDeleted);
    }
}
