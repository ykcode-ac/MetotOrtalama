using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotOrtalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double OrtalamaHesapla(int n1,int n2,int n3)
        {
            return (n1+n2+n3)/3.0;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int not1 = Convert.ToInt32(txtNot1.Text);
                int not2 = Convert.ToInt32(txtNot2.Text);
                int not3 = Convert.ToInt32(txtNot3.Text);

                lblOrtalama.Text ="Ortalama: "+OrtalamaHesapla(not1, not2, not3).ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
