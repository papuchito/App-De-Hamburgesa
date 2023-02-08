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
    public partial class pagos : UserControl
    {
        public pagos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago Procesado Con Exito");
            MessageBox.Show("Su orden tiene un tiempo de espera de 15 a 20 minutos");
            MessageBox.Show("Gracias Por preferirnos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primercontrol frm = new primercontrol();
            MessageBox.Show("Pago Cancelado");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los codigos que estan detras de su tarjeta");
        }
    }
}
