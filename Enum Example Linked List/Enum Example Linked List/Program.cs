using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list2 = new LinkedList<int>();
            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(5);

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
