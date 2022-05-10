using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using CONTROLADOR;
using System.Data.SqlClient;

namespace MODELO
{
    public class M_Rol
    {
        private C_Rol objm_rol = new C_Rol();

        public List<Rol> Listar()
        {
            return objm_rol.Listar();
        }
    }
}
