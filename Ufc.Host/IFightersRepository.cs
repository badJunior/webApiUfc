namespace Ufc.Host;

public interface IFightersRepository
{
    IEnumerable<string> GetFighters();
}