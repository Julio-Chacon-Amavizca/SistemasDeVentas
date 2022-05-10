using CONTROLADOR;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class M_Negocio
    {
        private C_Negocio objecd_negocio = new C_Negocio();

        public Negocio ObtenerDatos()
        {
            return objecd_negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Direccion == "")
            {
                Mensaje += "Es necesaria la direccion";
            }


            if (obj.Nombre
                == "")
            {
                Mensaje += "Es necesario el nombre\n";
            }


            if (obj.RUC == "")
            {
                Mensaje += "Es necesaria el RUC\n";
            }

            if (Mensaje != string.Empty)
            {

                return false;

            }
            else
            {
                return objecd_negocio.GuardarDatos(obj, out Mensaje);
            }

        }

        public Byte[] ObtenerLogo(out bool obtenido)
        {
            return objecd_negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objecd_negocio.ActualizarLogo(imagen, out  mensaje);
        }
    }
}
