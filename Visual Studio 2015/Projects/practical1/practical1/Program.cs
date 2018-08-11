using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your country");
            country = Console.ReadLine();
            Console.WriteLine("hello! {0} from {1}.",name,country);
            Console.ReadKey();
        }
    }
}
