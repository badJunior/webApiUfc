namespace Ufc.Logic;

public class Score
{
    public Score(string fighterName, int quantityWins)
    {
        FighterName = fighterName;
        QuantityWins = quantityWins;
    }
    
    public Score(string fighterName)
    {
        FighterName = fighterName;
        QuantityWins = 1;
    }

    public string FighterName { get; set; }
    public int QuantityWins { get; set; }
}