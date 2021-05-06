using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(List<int> arr)
        {
            int pCount = arr.Where(i => i > 0).Count();
            int nCount = arr.Where(i => i < 0).Count();
            var zCount = arr.Where(i => i == 0).Count();

            Console.WriteLine((pCount / arr.Count).ToString("F6",CultureInfo.InvariantCulture));
            Console.WriteLine((nCount / arr.Count).ToString("F6", CultureInfo.InvariantCulture));
            Console.WriteLine((zCount / arr.Count).ToString("F6", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);

        }
    }
}
