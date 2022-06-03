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
    public class C_Vacunacion
    {


        public List<Vacunacion> Listar()
        {
            List<Vacunacion> lista = new List<Vacunacion>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select FechaVacunacion,VacunadoPor from VACUNACION");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Vacunacion
                            {
                                FechaVacunacion = dr["FechaVacunacion"].ToString(),
                                VacunadoPor = dr["VacunadoPor"].ToString()


                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<Vacunacion>();
                }

            }
            return lista;
        }
    }
}
