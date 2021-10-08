using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_1
{
    class PointsCollection
    {
        myPoint[] p;
        public PointsCollection(int n)
        {
            p = new myPoint[n]; // initializat doar vectorul de puncte
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new myPoint(Engine.getRNDPoint()); // fiecare obiect se initializeaza
                p[i].setColor(Engine.getRNDColor(), Engine.getRNDColor());
            }
        }

        public PointsCollection(string fileName, bool hasnoofPoints)
        {
            TextReader load = new StreamReader(fileName);
            if (hasnoofPoints)
            {
                int n = int.Parse(load.ReadLine());
                p = new myPoint[n];
                for (int i = 0; i < p.Length; i++)
                {
                    string[] buffer = (load.ReadLine()).Split(' ');
                    p[i] = new myPoint(new System.Drawing.PointF(float.Parse(buffer[0]), float.Parse(buffer[1])));
                }
            }
            {
                List<string> data = new List<string>();
                string buffer;
                while ((buffer = load.ReadLine()) != null)
                    data.Add(buffer);
                p = new myPoint[data.Count];
                for (int i = 0; i < p.Length; i++)
                {
                    string[] localData = data[i].Split(' ');
                    p[i] = new myPoint(new System.Drawing.PointF(float.Parse(localData[0]), float.Parse(localData[1])));
                }
            }
        }

        public void draw()
        {
            for (int i = 0; i < p.Length; i++)
                p[i].draw(Engine.grp);
            Engine.RefreshGraph();
        }
    }
}
