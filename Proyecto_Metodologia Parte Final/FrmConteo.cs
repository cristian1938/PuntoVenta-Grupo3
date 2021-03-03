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
            try
            {
                if (tb200.Text != "")
                {
                    double c200 = double.Parse(tb200.Text);
                    lb200.Text = (c200 * 200).ToString();

                }

                total();
            }
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
       
           
        }

        private void tb100_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb100.Text != "")
            {
                double c100 = double.Parse(tb100.Text);
                lb100.Text = (c100 * 100).ToString();
            }
            total();
        }
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }

}

private void tb50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb50.Text != "")
            {
                double cm = double.Parse(tb50.Text);
                lb50.Text = (cm * 50).ToString();
                total();
            }
            
            }
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb20.Text != "")
            {
                double cm = double.Parse(tb20.Text);
                lb20.Text = (cm * 20).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb10.Text != "")
            {
                double cm = double.Parse(tb10.Text);
                lb10.Text = (cm * 10).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb5.Text != "")
            {
                double cm = double.Parse(tb5.Text);
                lb5.Text = (cm * 5).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb2.Text != "")
            {
                double cm = double.Parse(tb2.Text);
                lb2.Text = (cm * 2).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb1.Text != "")
            {
                double cm = double.Parse(tb1.Text);
                lb1.Text = (cm).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tbp50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbp50.Text != "")
            {
                double cm = double.Parse(tbp50.Text);
                lbp50.Text = (cm * 0.50).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tbp20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbp20.Text != "")
            {
                double cm = double.Parse(tbp20.Text);
                lbp20.Text = (cm * 0.20).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tbp10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbp10.Text != "")
            {
                double cm = double.Parse(tbp10.Text);
                lbp10.Text = (cm * 0.10).ToString();
            }
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }
        public double total()
        {
            double total = 0;
            if (tb200.Text != "" && tb200.Text != "" && tb100.Text != "" && tb50.Text != "" && tb20.Text != "" 
                && tb10.Text != "" && tb5.Text != "" && tb2.Text != "" && tb1.Text != "" && tbp50.Text!="" && tbp20.Text != ""
                && tbp10.Text != "")
            {
                
                double cm = double.Parse(lbp10.Text);
                double cm2 = double.Parse(lbp20.Text);
                double cm3 = double.Parse(lbp50.Text);
                double cm4 = double.Parse(lb1.Text);
                double cm5 = double.Parse(lb2.Text);
                double cm6 = double.Parse(lb5.Text);
                double cm7 = double.Parse(lb10.Text);
                double cm8 = double.Parse(lb20.Text);
                double cm9 = double.Parse(lb50.Text);
                double cm10 = double.Parse(lb100.Text);
                double cm11 = double.Parse(lb200.Text);
                total = cm + cm2 + cm3 + cm4 + cm5 + cm6 + cm7 + cm8 + cm9 + cm10 + cm11;
                lbTotal.Text = total.ToString();
            }
            else
            {
                total = 0;
            }
            return total;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
