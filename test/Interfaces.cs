using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace test
{
    // var nums = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    // var enumerableOfNumbers = (IEnumerable<int>) nums;
    // using var z = nums.GetEnumerator();

    // var powerOfRandom = new PowerOfRandom(nums);
    // foreach (var x in powerOfRandom)
    // {
    // Console.WriteLine(x);   
    // }
    internal class PowerOfRandom : IEnumerable<int>
    {
        private List<int> K { get; set; }

        public PowerOfRandom(List<int> nums)
        {
            K = nums;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new PowOfRandomEnumerator(K);
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
    internal class Dog : IComparable<Dog>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; private set; }
        private readonly Random _rand = new Random();

        public Dog(string name)
        {
            Name = name;
            Age = _rand.Next(0, 100);
        }

        public int CompareTo(Dog other)
        {
            // return this.Age.CompareTo(other.Age);
            if (this.Age > other.Age)
            {
                return 1;
            }
            if(this.Age == other.Age)
            {
                return 0;
            }
            return -1;
        }
    }
    public class Dis : IDisposable
    {
        private readonly StreamWriter _sw = new StreamWriter("sasasa");
        private void Cleanup()
        {
            
        }

        void IDisposable.Dispose()
        {
            _sw.Dispose();            
        }
    }

}