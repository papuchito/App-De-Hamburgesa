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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            this.Hide();


            registro frm = new registro();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Hide();


            login frm = new login();
            frm.Show();
        }
    }
}
