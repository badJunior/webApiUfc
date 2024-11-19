using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufc.Logic;

public class BestOfTheBest
{
    public BestOfTheBest (CardWinner cardWinner)
    {
        var bestScore = cardWinner;

        FighterName = bestScore.FighterName;
        QuantityWins = bestScore.QuantityWins;
        
    }

    public string FighterName { get; set; }
   
    public int QuantityWins { get; set; }
}
