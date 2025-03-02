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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Username.Text == "Prog" && Txt_Passoerd.Text=="L4")
            {
                Frm_Dashboard mainform = new Frm_Dashboard();
                this.Hide();
                mainform.ShowDialog();
                
            }
            else
                {
                MessageBox.Show("Invalied Username or Password","Invaled User",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Visible == false)
            {
                label3.Text = Txt_Passoerd.Text;
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("Are you sure", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (X == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
