namespace Ufc.Logic;

public class Fight
{
    public Fight(string fighter1, string fighter2)
    {
        Fighter1 = fighter1;
        Fighter2 = fighter2;
        
        Winner = CalculateResult(fighter1, fighter2);
    }

    public string Fighter1 { get; set; }
    public string Fighter2 { get; set; }
    public string Winner { get; set; }

    private static string CalculateResult(string fighter1, string fighter2)
    {
        var result = new Random().Next(0, 2);
        
        return result == 1 ? fighter1 : fighter2;
    }
}