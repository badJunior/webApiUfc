﻿namespace Ufc.Host;

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

    public IEnumerable<string> GetFighters()
    {
        return _fighters;
    }
}