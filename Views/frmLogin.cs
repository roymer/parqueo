﻿using parqueo.Controllers;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewClient vClient = new frmViewClient();
            vClient.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegVehycule newvehiculo= new frmRegVehycule();
            newvehiculo.ShowDialog();
        }
    }
}
