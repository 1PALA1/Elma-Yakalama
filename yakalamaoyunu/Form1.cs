using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yakalamaoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int X_sepet = 0, Y_sepet = 0;
        int X_elma = 0, Y_elma = 0;
        int toplama = 0;
        int elmahizi=5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            tekrarbuton.Visible= false;
            Y_elma = Y_elma + elmahizi;
            

            elmapic.Location = new Point(X_elma,Y_elma);

            Random random = new Random();

            if (X_sepet < X_elma + 30 && X_sepet + 120 > X_elma && Y_sepet < Y_elma + 30)
            {
                X_elma = random.Next(0, 400);
                Y_elma = 0;
                toplama++;
                labelhak.Text = "TOPLAM ELMA = " + toplama;
                if (timer1.Interval > 10)
                {
                    timer1.Interval = timer1.Interval - 3;
                }
            }
            else if (Y_elma + 10 > 320) 
            {
                Y_elma = 0;
                timer1.Enabled= false;
                tekrarbuton.Visible = true;

            } 

                

        }

        private void labelhak_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toplama = 0;
            labelhak.Text = "TOPLAM ELMA = " + toplama;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;

            X_sepet = X;
            Y_sepet = 300;

            sepetpic.Location=new Point(X_sepet, Y_sepet);

        }
    }
}
