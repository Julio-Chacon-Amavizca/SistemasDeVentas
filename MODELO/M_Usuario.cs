using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using CONTROLADOR;

namespace MODELO
{
    public class M_Usuario
    {
        private C_Usuarios objecd_usuario = new C_Usuarios();
        
        public List<Usuario> Listar()
        {
            return objecd_usuario.Listar();
        }

        public int Registrar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.NombreCompleto=="")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

           
            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el nombre de usuario de la persona\n";
            }


            if (obj.Clave == "")
            {
                Mensaje += "Es necesaria la contraseña del usuario\n";
            }

            if(Mensaje!= string.Empty) 
            {

                return 0;

            }
            else
            {
                return objecd_usuario.Registrar(obj, out Mensaje);
            }
            
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }


            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el nombre de usuario de la persona\n";
            }


            if (obj.Clave == "")
            {
                Mensaje += "Es necesaria la contraseña del usuario\n";
            }

            if (Mensaje != string.Empty)
            {

                return false;

            }
            else
            {
                return objecd_usuario.Editar(obj, out Mensaje);
            }
           
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
                return objecd_usuario.Eliminar(obj, out Mensaje);
        }







    }
}
