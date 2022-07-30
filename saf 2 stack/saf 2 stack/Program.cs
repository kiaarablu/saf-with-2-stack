using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saf_2_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1(3);

            a.Enqueue(1);
            a.Enqueue(2);
            a.Enqueue(3);
            a.Deqeueu();
            a.Enqueue(4);
            a.printnum();

            //a.dequeue();
            //a.printnum();
            //a.dequeue();
            //a.dequeue();
            //a.dequeue();

            Console.ReadKey();
        }
    }
}
