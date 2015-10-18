using System;

namespace SortingLib
{
    public class ComarableSortComparer<T> : ISortComparer<T> where T : IComparable
    {
        public int Compare(T first, T second)
        {
            return first.CompareTo(second);
        }
    }
}
