using Ufc.Logic;

namespace UFC.Services.Fighters;

internal interface IFightersRepository
{
    IEnumerable<Fighter> GetFighters();
    void AddFighter(string newFighter);
    void DeleteFighter(int fighterToBeDeleted);

}
