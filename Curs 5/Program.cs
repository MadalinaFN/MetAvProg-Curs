using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curs_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
        }

        private static void Ex2()
        {
            int n = 7;
            int[] sol = new int[n];
            bool[] visited = new bool[n];
            back(0, n, sol, visited);
            Console.ReadKey();
        }

        static void back(int k, int n, int[] sol, bool[] vis)
        {
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(sol[i] + " ");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        back(k + 1, n, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        private static void Ex1()
        {
            TextReader load = new StreamReader(@"..\..\data.in");
            int n = int.Parse(load.ReadLine());
            int[,] na = new int[n, n];

            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local_data = buffer.Split(' ');
                int x = int.Parse(local_data[0]);
                int y = int.Parse(local_data[1]);

                na[x - 1, y - 1] = 1;
                na[y - 1, x - 1] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(na[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool hasIsland = false;
            for (int i = 0; i < n; i++)
            {
                bool local = true;
                for (int j = 0; j < n; j++)
                {
                    if (na[i, j] == 1)
                    {
                        local = false;
                        break;
                    }
                }
                if (local)
                {
                    hasIsland = true;
                    break;
                }
            }
            if (hasIsland)
            {
                Console.WriteLine("islands: Da");
            }
            else
            {
                Console.WriteLine("islands: Nu");
            }

            bool hasgimpar = false;

            if (hasIsland)
            {
                Console.WriteLine("eulerian: Nu");
            }
            else
            {
                bool isEulerian = true;
                int nrnimp = 0;
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum += na[i, j];
                    }
                    if ((sum % 2) == 1)
                    {
                        nrnimp++;
                        hasgimpar = true;
                        if (nrnimp > 2)
                        {
                            isEulerian = false;
                            break;
                        }
                    }
                }
                if (isEulerian)
                {
                    Console.WriteLine("eulerian: Da");
                }
                else
                {
                    Console.WriteLine("eulerian: Nu");
                }
            }
            if (!hasgimpar)
            {
                Console.WriteLine("eulerian cycle detected");
            }
        }
    }
}
