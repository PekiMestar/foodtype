using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType banana = new FoodType("banana", 4, 93, 3);
            
            Console.WriteLine(banana.ToString());

            Console.ReadKey();
        }
    }
}
