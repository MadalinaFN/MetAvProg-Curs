using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graph g;

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.init_graph(pictureBox1);

            g = new Graph();
            g.load("graph_demo.txt");
            g.color();
            g.draw(Engine.grp);

            Engine.refresh();
        }
    }
}
