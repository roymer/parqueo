using parqueo.Controllers;
using parqueo.Models;
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
    public partial class frmCreateClient : Form
    {
        ClientController clientController = new ClientController();

        public frmCreateClient()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number;

            bool success = Int32.TryParse(this.textBox1.Text, out number);
            if (success)
            {

                ClientModel clientModel = new ClientModel()
                {
                    Name = this.textBox1.Text,
                    LastName = this.textBox2.Text,
                    Address = this.textBox4.Text,
                    CI = number,
                    Email = this.textBox6.Text,
                    Phone = this.textBox5.Text,
                };
                bool isSaved = false;
                isSaved = clientController.SaveClient(clientModel);
                if (isSaved)
                {
                    MessageBox.Show(string.Format("Cliente con[CI:{0}] guardado", number), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmViewClient viewClient = new frmViewClient();
                    this.Hide();
                    viewClient.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cliente no guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CI debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewClient viewClient = new frmViewClient();
            this.Hide();
            viewClient.ShowDialog();
        }
    }
}
