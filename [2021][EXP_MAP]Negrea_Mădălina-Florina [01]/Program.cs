using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021__EXP_MAP_Negrea_Mădălina_Florina__01_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 11, 23, 34, 59, 6 };
            int j = 1;
            bool prim = false;
            int sum = 0;

            for (int i = 0; i < v.Length; i++)
            {
                while (j <= v[i])
                {
                    if (v[i] % j == 0)
                    {
                        prim = true;
                    }
                    j++;
                }
            }

            if (prim)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    sum = sum + v[i];
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
