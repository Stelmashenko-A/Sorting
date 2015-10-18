using System.Collections.Generic;

namespace SortingLib
{
    public class ShellSorter<T> : ISorter<T>
    {
        public void Sort(IList<T> list, ISortComparer<T> comparer)
        {
            for (var d = (list.Count - 0)/2; d != 0; d /= 2)
            {
                for (var i = d; i != list.Count; ++i)
                {
                    for (var j = i; j >= d && comparer.Compare(list[j], list[j - d]) == -1; j -= d)
                    {
                        ISwap<T> swaper = new DefaultSwap<T>();
                        swaper.Swap(list, j, j - d);
                    }
                }
            }
        }
    }
}