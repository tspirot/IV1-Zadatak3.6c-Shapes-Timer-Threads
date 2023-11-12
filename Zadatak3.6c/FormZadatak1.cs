using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak3._6c
{
    public partial class FormZadatak1 : Form
    {
        int x, y, r = 10;

        private void FormZadatak1_Load(object sender, EventArgs e)
        {
            x = pictureBox1.Width / 2;
            y = pictureBox1.Height / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point[] tacke = new Point[4];
            tacke[0] = new Point(pictureBox1.Width / 2, 0);
            tacke[1] = new Point(pictureBox1.Width, pictureBox1.Height / 2);
            tacke[2] = new Point(pictureBox1.Width / 2, pictureBox1.Height);
            tacke[3] = new Point(0, pictureBox1.Height / 2);
            Graphics gr = pictureBox1.CreateGraphics();
            gr.DrawPolygon(new Pen(Color.Blue, 3), tacke);
        }

        public FormZadatak1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            while (true)
            {
                gr.DrawEllipse(new Pen(Color.Red, 3),
                    x - r, y - r, 2 * r, 2 * r);
                r += 10;
                Thread.Sleep(100);
                if(r>=pictureBox1.Width/2 || 
                    r >= pictureBox1.Height / 2)
                {
                    return;
                    //gr.Clear(Color.White);
                    //r = 10;
                }    
            }
        }
    }
}
