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
                    query.AppendLine("SELECT IdGanado, Apodo, Proposito, FechaAretado, UPP FROM GANADO g inner join UPP u on u.IdUPP = g.UPP");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Ganado
                            {
                                IdGanado = Convert.ToInt32(dr["Idganado"]),
                                Apodo = dr["Apodo"].ToString(),
                                Proposito = dr["Proposito"].ToString(),
                                FechaAretado = dr["FechaAretado"].ToString()/*
                                ,
                                oUPP = new UPP() { IdUPP = Convert.ToInt32(dr["IdUPP"])},*/
                            });
                        }
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
