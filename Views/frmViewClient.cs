namespace parqueo.Views
{
    using parqueo.Controllers;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class frmViewClient : Form
    {
        ClientController clientControllers = new ClientController();

        public frmViewClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            int number;

            bool success = Int32.TryParse(this.textBox1.Text, out number);
            if (success)
            {
                
                var client = clientControllers.SearchClient(number);

                if (client != null)
                {
                    this.textBox2.Text = client.FullName;
                    this.textBox3.Text = client.Phone;
                    this.textBox4.Text = client.Address;
                    this.textBox5.Text = client.Email;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("CI debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCreateClient createClient = new frmCreateClient();
            this.Hide();
            createClient.ShowDialog();
        }
    }
}
