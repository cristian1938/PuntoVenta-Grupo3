using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Proyecto_Metodologia
{
    public abstract class cEntidad
    {//----------------ATRIBUTOS----------------------
        private cConexion aConexion;
        private string aNombreTabla;
        string[] aNombres = null;//-- Valores de los campos de la tabla
        string[] aValores = null;//-- Valores de los campos de la tabla
        private bool aNuevo;
        //----------------Constructores-----------------
        public cEntidad(string pNombreTabla)
        {// Inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new cConexion();
            aNombres = NombresAtributos();
            aValores = null;
        }
        //---------PROPIEDADES--------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }
        //================Métodos de soporte de base de datos==============
        //-- Método abstracto encargado de establecer los nombres de los campos
        //-- (atributos) de la tabla. Se deben implementar necesariamente
        //-- en los herederos como arreglos de cadenas.
        //-- Estos atributos deben coincidir con los existentes en la base de datos 
        public abstract string[] NombresAtributos();
        public virtual void Insertar(params string[] Atributos)
        {//-- Permite insertar información de un registro en la tabla
            //Recuperar los valores de los atributos
            aValores = Atributos;
            //Formar la cadena de inserción 
            string CadenaInsertar = "insert into " + aNombreTabla + " values ('";
            for (int K = 0; K < aValores.Length; K++)
            {
                CadenaInsertar += aValores[K];
                if (K == aValores.Length - 1)
                {
                    CadenaInsertar += "')";
                }
                else
                {
                    CadenaInsertar += "', '";
                }
            }
            //Ejecutar la consulta para insertar el registro 
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;
        }
        public void Actualizar(params string[] Atributos)
        {// Permite actualizar la información de un registro de la tabla
            //Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;
            //Formar la cadena de actualización
            string CadenaActualizar = "update " + aNombreTabla + " set ";
            for (int K = 1; K < aValores.Length; K++)
            {
                CadenaActualizar += aNombres[K] + "= '" + aValores[K];
                if (K == aValores.Length - 1)
                {
                    CadenaActualizar += "'";
                }
                else
                {
                    CadenaActualizar += "', ";
                }
            }
            CadenaActualizar += " where " + aNombres[0] + "= '" + aValores[0] + "'";
            //Ejecutar la consulta para actualizar el registro
            aConexion.EjecutarComando(CadenaActualizar);
        }
        public void Eliminar(params string[] Atributos)
        {// Permite eliminar un registro
            //Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;
            string CadenaEliminar = "delete from " + aNombreTabla +
                " where " + aNombres[0] + "= '" + aValores[0] + "'";
            //Ejecutar la consulta para eliminar el registro
            aConexion.EjecutarComando(CadenaEliminar);
        }

        public bool ExisteClavePrimaria(params string[] Atributos)
        {//-- Verifica si un registro específico existe
            //-- Recuperar los nombres y valores de los atributos de la tabla.
            aNombres = NombresAtributos();
            aValores = Atributos;
            string CadenaConsulta = "select * from " + aNombreTabla +
                " where " + aNombres[0] + "= '" + aValores[0] + "'";
            //Ejecutar consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            //-- Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public DataTable Registro(params string[] Atributos)
        {//Recuperar la información del registro
            aNombres = NombresAtributos();
            aValores = Atributos;
            string CadenaConsulta = "select * from " + aNombreTabla +
                " where " + aNombres[0] + "= '" + aValores[0] + "'";
            //Ejecutar consulta y devolver resultado
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        public string ValorAtributo(string pNombreCampo)
        {//-- Recupera el valor de un atributo del dataset            
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        public DataTable ListaGeneral()
        {//-- Retorna una tabla con la lista completa de libros
            string Consulta = "select * from " + aNombreTabla;
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public void login(string usuario,string contraseña)
        {
            string Consulta = "SELECT * from TUsuarios  WHERE TUsuarios.Usuario='" + usuario + "' AND TUsuarios.Contraseña='" + contraseña + "'";
            aConexion.EjecutarSelect(Consulta);

            
        }
        
    }
}
