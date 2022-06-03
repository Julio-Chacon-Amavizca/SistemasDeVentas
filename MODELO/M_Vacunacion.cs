using CONTROLADOR;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class M_Vacunacion
    {

        private C_Vacunacion objcd_venta = new C_Vacunacion();

        public List<Vacunacion> Listar()
        {
            return objcd_venta.Listar();
        }
    }
}
