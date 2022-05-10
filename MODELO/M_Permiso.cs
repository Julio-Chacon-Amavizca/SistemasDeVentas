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
    public class M_Permiso
    {
        private C_Permisos objm_permiso = new C_Permisos();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objm_permiso.Listar(IdUsuario);
        }
    }
}
