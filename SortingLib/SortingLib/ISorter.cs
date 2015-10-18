using System.Collections.Generic;

namespace SortingLib
{
    public interface ISorter<T>
    {
        void Sort(IList<T> list);
    }
}