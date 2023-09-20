using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            osszeg = Convert.ToInt16(Sonka.Checked) * 1500
                + Convert.ToInt16(Kukorica.Checked) * 1200
                + Convert.ToInt16(Gomba.Checked) * 1400
                + Convert.ToInt16(Ketchup.Checked) * 50
                + Convert.ToInt16(Majonéz.Checked) * 50
                + Convert.ToInt16(Mustár.Checked) * 50
            +Convert.ToInt16(cm32.Checked) * 1200
            +Convert.ToInt16(cm46.Checked) * 2000
            +Convert.ToInt16(cm60.Checked) * 3000;
            fizet.Text=osszeg.ToString("C");
        }

        private void kave_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tea_CheckedChanged(object sender, EventArgs e)
        {
              
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("be akarod zárni?", "figyelem", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
               this.Close();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rendeles = nevtxt.Text;
            MessageBox.Show("felvettük a rendelését! " + "A következő címre: " + rendeles  );
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
