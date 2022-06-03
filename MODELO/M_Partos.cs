using CONTROLADOR;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class M_Partos
    {

        private C_Partos objm_permiso = new C_Partos();

        public List<Partos> Listar()
        {
            return objm_permiso.Listar();
        }
    }
}
