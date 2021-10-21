﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack tempRPN = new Stack();
            string s = "5 1 + 3 * 2 5 * 3 4 2 + * - +";
            string[] local = s.Split(' ');
            foreach (string st in local)
            {
                if (st[0] >= '0' && st[0] <= '9')
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
            //tempRPN.view();
            //Console.WriteLine();


            int[,] a = load(@"..\..\dataIN.txt");
            view(a);
            Lee();
        }
        static int [,] load(string fileName)
        {
            int lines;
            int columns;

            string buffer;
            List<string> data = new List<string>();

            System.IO.TextReader dataLoad = new System.IO.StreamReader(fileName);
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                data.Add(buffer);
            }
            dataLoad.Close();

            lines = data.Count();
            columns = (data[0].Split(' ')).Length;

            int[,] ToReturn = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                string[] values = data[i].Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    ToReturn[i, j] = int.Parse(values[j]);
                }
            }
            return ToReturn;
        }
        static void view (int[,] toView)
        {
            int lines = toView.GetLength(0);
            int columns = toView.GetLength(1);
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(toView[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Lee()
        {
            int[,] a = load(@"..\..\dataIN.txt");
            Queue A = new Queue();

            A.Push(new triData(0, 0, 1));
            a[0, 0] = 1;

            while (!A.isEmpty())
            {
                triData local = A.Pop();

                if (local.l - 1 >= 0)
                {
                    if (a[local.l - 1, local.c] == 0)
                    {
                        a[local.l - 1, local.c] = local.v + 1;
                        A.Push(new triData(local.l - 1, local.c, local.v + 1));
                    }
                }

                if (local.c + 1 < a.GetLength(1))
                {
                    if (a[local.l, local.c + 1] == 0)
                    {
                        a[local.l, local.c + 1] = local.v + 1;
                        A.Push(new triData(local.l, local.c + 1, local.v + 1));
                    }
                }

                if (local.l + 1 < a.GetLength(0))
                {
                    if (a[local.l + 1, local.c] == 0)
                    {
                        a[local.l + 1, local.c] = local.v + 1;
                        A.Push(new triData(local.l + 1, local.c, local.v + 1));
                    }
                }

                if (local.c - 1 >= 0)
                {
                    if (a[local.l, local.c - 1] == 0)
                    {
                        a[local.l, local.c - 1] = local.v + 1;
                        A.Push(new triData(local.l, local.c - 1, local.v + 1));
                    }
                }
            }
            view(a);
        }
    }
}
