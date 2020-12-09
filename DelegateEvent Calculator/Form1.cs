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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.OnCreate += FrmEntry_OnCreate;
            f2.ShowDialog();

        }
        private void FrmEntry_OnCreate(Calculator klk)
        {
            lstboxHasil.Items.Add("Hasil " + klk.nama + " " + klk.a + " " + klk.operasi + " " + klk.b + " " + "=" + " " + klk.hasils);
        }
    }
}
