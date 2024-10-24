namespace Ufc.Logic;

public class Card
{
    public Card(int number, int fightsCount, IEnumerable<string> fighterNames)
    {
        var fights = new List<Fight>();
        var fightersNamesArray = fighterNames.ToArray();
        
        for (var j = 0; j < fightsCount; j++)
        {
            var fighters = ChooseFighters(fightersNamesArray);
            fights.Add(new Fight(fighters.Fighter1, fighters.Fighter2));
        }

        Fights = fights;
        NumberCard = number;
    }

    public List<Fight> Fights { get; set; }

    public int NumberCard { get; set; }
    
    private static (string Fighter1, string Fighter2) ChooseFighters(string[] fighterNames)
    {
        string fighter1, fighter2;
        var random = new Random();
        
        do
        {
            fighter1 = fighterNames[random.Next(fighterNames.Length)];
            fighter2 = fighterNames[random.Next(fighterNames.Length)];
        } while (fighter1 == fighter2);

        return (fighter1, fighter2);
    }
}