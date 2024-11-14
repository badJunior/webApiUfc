using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;

namespace UFC.Services.Fighters
{
    public interface IFightersService
    {
        IEnumerable<Fighter> GetFighters();
        void AddFighter(string newFighter);
        void DeleteFighter(int fighterToBeDeleted);
    }
}
