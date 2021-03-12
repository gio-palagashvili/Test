using System;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    public static class Program
    {
        static void Main()
        {
            var dogs = new List<Dog>()
            {
                new Dog("b"),
                new Dog("d"),
                new Dog("a"),
                new Dog("f"),
                new Dog("g"),
                new Dog("e"),
                new Dog("c"),
            };
            dogs.Sort();
            dogs.ForEach(x => Console.WriteLine(x.Age));
        }
    }
}