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
    public partial class boleta : Form

    {
        bool _isNew = false;
        public boleta()
        {
            _isNew = true;
            InitializeComponent();
        }

        private void boleta_Load(object sender, EventArgs e)
        {
            if (_isNew)
            {
                boletaPago1BindingSource.AddNew();

            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var reg = addData();
           
        }

        private boletaPago1 addData()
        {
            var reg = (boletaPago1)boletaPago1BindingSource.Current;
            return reg;
        }
    }

    internal class boletaPago1
    {
    }
}
