using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicle3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=65;
            for(int i=1;i<5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" {0}",Convert.ToChar(a));
                    a++;
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
