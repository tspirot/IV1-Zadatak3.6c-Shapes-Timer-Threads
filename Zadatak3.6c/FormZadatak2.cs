using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadatak3._6c
{
    public partial class FormZadatak2 : Form
    {
        int x = 0, y = 0, r = 10;
        public FormZadatak2()
        {
            InitializeComponent();
        }

        private void FormZadatak2_Load(object sender, EventArgs e)
        {
            x = ClientRectangle.Width / 2;
            y = ClientRectangle.Height / 2;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            crtajKrug(); // poziva eksplicitno OnPaint()
        }
    }
}
