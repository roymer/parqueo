using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parqueo.Views
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.Text = String.Concat("Bienvenido", " - ", App.app._name);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            boleta frm2 = new boleta();

            frm2.Show();
        }
    }
}
