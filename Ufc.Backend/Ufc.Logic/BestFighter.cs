using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufc.Logic;

public class BestFighter
{
    public BestFighter (string name, int winCount)
    {
        FighterName = name;
        QuantityWins = winCount;
    }

    public string FighterName { get; set; }
   
    public int QuantityWins { get; set; }
}
