using parqueo.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parqueo.Views
{
    public partial class frmLogin : frmPatron
    {
        UserControllers userControllers = new UserControllers();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = userControllers.Login(txtAccount.Text, txtPassword.Text);

            if (usersBindingSource.Count > 0)
            {
                frmMenu menu = new frmMenu();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBrowser();
        }

        private void configuraionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tamanoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.tamanoCompletoToolStripMenuItem.Visible = false;
            this.salirTamanoCompletoToolStripMenuItem.Visible = true;
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = new Version();
            version.Show();
        }

        private void salirTamanoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.tamanoCompletoToolStripMenuItem.Visible = true;
            this.salirTamanoCompletoToolStripMenuItem.Visible = false;
        }

        private void OpenBrowser()
        {
            bool processStarted = false;

            Process[] processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.MainWindowTitle.Equals("Google - Google Chrome", StringComparison.OrdinalIgnoreCase))
                {
                    processStarted = true;
                    break;
                }
            }

            if (!processStarted)
            {
                Process p = new Process();
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "chrome.exe";
                p.StartInfo = info;
                info.Arguments = "https://www.google.com/webhp?q=ayuda+con+parqueo";
                p.Start();
            }
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
