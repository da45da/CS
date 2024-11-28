using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 100; i > 20; i++)
            {
                if (i % 1000000 == 0)
                    Console.WriteLine(i.ToString());
            }

        }
    }
}
