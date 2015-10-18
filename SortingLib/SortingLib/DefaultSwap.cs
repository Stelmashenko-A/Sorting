using System.Collections.Generic;

namespace SortingLib
{
    class DefaultSwap<T> : ISwap<T>
    {
        public void Swap(IList<T> list, int first, int second)
        {
            object obj = list[first];
            list[first] = list[second];
            list[second] = (T)obj;
        }
    }
}