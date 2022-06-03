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
    public class C_VentasGanaderia
    {

        public List<VentaGanado> Listar()
        {
            List<VentaGanado> lista = new List<VentaGanado>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUPP,g.IdGanado,v.FechaVenta,v.PrecioVenta,v.PrecioSubasta from ventas v");
                    query.AppendLine("inner join GANADO g on g.IdGanado=v.IdGanado");
                    query.AppendLine("inner join UPP u on u.IdUPP=v.IdUPP");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VentaGanado
                            {
                                oUPP = new UPP() { IdUPP= Convert.ToInt32(dr["IdUPP"]) },
                                IdGanado = new Ganado() { IdGanado = Convert.ToInt32(dr["IdGanado"]) },
                                FechaVenta = dr["FechaVenta"].ToString(),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                PrecioSubasta = Convert.ToDecimal(dr["PrecioSubasta"])

                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<VentaGanado>();
                }

            }
            return lista;
        }
    }
}
