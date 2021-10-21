using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_3
{
    public class triData
    {
        public int l, v, c;
        public triData(int l, int c, int v)
        {
            this.l = l;
            this.c = c;
            this.v = v;
        }
        public string view()
        {
            return "(" + l + " " + c + " " + v + ")";
        }
    }
}
