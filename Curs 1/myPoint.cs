using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Curs_1
{
    public class myPoint
    {
        static int radius = 5;
        float X, Y;
        Pen draw_;
        SolidBrush fill_;

        public myPoint(PointF A)
        {
            X = A.X;
            Y = A.Y;
            draw_ = new Pen(Color.Black);
            fill_ = new SolidBrush(Color.White);
        }

        public void setColor(Color drawColor, Color fillColor)
        {
            draw_ = new Pen(drawColor);
            fill_ = new SolidBrush(fillColor);
        }

        public void draw(Graphics grp)
        {
            grp.DrawEllipse(draw_, X - radius, Y - radius, 2 * radius + 1, 2 * radius + 1);
            grp.FillEllipse(fill_, X - radius, Y - radius, 2 * radius + 1, 2 * radius + 1);
        }
    }
}
