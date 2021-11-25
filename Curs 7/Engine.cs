using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_7
{
    class Engine
    {
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static Color backColor = Color.LightBlue;

        public static void init_graph(PictureBox _display)
        {
            display = _display;
            bmp = new Bitmap(display.Width, display.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(backColor);
            display.Image = bmp;
        }

        public static void refresh()
        {
            display.Image = bmp;
        }
    }
}
