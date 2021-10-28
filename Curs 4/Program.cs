using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tube A = new Tube();
            A.addbeg(1);
            A.addbeg(2);
            A.addbeg(3);
            A.addbeg(4);
            A.addend(5);
            A.addend(6);
            A.addend(7);
            A.addend(8);
            A.delend();
            //A.view();

            Stack B = new Stack();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.Push(4);
            B.Pop();
            //B.view();

            Queue C = new Queue();
            C.Push(1);
            C.Push(2);
            C.Push(3);
            C.Push(4);
            C.Pop();
            //C.view();

            LPO lpo = new LPO();
            lpo.Push(10);
            lpo.Push(12);
            lpo.Push(7);
            lpo.Push(13);
            lpo.Push(7);
            lpo.Push(1);
            lpo.Push(5);
            lpo.Pop(7);
            lpo.view();
        }
    }
}
