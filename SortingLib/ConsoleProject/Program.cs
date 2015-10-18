using System;
using System.Collections.Generic;
using SortingLib;
using SortingLib.Testing;

namespace ConsoleProject
{
    class Program
    {
        static void Main()
        {

            List<ISorter<int> >list=new List<ISorter<int>>();
            //list.Add(new BubleSorter<int>());
            list.Add(new HeapSorter<int>());
            list.Add(new ShellSorter<int>());
            SortTester<int> tester=new SortTester<int>(list,1000000,new ComarableSortComparer<int>(),new IntRandom(),20);
            var res=tester.Test();
            Console.Read();
        }
    }
}
