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
    public class C_Ganaderia
    {


        public List<Ganado> Listar()
        {
            List<Ganado> lista = new List<Ganado>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select IdCategoria,Descripcion, Estado from CATEGORIA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                       /* while (dr.Read())
                        {
                            lista.Add(new Ganado
                            {
                                /*IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }*/
                    }
                }
                catch
                {
                    lista = new List<Ganado>();
                }

            }
            return lista;
        }
    }
}
