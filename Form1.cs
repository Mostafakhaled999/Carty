using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carty
{
    public partial class Form1 : Form
    {
       private bool searchh = false;
     
        public Form1()
        {
            InitializeComponent();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void navigation2_Click(object sender, EventArgs e)
        {

            lSidemenu.Width = 58;
            navigation1.Visible = true;
            logolabel2.Visible = true;
            logopic2.Visible = true;
            toppanel.Width = 1;
            

        }

        private void navigation1_Click(object sender, EventArgs e)
        {
           
                lSidemenu.Width = 266;
                navigation1.Visible = false;
            logolabel2.Visible = false;
            logopic2.Visible = false;
            
        }

        private void search_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchh==false)
            {
                search.Text = " ";
                searchh = true;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void signup_Click(object sender, EventArgs e)
        {
            //Signup form = new Signup();
            //form.Show();
            //this.Hide();
        }
    }
}
