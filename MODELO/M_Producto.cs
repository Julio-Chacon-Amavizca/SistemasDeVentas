using DATOS;
using CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class M_Producto
    {

        private C_Productos objecd_Producto = new C_Productos();

        public List<Producto> Listar()
        {
            return objecd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            try
            {
                int codigoInt = Convert.ToInt32(obj.Codigo);
            }
            catch
            {
                Mensaje += "El codigo debe ser numerico";
            }

            if (obj.Codigo.Length != 8)
            {
                Mensaje += "El codigo debe ser de 8 digitos";
            }



            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre de Producto de la persona\n";
            }


            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la contraseña del Producto\n";
            }

            if (Mensaje != string.Empty)
            {

                return 0;

            }
            else
            {
                return objecd_Producto.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el nombre completo del Producto\n";
            }

            try
            {
                int codigoInt = Convert.ToInt32(obj.Codigo);
            }
            catch
            {
                Mensaje += "El codigo debe ser numerico";
            }

            if(obj.Codigo.Length != 8)
            {
                Mensaje += "El codigo debe ser de 8 digitos";
            }


            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre de Producto de la persona\n";
            }


            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la contraseña del Producto\n";
            }

            if (Mensaje != string.Empty)
            {

                return false;

            }
            else
            {
                return objecd_Producto.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objecd_Producto.Eliminar(obj, out Mensaje);
        }






    }
}
