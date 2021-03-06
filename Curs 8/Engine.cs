using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_8
{
    class Engine
    {
        public static Bitmap image;
        public static Graphics graphics;
        public static PictureBox pictureBox;
        public static Color backColor = Color.LightBlue;

        public static void init_graph(PictureBox pictureBox)
        {
            Engine.pictureBox = pictureBox;
            image = new Bitmap(Engine.pictureBox.Width, Engine.pictureBox.Height);
            graphics = Graphics.FromImage(image);
            graphics.Clear(backColor);
            Engine.pictureBox.Image = image;
        }

        public static void refresh()
        {
            pictureBox.Image = image;
        }
    }
}
