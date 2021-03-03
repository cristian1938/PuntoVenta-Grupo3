using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Metodologia
{
    class cConexion
    {
        public SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        public DataSet aDatos;
        //-------------CONSTRUCTOR---------------------
        public cConexion()
        {
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            string CadenaConexion = "Data Source=localhost;" +
                "Initial Catalog=BDSISTEMA_VENTAS;Integrated Security=SSPI;";
            aConexion = new SqlConnection(CadenaConexion);
        }
        //---------------PROPIEDADES----------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //-----------------SERVICIOS-----------------
        //-- Métodos para ejecutar comandos sql server
        //-- Devuelve el resultado en la tabla 0 del dataset
        public virtual DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        //-- Método para ejecutar instrucciones DML. No retorna resultado
        public virtual void EjecutarComando(string pComando)
        {//--Método para ejecutar consultas del tipo INSERT, UPDATE y DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();

            oComando.ExecuteNonQuery();
            aConexion.Close();
        }


    }
}
