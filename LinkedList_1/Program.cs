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

            //Console.WriteLine($"Is it empty? - {list.Empty}" );

            //Console.WriteLine($"Count - {list.Count}");

            //list.Add("Test1");
            //list.Add("Test2");
            //list.Add(1, "Test3");


            //list.Remove(1);
            list.Add("Hello");
            list.Add("Test");
            int index = list.IndexOf("Hello");

            bool contains = list.Contains("Test");

            Console.ReadLine();
        }
    }
}
