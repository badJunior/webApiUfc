using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ufc.Logic;

namespace UFC.Services.Winners
{
    public interface IWinnersService
    {
        IEnumerable<CardWinner> GetWinners();
    }
}
