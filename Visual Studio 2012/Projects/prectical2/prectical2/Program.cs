using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prectical2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel, fer;
            Console.WriteLine("Enter the celsius value :");
            cel =Convert.ToDouble( Console.ReadLine());
            fer = (1.8)*cel + 32;
            Console.WriteLine("The {0} in Fahrenheit is {1}.", cel, fer);
            Console.ReadKey();
        }
    }
}
