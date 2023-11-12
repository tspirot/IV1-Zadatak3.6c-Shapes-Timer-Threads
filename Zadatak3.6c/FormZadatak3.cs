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
    public partial class FormZadatak3 : Form
    {
        int x = 0, y = 0, r = 10;
        public FormZadatak3()
        {
            InitializeComponent();
        }

        private void FormZadatak3_Load(object sender, EventArgs e)
        {
            x = ClientRectangle.Width / 2;
            y = ClientRectangle.Height / 2;
            Thread nit = new Thread(new ThreadStart(PokreniCrtanje));
            nit.Start();
        }
        protected void crtajKrug()
        {
            using (Graphics gr = CreateGraphics())
            {
                gr.DrawEllipse(new Pen(Color.Blue),
                    x - r, y - r, 2 * r, 2 * r);
                r += 10;
                if (r >= ClientRectangle.Width / 2 || r >= ClientRectangle.Height / 2)
                {
                    r = 10;
                    gr.Clear(SystemColors.Control);// brisanje krugova
                }
            }
        }
        private void PokreniCrtanje()
        {
            while(true) // beskonacna petlja
            {
                crtajKrug();
                Thread.Sleep(100); // pauza 0.1s
            }
        }
    }
}
