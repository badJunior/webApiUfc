using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFC.Services.Fighters
{
    public interface IFightersService
    {
        IEnumerable<string> GetFighters();
        void AddFighter(string newFighter);
        void DeleteFighter(string fighterToBeDeleted);
    }
}
