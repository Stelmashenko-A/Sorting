using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortingLib.Testing
{
    public class SortTester<TData>
    {
        public IList<ISorter<TData>> Sorts { get; set; }
        public int ArraySize { get; set; }
        public ISortComparer<TData> Comparer { get; set; }
        public IRandom<TData> Random { get; set; }
        public int TestCyrles { get; set; }

        public SortTester(IList<ISorter<TData>> sorts, int arraySize, ISortComparer<TData> comparer,
            IRandom<TData> random, int testCyrles)
        {
            Sorts = sorts;
            ArraySize = arraySize;
            Comparer = comparer;
            Random = random;
            TestCyrles = testCyrles;
        }

        public IDictionary<ISorter<TData>, double> Test()
        {
            IDictionary<ISorter<TData>, IList<long>> results = new Dictionary<ISorter<TData>, IList<long>>();
            foreach (var variable in Sorts)
            {
                results.Add(variable, new List<long>());
            }

            for (var i = 0; i < TestCyrles; i++)
            {
                var list = GenerateData();
                foreach (var variable in Sorts)
                {
                    results[variable].Add(Test(variable, GetCopy(list)));
                }
            }

            IDictionary<ISorter<TData>, double> averageResult = new Dictionary<ISorter<TData>, double>();
            foreach (var variable in Sorts)
            {
                averageResult.Add(variable, results[variable].Average());
            }
            return averageResult;

        }

        protected long Test(ISorter<TData> sorter, IList<TData> data)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sorter.Sort(data, Comparer);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        protected IList<TData> GenerateData()
        {
            var list = new List<TData>();
            for (var i = 0; i < ArraySize; i++)
            {
                list.Add(Random.GetNext());
            }
            return list;
        }

        protected IList<TData> GetCopy(IList<TData> list)
        {
            return list.ToList();
        }
    }
}
