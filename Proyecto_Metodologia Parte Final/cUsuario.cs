using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Metodologia
{
   public  class cUsuario:cEntidad
    {

        public cUsuario() : base("TUsuarios")
        {

        }
        public override string[] NombresAtributos()
        {
            return new string[] { "Usuario", "DescripcionRequisito" };
        }
    }
}
