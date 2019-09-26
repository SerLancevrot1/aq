using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Point tmp_location;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            
            
            int w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

            if (e.X >125   && e.X <260  && e.Y >190  && e.Y <270  )
            {
                tmp_location = this.Location;
                tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);
                if (tmp_location.X < 0 || tmp_location.X > (w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (h - this.Height / 2))
                {
                    tmp_location.X = w / 2;
                    tmp_location.Y = h / 2;
                }
                    this.Location = tmp_location;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СукаШлюха , СукаСукаШлюха!");
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я не сомневался", "ооооу мааай", MessageBoxButtons.OK , MessageBoxIcon.Information);
          
        }
    }
}
