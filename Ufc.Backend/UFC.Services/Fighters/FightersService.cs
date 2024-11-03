using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (_repository.GetFighters().Any(fighter => fighter == newFighter))
            {
                throw new InvalidOperationException("Такой боец уже есть");
            }

            _repository.AddFighter(newFighter);

        }

        public void DeleteFighter(string fighterToBeDeleted)
        {
            if (!_repository.GetFighters().Any(fighter => fighter == fighterToBeDeleted))
            {
                throw new InvalidOperationException("Такого бойца нет");

            }

            _repository.DeleteFighter(fighterToBeDeleted);

        }

        public IEnumerable<string> GetFighters()
        {
            return _repository.GetFighters();
        }
    }
}
