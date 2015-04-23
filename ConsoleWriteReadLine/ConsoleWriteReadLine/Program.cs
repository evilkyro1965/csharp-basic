using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriteReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 940;
            int j = 73;

            Console.WriteLine(" {0,4}\n+{1,4}\n ____\n {2,4}", i, j, i + j);
            Console.ReadKey();
        }
    }
}
