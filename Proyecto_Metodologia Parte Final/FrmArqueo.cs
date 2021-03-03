using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Metodologia
{
    public partial class FrmArqueo : Form
    {
        private DataSet aDatos;
        public FrmArqueo()
        {
            InitializeComponent();
        }

        private void btnConteo_Click(object sender, EventArgs e)
        {
            FrmConteo c = new FrmConteo();
            c.ShowDialog();
            float b = c.obtenerdatos();
            if (b != 0)
            {
                txtconteo.Text = b.ToString();
            }
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT

            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;" +
               "Initial Catalog=BDSISTEMA_VENTAS;Integrated Security=SSPI;"))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand(pConsulta, conexion)) ;
                a.SelectCommand = new SqlCommand(pConsulta, conexion);
                aDatos = new DataSet();
                // aAdaptador.Fill(aDatos);
                a.Fill(aDatos);
                conexion.Close();
            }
            return aDatos;
        }
        public string ValorAtributo(string pNombreCampo)
        {//-- Recupera el valor de un atributo del dataset
            if (Datos.Tables[0].Rows.Count > 0)
            {
                return Datos.Tables[0].Rows[0][pNombreCampo].ToString();
            }
            else
                return "";
        }
        private void dateTimeArqueo_ValueChanged(object sender, EventArgs e)
        {
           dgventas.DataSource= validarfecha();
            dgventas.Columns["CodVenta"].Width = 150;
            dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            dgventas.Columns["PrecioTotal"].Width = 160;
            dgventas.Columns["Fecha"].Width = 180;
            total();
        }
        public DataTable validarfecha()
        {
            string Consulta = "SELECT * FROM TVentas WHERE Fecha = '" +dateTimeArqueo.Value.ToShortDateString()  + "'";
          
            EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }
        public void total()
        {
            int i = 0;
            float total = 0;
            float sub = 0;
            while (i<dgventas.RowCount)
            {
                sub = float.Parse(dgventas[1, i].Value.ToString());
                total = total + sub;
                i++;
            }
            txttotal.Text = total.ToString();
        }

        private void txtconteo_TextChanged(object sender, EventArgs e)
        {
            if(txttotal.Text!="" && txtconteo.Text != "")
            {
                lbDiferencia.Text = (double.Parse(txttotal.Text) - double.Parse(txtconteo.Text)).ToString();
            }
        }
    }
}
