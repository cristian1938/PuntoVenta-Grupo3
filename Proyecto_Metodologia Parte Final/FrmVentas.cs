using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Proyecto_Metodologia
{
    
    public partial class FrmVentas : Form
    {
        private DataSet aDatos;
        public FrmVentas()
        {
            InitializeComponent();
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmProductos a = new FrmProductos();
            a.ShowDialog();
           string []b= a.obtenerdatos();
            if (a.DatosT[0]!=null)
            {
                txtcodp.Text = b[0];
                txtnombre.Text = a.DatosT[1];
                txtpreciou.Text = a.DatosT[2];
                txtStock.Text = a.DatosT[3];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int actualizar = int.Parse(txtStock.Text)-(int)nupcantidad.Value;
            double preciounidad = double.Parse(txtpreciou.Text);
            double total = (int)nupcantidad.Value*preciounidad;
            dgvVentas.Rows.Add(txtcodp.Text,txtnombre.Text,nupcantidad.Value.ToString(),total.ToString());
            actualizarstock(actualizar,txtcodp.Text);
            clear();
        }
        public void clear()
        {
            txtcodp.Text = "";
            txtnombre.Text = "";
            txtpreciou.Text = "";
            txtStock.Text = "";
            nupcantidad.Value = 1;
        }

        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
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
        public void actualizarstock(int cantidad, string codproducto)
        {
            string Consulta = "update TProductos set Stock =" + cantidad + " where CodigoProducto='" + codproducto + "'";

            EjecutarSelect(Consulta);
        }
    }
}
