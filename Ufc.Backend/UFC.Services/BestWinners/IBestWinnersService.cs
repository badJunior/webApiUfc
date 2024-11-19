using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;

namespace UFC.Services.BestWinners
{
    public interface IBestWinnersService
    {
        IEnumerable<BestFighter> GetWinners();
    }
}

