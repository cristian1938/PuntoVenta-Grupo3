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
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private void tb200_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
          
       
           
=======
            double cn = tb200.Text == "" || !IsNumeric(tb200.Text) ? 0 : double.Parse(tb200.Text);
            lb200.Text = (cn * 200).ToString();
            total();
>>>>>>> j-branch
        }

        private void tb100_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tb100.Text != "")
            {
                double c100 = double.Parse(tb100.Text);
                lb100.Text = (c100 * 100).ToString();
            }
=======
            double cn = tb100.Text == "" || !IsNumeric(tb100.Text) ? 0 : double.Parse(tb100.Text);
            lb100.Text = (cn * 100).ToString();
>>>>>>> j-branch
            total();
        }
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }

}

        private void tb50_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
          
=======
            double cn = tb50.Text == "" || !IsNumeric(tb50.Text) ? 0 : double.Parse(tb50.Text);
            lb50.Text = (cn * 50).ToString();
            total();
>>>>>>> j-branch
        }

        private void tb20_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tb20.Text != "")
            {
                double cm = double.Parse(tb20.Text);
                lb20.Text = (cm * 20).ToString();
            }
=======
            double cn = tb20.Text == "" || !IsNumeric(tb20.Text) ? 0 : double.Parse(tb20.Text);
            lb20.Text = (cn * 20).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb10_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tb10.Text != "")
            {
                double cm = double.Parse(tb10.Text);
                lb10.Text = (cm * 10).ToString();
            }
=======
            double cn = tb10.Text == "" || !IsNumeric(tb10.Text) ? 0 : double.Parse(tb10.Text);
            lb10.Text = (cn * 10).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tb5.Text != "")
            {
                double cm = double.Parse(tb5.Text);
                lb5.Text = (cm * 5).ToString();
            }
=======
            double cn = tb5.Text == "" || !IsNumeric(tb5.Text) ? 0 : double.Parse(tb5.Text);
            lb5.Text = (cn * 5).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tb2.Text != "")
            {
                double cm = double.Parse(tb2.Text);
                lb2.Text = (cm * 2).ToString();
            }
=======
            double cn = tb2.Text == "" || !IsNumeric(tb2.Text) ? 0 : double.Parse(tb2.Text);
            lb2.Text = (cn * 2).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tb1.Text != "")
            {
                double cm = double.Parse(tb1.Text);
                lb1.Text = (cm).ToString();
            }
=======
            double cn = tb1.Text == "" || !IsNumeric(tb1.Text) ? 0 : double.Parse(tb1.Text);
            lb1.Text = (cn * 1).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tbp50_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tbp50.Text != "")
            {
                double cm = double.Parse(tbp50.Text);
                lbp50.Text = (cm * 0.50).ToString();
            }
=======
            double cn = tbp50.Text == "" || !IsNumeric(tbp50.Text) ? 0 : double.Parse(tbp50.Text);
            lbp50.Text = (cn * 0.5).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tbp20_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tbp20.Text != "")
            {
                double cm = double.Parse(tbp20.Text);
                lbp20.Text = (cm * 0.20).ToString();
            }
=======
            double cn = tbp20.Text == "" || !IsNumeric(tbp20.Text) ? 0 : double.Parse(tbp20.Text);
            lbp20.Text = (cn * 0.2).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }

        private void tbp10_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                if (tbp10.Text != "")
            {
                double cm = double.Parse(tbp10.Text);
                lbp10.Text = (cm * 0.10).ToString();
            }
=======
            double cn = tbp10.Text == "" || !IsNumeric(tbp10.Text) ? 0 : double.Parse(tbp10.Text);
            lbp10.Text = (cn * 0.1).ToString();
>>>>>>> j-branch
            total();
}
            catch
            {
                MessageBox.Show("INGRESE UN NUMERO");
            }
          
        }
        public double total()
        {
<<<<<<< HEAD
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
=======
            double cm = lbp10.Text == "" || !IsNumeric(lbp10.Text) ? 0 : double.Parse(lbp10.Text);
            double cm2 = lbp20.Text == "" || !IsNumeric(lbp20.Text) ? 0 : double.Parse(lbp20.Text);
            double cm3 = lbp50.Text == "" || !IsNumeric(lbp50.Text) ? 0 : double.Parse(lbp50.Text);
            double cm4 = lb1.Text == "" || !IsNumeric(lb1.Text) ? 0 : double.Parse(lb1.Text);
            double cm5 = lb2.Text == "" || !IsNumeric(lb2.Text) ? 0 : double.Parse(lb2.Text);
            double cm6 = lb5.Text == "" || !IsNumeric(lb5.Text) ? 0 : double.Parse(lb5.Text);
            double cm7 = lb10.Text == "" || !IsNumeric(lb10.Text) ? 0 : double.Parse(lb10.Text);
            double cm8 = lb20.Text == "" || !IsNumeric(lb20.Text) ? 0 : double.Parse(lb20.Text);
            double cm9 = lb50.Text == "" || !IsNumeric(lb50.Text) ? 0 : double.Parse(lb50.Text);
            double cm10 = lb100.Text == "" || !IsNumeric(lb100.Text) ? 0 : double.Parse(lb100.Text);
            double cm11 = lb200.Text == "" || !IsNumeric(lb200.Text) ? 0 : double.Parse(lb200.Text);
            double total = cm + cm2 + cm3 + cm4 + cm5 + cm6 + cm7 + cm8 + cm9 + cm10 + cm11;
            lbTotal.Text = total.ToString();
>>>>>>> j-branch
            return total;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
