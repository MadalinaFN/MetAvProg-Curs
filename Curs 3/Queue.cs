using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_3
{
    class Queue
    {
        triData[] values;

        public Queue()
        {
            values = new triData[0];
        }

        public void Push(triData ValueToAdd)
        {
            triData[] temp = new triData[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
                temp[i + 1] = values[i];
            temp[0] = ValueToAdd;
            values = temp;
        }

        public bool isEmpty()
        {
            if (values.Length == 0)
            {
                return true;
            }
            return false;
        }

        public triData Pop()
        {
            triData toReturn = values[values.Length - 1];
            triData[] temp = new triData[values.Length - 1];
            for (int i = 0; i < values.Length - 1; i++)
                temp[i] = values[i];
            values = temp;
            return toReturn;
        }

        public void view()
        {
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i].view());
        }
    }
}
