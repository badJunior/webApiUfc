namespace Ufc.Host;

public interface IFightersRepository
{
    IEnumerable<string> GetFighters();
    void AddFighter(string newFighter);
    void DeleteFighter(string fighterToBeDeleted);

}
