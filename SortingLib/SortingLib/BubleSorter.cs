using System.Collections.Generic;

namespace SortingLib
{
    public class BubleSorter<T> : ISorter<T>
    {
        public void Sort(IList<T> list, ISortComparer<T> comparer)
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                for (var j = 0; j < list.Count - i - 1; j++)
                {
                    if (comparer.Compare(list[j], list[j + 1]) != 1) continue;
                    ISwap<T> swapper = new DefaultSwap<T>();
                    swapper.Swap(list, j, j + 1);
                }
            }
        }
    }
}