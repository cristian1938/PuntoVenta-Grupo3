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
    public partial class Form1 : Form
    {
        protected cEntidad aEntidad;
        public string usuario;
        //------------------------------------------

        public void IniciarEntidad(cEntidad pEntidad)
        {//Indicar con que entidad trabajará el formulario
            aEntidad = pEntidad;
        }


        public Form1()
        {
            InitializeComponent();
           
            IniciarEntidad(new cUsuario());
        }

        public void logins()
        {
            try
            {
               
                using (SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-0UCG48C\SQLEXPRESS;" +
                "Initial Catalog=BDSISTEMA_VENTAS;Integrated Security=SSPI;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * from TUsuarios  WHERE TUsuarios.Usuario='" + txtusuario.Text + "' AND TUsuarios.Contraseña='" + txtcontraseña.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                            obtenerusuario();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public string obtenerusuario()
        {
            usuario = txtusuario.Text;
            return usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logins();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            Form a = new FrmRegistro();
            a.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
