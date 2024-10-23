﻿
namespace WebApplication3
{
    public class InMemoryFightersRepository : IFightersRepository
    {
        private List<string> _fighters;

        public InMemoryFightersRepository()
        {

            _fighters = new List<string>() { "Makhachev", " Tsarukyan", "Oliveira", "Geitji", "Porye", "Gamroth", "Chandler", "Dariush", "Physiology", "Holloway", };

        }

        public IEnumerable<string> GetFighters()
        {
            return _fighters;
        }
    }
}
