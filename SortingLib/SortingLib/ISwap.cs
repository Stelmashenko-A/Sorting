using System.Collections.Generic;

namespace SortingLib
{
    public interface ISwap<T>
    {
        void Swap(IList<T> list, int first, int second);
    }
}