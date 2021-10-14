using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue A = new Queue();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.Push(4);
            A.Pop();
            A.Push(7);
            A.view();
            Console.WriteLine();

            Stack B = new Stack();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.Push(4);
            B.Pop();
            B.Push(7);
            B.view();
            Console.WriteLine();
        }
    }
}
