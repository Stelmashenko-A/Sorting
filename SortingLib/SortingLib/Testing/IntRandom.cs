using System;

namespace SortingLib.Testing
{
    public class IntRandom : IRandom<int>
    {
        readonly Random _rand=new Random();
        public int GetNext()
        {
            return _rand.Next();
        }
    }
}