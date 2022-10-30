using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);

            foreach (int item in list.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(MyClass<List<int>>.FactoryMethod());
        }
    }
}
