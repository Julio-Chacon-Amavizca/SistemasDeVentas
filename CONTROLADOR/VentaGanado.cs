using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR
{
    public class VentaGanado
    {

        public UPP oUPP { get; set; }
        public Ganado IdGanado { get; set; }
        public string FechaVenta { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioSubasta { get; set; }

    }
}
