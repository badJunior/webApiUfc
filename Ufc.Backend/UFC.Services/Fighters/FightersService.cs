using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;

namespace UFC.Services.Fighters
{
    internal class FightersService : IFightersService
    {
        private readonly IFightersRepository _repository;

        public FightersService(IFightersRepository repository)
        {
            _repository = repository;
        }

        public void AddFighter(string newFighter)
        {
            

            _repository.AddFighter(newFighter);

        }

        public void DeleteFighter(int fighterToBeDeleted)
        {
          

            _repository.DeleteFighter(fighterToBeDeleted);

        }

        public IEnumerable<Fighter> GetFighters()
        {
            return _repository.GetFighters();
        }
    }
}
