

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inicio_principal;
using inicio_de_sesion_1;
using registro_nuevo;
using pmc_burger;

namespace inicio_principal
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            registro frm = new registro();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
