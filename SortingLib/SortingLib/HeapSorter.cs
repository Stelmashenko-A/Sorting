using System.Collections.Generic;

namespace SortingLib
{
    public class HeapSorter<T> : ISorter<T>
    {
        public void Sort(IList<T> list, ISortComparer<T> comparer)
        {
            for (var i = list.Count/2 - 1; i >= 0; i--)
            {
                ShiftDown(list, i, list.Count, comparer);
            }

            for (var i = list.Count - 1; i >= 1; i--)
            {
                ISwap<T> swapper = new DefaultSwap<T>();
                swapper.Swap(list, 0, i);
                ShiftDown(list, 0, i, comparer);
            }
        }

        protected void ShiftDown(IList<T> list, int leftBound, int rightBound, ISortComparer<T> comparer)
        {
            while ((leftBound*2 + 1 < rightBound))
            {
                var maxChild = leftBound*2 + 1;
                if (leftBound*2 + 1 != rightBound - 1 &&
                    comparer.Compare(list[leftBound*2 + 1], list[leftBound*2 + 2]) != 1)
                {
                    maxChild++;
                }

                if (comparer.Compare(list[leftBound], list[maxChild]) != -1)
                {
                    break;
                }

                ISwap<T> swapper = new DefaultSwap<T>();
                swapper.Swap(list, leftBound, maxChild);
                leftBound = maxChild;
            }
        }
    }
}