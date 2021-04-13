using System;
using System.Collections.Generic;

namespace Fundamental_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>{12,11,1,5,0 };
            data.Add(19);
            int sum = 0;
            foreach (var number in data)
            {
                sum += number;
            }
            Console.WriteLine("sum of the list is {0}", sum);
        }
    }
}
