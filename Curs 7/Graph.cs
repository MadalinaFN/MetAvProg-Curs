using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_7
{
    class Graph
    {
        public List<Vertice> vertices;
        public List<Edge> edges;
        public Graph()
        {
            vertices = new List<Vertice>();
            edges = new List<Edge>();
        }

        public void load(string file_name)
        {
            TextReader data_load = new StreamReader(@"..\..\" + file_name);
            int n = int.Parse(data_load.ReadLine());
            for (int i = 0; i < n; i++)
                vertices.Add(new Vertice(data_load.ReadLine()));

            string buffer;
            while ((buffer = data_load.ReadLine()) != null)
            {
                edges.Add(new Edge(buffer, vertices));
            }
        }

        bool islink(int i, int j)
        {
            foreach (Edge edg in edges)
            {
                if (edg.begin_vertice == vertices[i] && edg.end_vertice == vertices[j])
                    return true;
                if (edg.begin_vertice == vertices[j] && edg.end_vertice == vertices[i])
                    return true;
            }
            return false;
        }
        //greedy
        //pentru colorarea unei harti(graf)
        public void color()
        {

            //ordinea conteaza
            //sa orodoban prima data nodurile in functie de grad -> descrescator
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Violet, Color.Sienna };
            int[] C = new int[vertices.Count];
            for (int i = 0; i < vertices.Count; i++)
                C[i] = -1;
            C[0] = 0;

            for (int i = 1; i < vertices.Count; i++)
            {
                bool[] colors_idx = new bool[vertices.Count];
                for (int j = 0; j < vertices.Count; j++)
                    if (i != j && C[j] != -1 && islink(i, j))
                    {
                        colors_idx[C[j]] = true;
                    }
                int idx = 0;
                while (colors_idx[idx] == true)
                    idx++;
                C[i] = idx;
            }
            for (int i = 0; i < vertices.Count; i++)
                vertices[i].fill_color = colors[C[i]];
        }

        public void draw(Graphics handler)
        {
            foreach (Edge e in edges)
                e.draw(handler);
            foreach (Vertice v in vertices)
                v.draw(handler);
        }
    }
}
