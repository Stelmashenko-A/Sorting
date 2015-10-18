namespace SortingLib.Testing
{
    public interface IRandom<out T>
    {
        T GetNext();
    }
}