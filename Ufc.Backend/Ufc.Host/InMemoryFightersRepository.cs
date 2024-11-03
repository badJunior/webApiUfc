namespace Ufc.Host;

public class InMemoryFightersRepository : IFightersRepository
{
    private readonly List<string> _fighters =
    [
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
    ];

    public void AddFighter(string newFighter)
    {
        _fighters.Add(newFighter);
    }

    public void DeleteFighter(string fighterToBeDeleted)
    {
        _fighters.Remove(fighterToBeDeleted);
    }

    public IEnumerable<string> GetFighters()
    {
        return _fighters;
    }

    
}