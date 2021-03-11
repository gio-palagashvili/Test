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
            Console.WriteLine(ApiMain.J());
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
}