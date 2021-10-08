using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_1
{
    public static partial class Engine //tine de grafic, chestii random, etc
    {
        public static Random rnd = new Random();
        public static System.Drawing.Graphics grp;
        public static System.Drawing.Bitmap bmp;
        public static System.Drawing.Color backColor = System.Drawing.Color.Aquamarine;

        public static int rezx, rezy;
        public static System.Windows.Forms.PictureBox display;
        public static void InitGraph(System.Windows.Forms.PictureBox T)
        {
            display = T;
            rezx = T.Width;
            rezy = T.Height;
            bmp = new System.Drawing.Bitmap(rezx, rezy);
            grp = System.Drawing.Graphics.FromImage(bmp);
            center = new System.Drawing.PointF(Engine.rezx / 2, Engine.rezy / 2);
            ClearGraph();
            RefreshGraph();
        }
        public static void ClearGraph()
        {
            grp.Clear(backColor);
        }
        public static void RefreshGraph()
        {
            display.Image = bmp;
        }
        public static System.Drawing.PointF getRNDPoint()
        {
            return new System.Drawing.PointF(rnd.Next(rezx), rnd.Next(rezy));
        }
        public static float getRNDAngle()
        {
            return (float)(rnd.NextDouble() * (Math.PI * 2));
        }
        public static System.Drawing.Color getRNDColor()
        {
            return System.Drawing.Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        public static float dEuclid(System.Drawing.PointF A, System.Drawing.PointF B)
        {
            return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
        public static float dManhatten(System.Drawing.PointF A, System.Drawing.PointF B)
        {
            return (float)(Math.Abs(A.X - B.X) + Math.Abs(A.Y - B.Y));
        }
        public static float dCebasey(System.Drawing.PointF A, System.Drawing.PointF B)
        {
            float dX = Math.Abs(A.X - B.X);
            float dY = Math.Abs(A.Y - B.Y);
            if (dX > dY)
                return dX;
            return dY;
        }
        public static System.Drawing.PointF center;
    }
}
