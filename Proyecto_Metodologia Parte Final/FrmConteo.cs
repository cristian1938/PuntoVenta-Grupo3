using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Metodologia
{
    public partial class FrmConteo : Form
    {

        public float dataConteo = 0;
        public FrmConteo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dataConteo = float.Parse(lbTotal.Text);
            Close();
        }
        public float obtenerdatos()
        {
            return dataConteo;
        }

        private void tb200_TextChanged(object sender, EventArgs e)
        {
            double cn = tb200.Text == "" ? 0 : double.Parse(tb200.Text);
            lb200.Text = (cn * 200).ToString();
            total();
        }

        private void tb100_TextChanged(object sender, EventArgs e)
        {
            double cn = tb100.Text == "" ? 0 : double.Parse(tb100.Text);
            lb100.Text = (cn * 100).ToString();
            total();
        }

private void tb50_TextChanged(object sender, EventArgs e)
        {
            double cn = tb50.Text == "" ? 0 : double.Parse(tb50.Text);
            lb50.Text = (cn * 50).ToString();
            total();
        }

        private void tb20_TextChanged(object sender, EventArgs e)
        {
            double cn = tb20.Text == "" ? 0 : double.Parse(tb20.Text);
            lb20.Text = (cn * 20).ToString();
            total();
        }

        private void tb10_TextChanged(object sender, EventArgs e)
        {
            double cn = tb10.Text == "" ? 0 : double.Parse(tb10.Text);
            lb10.Text = (cn * 10).ToString();
            total();
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            double cn = tb5.Text == "" ? 0 : double.Parse(tb5.Text);
            lb5.Text = (cn * 5).ToString();
            total();
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            double cn = tb2.Text == "" ? 0 : double.Parse(tb2.Text);
            lb2.Text = (cn * 2).ToString();
            total();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            double cn = tb1.Text == "" ? 0 : double.Parse(tb1.Text);
            lb1.Text = (cn * 1).ToString();
            total();
        }

        private void tbp50_TextChanged(object sender, EventArgs e)
        {
            double cn = tbp50.Text == "" ? 0 : double.Parse(tbp50.Text);
            lbp50.Text = (cn * 0.50).ToString();
            total();
        }

        private void tbp20_TextChanged(object sender, EventArgs e)
        {
            double cn = tbp20.Text == "" ? 0 : double.Parse(tbp20.Text);
            lbp20.Text = (cn * 0.20).ToString();
            total();
        }

        private void tbp10_TextChanged(object sender, EventArgs e)
        {
            double cn = tbp10.Text == "" ? 0 : double.Parse(tbp10.Text);
            lbp10.Text = (cn * 0.10).ToString();
            total();
        }
        public double total()
        {
            double total;

            double cm = (tbp10.Text != "") ? double.Parse(lbp10.Text) : 0;
            double cm2 = (tbp20.Text != "") ? double.Parse(lbp20.Text) : 0;
            double cm3 = (tbp50.Text != "") ? double.Parse(lbp50.Text) : 0;
            double cm4 = (tb1.Text != "") ? double.Parse(lb1.Text) : 0;
            double cm5 = (tb2.Text != "") ? double.Parse(lb2.Text) : 0;
            double cm6 = (tb5.Text != "") ? double.Parse(lb5.Text) : 0;
            double cm7 = (tb10.Text != "") ? double.Parse(lb10.Text) : 0;
            double cm8 = (tb20.Text != "") ? double.Parse(lb20.Text) : 0;
            double cm9 = (tb50.Text != "") ? double.Parse(lb50.Text) : 0;
            double cm10 = (tb100.Text != "") ? double.Parse(lb100.Text) : 0;
            double cm11 = (tb200.Text != "") ? double.Parse(lb200.Text) : 0;
            total = cm + cm2 + cm3 + cm4 + cm5 + cm6 + cm7 + cm8 + cm9 + cm10 + cm11;

            lbTotal.Text = total.ToString();
            return total;
        }

    }
}
