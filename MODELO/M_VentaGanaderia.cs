using CONTROLADOR;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class M_VentaGanaderia
    {


        private C_VentasGanaderia objcd_venta = new C_VentasGanaderia();
        public List<VentaGanado> Listar()
        {
            return objcd_venta.Listar();
        }
    }
}
