using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.Date.ToShortDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void Frm_Dashboard_Activated(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Date.ToShortDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
            if (toolStripProgressBar1.Value >= 1000)
            {
                toolStripProgressBar1.Value = 0;
            }
            else { toolStripProgressBar1.Value += 10; }
        }
    }
}
