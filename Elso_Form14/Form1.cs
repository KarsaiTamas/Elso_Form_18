using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elso_Form14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Förm cím";
            this.button1.Text = "Gombfelirat";
            this.dateTimePicker1.Value = DateTime.Now;
             
            this.toolTip1.SetToolTip(this.button1, "Növeli a poggers bárt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value<100)
            {
                progressBar1.Value+=4;
            }
            if (progressBar1.Value==100)
            {
                progressBar1.Value=0;
            }
            
        }private static int a=-1;
        private static int b=-1;

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            int i = this.label1.Location.X;
            int j = this.label1.Location.Y;
            if (a==-1)
            {
                a = 0;
            }
            if (b==-1)
            {
                b = 0;
            }

            this.label1.Location = new System.Drawing.Point(i, j);
            if (this.label1.Location.X == 0)
            {
                a = 0;
            }else if(this.label1.Location.X == 350)
            {
                a = 1;
            }
            if (this.label1.Location.Y == 0)
            {
                b = 0;
            }else if(this.label1.Location.Y == 250)
            {
                b = 1;
            }
            if (a==0)
            {
                i++;
            }else if (a == 1)
            {
                i--;
            }
            if (b==0)
            {
                j++;
            }else if (b == 1)
            {
                j--;
            }
            this.label1.Location = new System.Drawing.Point(i, j);


        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            int i = this.label1.Location.X;
            int j = this.label1.Location.Y;
            if (a == -1)
            {
                a = 0;
            }
            if (b == -1)
            {
                b = 0;
            }

            this.label1.Location = new System.Drawing.Point(i, j);
            if (this.label1.Location.X == 0)
            {
                a = 0;
            }
            else if (this.label1.Location.X == 350)
            {
                a = 1;
            }
            if (this.label1.Location.Y == 0)
            {
                b = 0;
            }
            else if (this.label1.Location.Y == 250)
            {
                b = 1;
            }
            if (a == 0)
            {
                i++;
            }
            else if (a == 1)
            {
                i--;
            }
            if (b == 0)
            {
                j++;
            }
            else if (b == 1)
            {
                j--;
            }
            this.label1.Location = new System.Drawing.Point(i, j);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            int i = this.label1.Location.X;
            int j = this.label1.Location.Y;
            if (a == -1)
            {
                a = 0;
            }
            if (b == -1)
            {
                b = 0;
            }

            
            if (this.label1.Location.X == 0)
            {
                a = 0;
            }
            else if (this.label1.Location.X == 350)
            {
                a = 1;
            }
            if (this.label1.Location.Y == 0)
            {
                b = 0;
            }
            else if (this.label1.Location.Y == 250)
            {
                b = 1;
            }
            if (a == 0)
            {
                i++;
            }
            else if (a == 1)
            {
                i--;
            }
            if (b == 0)
            {
                j++;
            }
            else if (b == 1)
            {
                j--;
            }
            this.label1.Location = new System.Drawing.Point(i, j);
        }
    }
}
