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
    public class C_Partos
    {


        public List<Partos> Listar()
        {
            List<Partos> lista = new List<Partos>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select g.IdGanado,p.FechaParto,p.Sexo,p.Estado from PARTOS p");
                    query.AppendLine("inner join GANADO g on g.IdGanado = p.IdGanado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Partos
                            {
                                IdGanado = new Ganado() {IdGanado= Convert.ToInt32(dr["IdGanado"]) },
                                FechaParto = dr["FechaParto"].ToString(),
                                Sexo = dr["Sexo"].ToString(),
                                Estado = Convert.ToInt32(dr["Estado"])
                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<Partos>();
                }

            }
            return lista;
        }
    }
}
