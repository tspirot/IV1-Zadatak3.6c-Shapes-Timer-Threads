using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak3._6c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osnovniObliciZadatak1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZadatak1 zad1 = new FormZadatak1();
            zad1.MdiParent = this;
            zad1.Show();
        }

        private void animacijeTajmerZadatak2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZadatak2 zad2 = new FormZadatak2();
            zad2.MdiParent = this;
            zad2.Show();
        }

        private void animacijeNitiZadatak3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZadatak3 zad3 = new FormZadatak3();
            zad3.MdiParent = this;
            zad3.Show();
        }
    }
}
