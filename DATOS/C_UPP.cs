using CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class C_UPP
    {


        public List<UPP> Listar()
        {
            List<UPP> lista = new List<UPP>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select IdUPP,NombreProductor, UbicacionRancho from UPP");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new UPP
                            {
                                IdUPP = Convert.ToInt32(dr["IdUPP"]),
                                NombreProductor = dr["NombreProductor"].ToString(),
                                UbicacionRancho = dr["UbicacionRancho"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<UPP>();
                }

            }
            return lista;
        }
    }
}
