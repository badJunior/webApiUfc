using Ufc.Logic;

namespace UFC.Services.Fighters;

public class InMemoryFightersRepository : IFightersRepository
{

    private readonly List<Fighter> _fighters = new List<Fighter>();


    public InMemoryFightersRepository()
    {
        var names = new List<string>() { 
        "Makhachev"
        , "Tsarukyan"
        , "Oliveira"
        , "Geitji"
        , "Porye"
        , "Gamroth"
        , "Chandler"
        , "Dariush"
        , "Physiology"
        , "Holloway"
    };
        var fighters = names.Select((name, index) => new Fighter(name, index + 1));
        _fighters.AddRange(fighters);
    } 
    public void AddFighter(string newFighterName)
    { 
            var id = 1;
            if (_fighters.Any()) 
            {
              
                var maxNumber  = _fighters.Max(fighter => fighter.Id);
                id += maxNumber;
            }   
        var newFighter = new Fighter(newFighterName,id);
        _fighters.Add(newFighter);
    }

    public void DeleteFighter(int fighterToBeDeleted)
    {
        if (!_fighters.Any(fighter => fighter.Id == fighterToBeDeleted))
        {
            throw new InvalidOperationException("Такого бойца нет");

        }

        _fighters.Remove(_fighters.First(fighter => fighter.Id == fighterToBeDeleted));
        
    }

    public IEnumerable<Fighter> GetFighters()
    {
        return _fighters;
    }


}