using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public ServiceReference1.Service1Client proxy;

        public ServiceReference1.Klijent klijent;

        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceReference1.Service1Client();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            klijent = proxy.LogIn(txtIme.Text, txtPrezime.Text);

            if (klijent != null)
            {
                var frm = new Form2(klijent);
                DialogResult dlg = frm.ShowDialog();
            }
        }
    }
}
