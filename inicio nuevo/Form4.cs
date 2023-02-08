using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmc_burger
{
    public partial class pmc : Form
    {
        public pmc()
        {
            InitializeComponent();
            slidepanel.Height = home.Height;
            slidepanel.Top = home.Top;
            primercontrol1.BringToFront();
        }
        //bool vai = false;

        int m, mx, my;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = home.Height;
            slidepanel.Top = home.Top;
            primercontrol1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
            slidepanel.Top = home.Top;
            menu1.BringToFront();
        }

        private void combos_Click(object sender, EventArgs e)
        {
            slidepanel.Height = combos.Height;
            slidepanel.Top = combos.Top;
            combos1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidepanel.Height = delivery1.Height;
            slidepanel.Top = delivery1.Top;
           delivery1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            slidepanel.Height = pagos1.Height;
            slidepanel.Top = pagos1.Top;
            pagos1.BringToFront();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pagos1_Load(object sender, EventArgs e)
        {
           

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //  vai = true;

            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sigueme como Papuchitomc1");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sigueme como Papuchitomc1");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sigueme como Papuchitomc1");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tienes notificaciones ");
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            /* if (vai == true) 
            {

                this.Location = Cursor.Position;

            }*/


            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // vai = false;

            m = 0;
        }
    }
}
