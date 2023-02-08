using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio_nuevo
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro exitoso");
            MessageBox.Show("Ahora Inicie Sesion");
            this.Hide();


            inicio frm = new inicio();
            frm.Show();
        }
    }
}
