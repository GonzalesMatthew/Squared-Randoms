using System;
using System.Collections.Generic;
using System.Linq;

namespace Squared_Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //create a list
            var randoms = new List<int>();
            //populate the list
            while (randoms.Count < 20)
            {
                int num = random.Next(0,50);
                randoms.Add(num);
            }
            Console.WriteLine($"List is: {String.Join(",", randoms)}");
            //create squared list
            var squaredList = randoms.Select(x => x * x);
            Console.WriteLine($"Squared list is: {String.Join(",", squaredList)}");
            //remove odd numbers from squaredList
            var removeOdds = squaredList.Where(x => x % 2 == 0);
            Console.WriteLine($"With odds removed: {String.Join(",", removeOdds)}");
        }
    }
}
