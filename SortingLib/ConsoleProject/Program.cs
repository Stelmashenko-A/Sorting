using System;
using System.Collections.Generic;
using SortingLib;

namespace ConsoleProject
{
    class Program
    {
        static void Main()
        {
            var list = new List<int>();
            var rand = new Random();
            for (var i = 0; i < 20; i++)
            {
                list.Add(rand.Next(-100,100));
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            ISorter<int> sorter = new ShellSorter<int>();
            sorter.Sort(list, new ComarableSortComparer<int>());
            list.ForEach(x=>Console.Write(x+" "));
            Console.Read();
        }
    }
}
