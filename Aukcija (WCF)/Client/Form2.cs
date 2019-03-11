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
    public partial class Form2 : Form
    {
        public ServiceReference1.Service1Client proxy;

        public ServiceReference1.Eksponat eksponat;

        public ServiceReference1.Klijent klijent;

        public ServiceReference1.Eksponat[] eksponati;

        public int trenutniEksponat = 0;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ServiceReference1.Klijent klijent1)
        {
            InitializeComponent();

            klijent = klijent1;
            
            proxy = new ServiceReference1.Service1Client();
            eksponat = proxy.VratiPrviEksponat();
            eksponati = proxy.VratiEksponate();
            label2.Text = eksponat.Naziv + ", " + eksponat.Cena + ", " + eksponat.IdKlijenta;
        }

        private void button1_Click(object sender, EventArgs e)//dodaj ponudu
        {
            proxy.DodajPonudu(textBox1.Text, klijent, trenutniEksponat);

            
            trenutniEksponat++;
            eksponat = proxy.VratiTrenutniEksponat(trenutniEksponat);
            if (eksponat != null)
                label2.Text = eksponat.Naziv + ", " + eksponat.Cena + ", " + eksponat.IdKlijenta;
            else
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//odustani
        {
            trenutniEksponat++;
            eksponat = proxy.VratiTrenutniEksponat(trenutniEksponat);
            if (eksponat != null)
                label2.Text = eksponat.Naziv + ", " + eksponat.Cena + ", " + eksponat.IdKlijenta;
            else
                this.Close();
        }
    }
}
