using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine($"Is it empty? - {list.Empty}" );

            Console.WriteLine($"Count - {list.Count}");

            Console.ReadLine();
        }
    }
}
