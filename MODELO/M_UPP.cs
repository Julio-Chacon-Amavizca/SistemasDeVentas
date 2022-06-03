using CONTROLADOR;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class M_UPP
    {

        private C_UPP objecd_usuario = new C_UPP();

        public List<UPP> Listar()
        {
            return objecd_usuario.Listar();
        }

    }
}
