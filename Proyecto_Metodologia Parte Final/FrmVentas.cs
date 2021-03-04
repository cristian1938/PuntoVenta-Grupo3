﻿using System;
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
            autoincrementable();
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmProductos a = new FrmProductos();
            a.ShowDialog();
            string[] b = a.obtenerdatos();
            if (a.DatosT[0] != null)
            {
                txtcodp.Text = b[0];
                txtnombre.Text = a.DatosT[1];
                txtpreciou.Text = a.DatosT[2];
                txtStock.Text = a.DatosT[3];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int actualizar = int.Parse(txtStock.Text) - (int)nupcantidad.Value;
                double preciounidad = double.Parse(txtpreciou.Text);
                double total = (int)nupcantidad.Value * preciounidad;
                dgvVentas.Rows.Add(txtcodp.Text, txtnombre.Text, nupcantidad.Value.ToString(), total.ToString());
                actualizarstock(actualizar, txtcodp.Text);
                calculartotal();

                clear();

            }
            catch
            {
                MessageBox.Show("INGRESA UN PRODUCTO");
            }

        }
        public void clear()
        {
            txtcodp.Text = "";
            txtnombre.Text = "";
            txtpreciou.Text = "";
            txtStock.Text = "";
            nupcantidad.Value = 1;

        }

        public void limpiarventa()
        {
            txtsubtotal.Text = "";
            txtigv.Text = "";
            txttotal.Text = "";
        }
        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                // using (SqlCommand cmd = new SqlCommand(pConsulta, conexion)) ;
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int indice = dgvVentas.CurrentCell.RowIndex;

                txtnombre.Text = dgvVentas[2, indice].Value.ToString();
                int cantidad = int.Parse(dgvVentas[2, indice].Value.ToString());
                ////int  cantidad =(int) dgvVentas[2,indice].Value;
                string codprodcuto = dgvVentas[0, indice].Value.ToString();
                int rcantidad = int.Parse(buscarstock(codprodcuto));
                int actualizar = cantidad + rcantidad;
                actualizarstock(actualizar, codprodcuto);
                dgvVentas.Rows.RemoveAt(indice);
                calculartotal();
                clear();
            }
            catch
            {
                MessageBox.Show("LA LISTA DE VENTAS ESTA VACIA AGREGE PRODCUTOS");
            }
        }
        public string buscarstock(string pCodigoProducto)
        {
            string stock;
            string Consulta = "select Stock from TProductos where CodigoProducto='" + pCodigoProducto + "'";

            EjecutarSelect(Consulta);
            stock = ValorAtributo("Stock");
            return stock;
        }
        public string ultimoValorAtributo()
        {//-- Recupera el valor de un atributo del dataset
            string A;

            string Consulta = "select MAX(CodigoVenta) AS  ULTIMO  from TVentas";
            EjecutarSelect(Consulta);
            A = ValorAtributo("ULTIMO");
            if (A == "")
            {
                A = "E0000";
            }

            return A;
        }
        public void autoincrementable()
        {
            String A;
            //E0001
            A = ultimoValorAtributo();

            string b = A.Substring(0, 5);
            double d = double.Parse(A.Substring(1, 4));
            d = d + 1;
            if (d < 10)
            {
                b = A.Substring(0, 5);
                txtCodVentas.Text = b + d.ToString();
                txtCodVentas.Enabled = false;

            }
            if (d > 9)
            {
                b = A.Substring(0, 4);
                txtCodVentas.Text = b + d.ToString();
                txtCodVentas.Enabled = false;
            }
            if (d > 99)
            {
                b = A.Substring(0, 3);
                txtCodVentas.Text = b + d.ToString();
                txtCodVentas.Enabled = false;
            }
        }

        public void calculartotal()
        {
            double cantidad = 0;
            double subtotal = 0;
            double igv = 0;
            double ventatotal = 0;
            int i = 0;
            while (i < dgvVentas.RowCount)
            {
                cantidad = double.Parse(dgvVentas[3, i].Value.ToString());
                subtotal = subtotal + cantidad;
                i++;
            }
            igv = subtotal * (double)0.18;
            ventatotal = subtotal + igv;

            txtsubtotal.Text = subtotal.ToString();
            txtigv.Text = igv.ToString();
            txttotal.Text = ventatotal.ToString();
            if (dgvVentas.Rows.Count == 0)
            {
                txtsubtotal.Text = "0.00";
                txtigv.Text = "0.00";
                txttotal.Text = "0.00";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Consulta = "insert into TVentas values" + "('" + txtCodVentas.Text + "'," + txttotal.Text + ",'" + fechaventa.Value.ToShortDateString() + "', null)";

            EjecutarSelect(Consulta);
            limpiarventa();
            dgvVentas.Rows.Clear();
            autoincrementable();
            clear();
        }
    }
}