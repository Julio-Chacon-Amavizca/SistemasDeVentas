using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CONTROLADOR;
using System.Data;

namespace DATOS
{
    public class C_Permisos
    {

         public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try 
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol,p.NombreMenu  from PERMISOS p");
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                            }) ;
                        }
                    }
                }catch(Exception ex)
                {
                    lista = new List<Permiso>();
                }
                
            }
            return lista;
        }

    }
}
