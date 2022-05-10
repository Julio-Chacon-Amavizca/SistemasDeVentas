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
    public class C_Rol
    {

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdRol,Descripcion from ROL");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString()                           
                            }) ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }

            }
            return lista;
        }

    }
}
