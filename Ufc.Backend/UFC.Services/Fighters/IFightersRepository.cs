namespace UFC.Services.Fighters;

internal interface IFightersRepository
{
    IEnumerable<string> GetFighters();
    void AddFighter(string newFighter);
    void DeleteFighter(string fighterToBeDeleted);

}
