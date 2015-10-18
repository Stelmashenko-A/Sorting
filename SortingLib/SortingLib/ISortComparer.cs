namespace SortingLib
{
    public interface ISortComparer<in T>
    {
        int Compare(T first, T second);
    }
}