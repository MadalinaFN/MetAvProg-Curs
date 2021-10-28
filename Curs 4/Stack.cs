using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_4
{
    public class Stack : Tube
    {
        public Stack():base()
        {

        }

        public void Push(int x)
        {
            addbeg(x);
        }

        public int Pop()
        {
            return delbeg();
        }

        public override void view()
        {
            base.view();
        }
    }

    public class Queue : Tube
    {
        public Queue() : base()
        {

        }

        public void Push(int x)
        {
            addbeg(x);
        }

        public int Pop()
        {
            return delend();
        }

        public override void view()
        {
            base.view();
        }
    }
}
