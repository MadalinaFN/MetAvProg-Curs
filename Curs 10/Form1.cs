using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.init_graph(pictureBox1);
            Engine.load(@"..\..\g.txt");

            for (int i = 0; i < Engine.n; i++)
            {
                string buffer = "";
                for (int j = 0; j < Engine.n; j++)
                    buffer += Engine.ma[i, j] + " ";
                listBox1.Items.Add(buffer);
            }
            Engine.draw();
        }
    }
}
