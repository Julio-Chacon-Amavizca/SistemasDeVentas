using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using CONTROLADOR;

namespace MODELO
{
    public class M_Categoria
    {
        private C_Categoria objecd_categoria = new C_Categoria();

        public List<Categoria> Listar()
        {
            return objecd_categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {

                return 0;

            }
            else
            {
                return objecd_categoria.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;



            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion de la Categoria\n";
            }


            if (Mensaje != string.Empty)
            {

                return false;

            }
            else
            {
                return objecd_categoria.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objecd_categoria.Eliminar(obj, out Mensaje);
        }
    }
}
