using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;

namespace UFC.Services.Cards
{
    internal interface ICardsRepository
    {
        IEnumerable<Card> GetCards();
        void AddCard(IEnumerable<string> fighters);
        void DeleteCard(int cardToBeDeleted);
    }
}
