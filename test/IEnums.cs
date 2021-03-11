using System;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    public static class Program
    {
        static void Main()
        {
            ApiMain.FileClasss.FileReader("C:/Users/Gio/Documents/c#/test/test/dummy.txt");
            // Console.WriteLine(ApiMain.J());
            // var enumerableOfNumbers = (IEnumerable<int>) nums;
            // using var enumeratorOfNumbers1 = nums.GetEnumerator();
            // var nums = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // using var z = nums.GetEnumerator();
            // var powerOfRandom = new PowerOfRandom(nums);
            // foreach (var x in powerOfRandom)
            // {
            //     Console.WriteLine(x);   
            // }
        }
    }
    internal class PowerOfRandom : IEnumerable<int>
    {
        private readonly List<int> _k;

        public PowerOfRandom(List<int> nums)
        {
            _k = nums;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new PowOfRandomEnumerator(_k);
        }       
     IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }       
    }
    internal class PowOfRandomEnumerator : IEnumerator<int>
    {
        private readonly List<int> _l;
        public PowOfRandomEnumerator(List<int> ints)
        {
            _l = ints;
        }
        private static readonly Random Random = new Random();
        private readonly int _cRandom = Random.Next(2, 5);
        public int Current => (int)Math.Pow(_l[_index], _cRandom);
        private int _index = -1;

        public bool MoveNext()
        {
            _index++;
            return _index < _l.Count;
        }
        public void Reset()
        {
            _index = 0;
        }
        public void Dispose()
        {
        }
        object IEnumerator.Current => Current;
    }
}