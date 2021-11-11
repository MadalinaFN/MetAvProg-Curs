using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021__EXP_MAP_Negrea_Mădălina_Florina__03_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack tempRPN = new Stack();
            string s = "1 2 - 3 4 * - 2 78 + - 23 1 + 4 * - 2 344 + 1 97 3 4 5 + 2 * - +";
            string[] local = s.Split(' ');
            foreach (string st in local)
            {
                if (st[0] >= '0' && st[0] <= '345')
                {
                    tempRPN.Push(int.Parse(st));
                }
                else
                {
                    int t1 = tempRPN.Pop();
                    int t2 = tempRPN.Pop();
                    switch (st[0])
                    {
                        case '+': tempRPN.Push(t2 + t1); break;
                        case '*': tempRPN.Push(t2 * t1); break;
                        case '-': tempRPN.Push(t2 - t1); break;
                        case '/': tempRPN.Push(t2 / t1); break;
                    }
                }
            }
            tempRPN.view();
            Console.WriteLine();
        }
    }
}
