using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using CONTROLADOR;
using System.Text.RegularExpressions;

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
            if (obj.NombreCompleto == "" || obj.NombreCompleto.Length < 3)
            {
                Mensaje += "Es necesario el nombre completo del usuario (Mayor de tres caracteres)\n";
            }

           
            if (obj.Documento == "" )
            {
                Mensaje += "Es necesario un nombre de usuario \n";
            }


            if (obj.Clave == "" || obj.Clave.Length < 6)

                Mensaje += "Es necesaria una contraseña de 6 caracteres\n";
            }
            
            try
            {
                var addr = new System.Net.Mail.MailAddress(obj.Correo);
            }
            catch
            {
                Mensaje += "No es una estructura de correo valida\n";
            }
            
            
            if (Mensaje != string.Empty)
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
            if (obj.NombreCompleto == "" || obj.NombreCompleto.Length < 3)
            {
                Mensaje += "Es necesario el nombre completo del usuario (Mayor de tres caracteres)\n";
            }


            if (obj.Documento == "")
            {
                Mensaje += "Es necesario un nombre de usuario \n";
            }


            if (obj.Clave == "" || obj.Clave.Length < 6)
            {
                Mensaje += "Es necesaria una contraseña de 6 caracteres\n";
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(obj.Correo);
            }
            catch
            {
                Mensaje += "No es una estructura de correo valida\n";
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
