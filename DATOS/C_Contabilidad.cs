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
    public class C_Contabilidad
    {
        public List<Detalle_Venta> Listar()
        {
            List<Detalle_Venta> lista = new List<Detalle_Venta>();
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
                        /*while (dr.Read())
                        {
                            lista.Add(new Detalle_Venta
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }*/
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Detalle_Venta>();
                }

            }
            return lista;
        }

    }
}
