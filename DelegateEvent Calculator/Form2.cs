using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateEvent_Calculator
{
    public partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(Calculator klk);
        public event Form2.CreateUpdateEventHandler OnCreate;
        private Calculator klk;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            klk = new Calculator();
            klk.nama = this.cmbOperasi.Text.ToLower();
            klk.operasi = string.Empty;
            klk.hasils = 0;
            klk.a = Double.Parse(this.txtNilaiA.Text);
            klk.b = Double.Parse(this.txtNilaiB.Text);


            if (this.cmbOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan Pilih Dulu Operasinya!!!");
            }
            else if (this.cmbOperasi.SelectedIndex == 0)
            {
                klk.hasils = klk.a + klk.b;
                klk.operasi = "+";

            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                klk.hasils = klk.a - klk.b;
                klk.operasi = "-";
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                klk.hasils = klk.a * klk.b;
                klk.operasi = "*";
            }
            else if (this.cmbOperasi.SelectedIndex == 3)
            {
                klk.hasils = klk.a / klk.b;
                klk.operasi = "/";
            }

            this.OnCreate(klk);

        }
    }
}
