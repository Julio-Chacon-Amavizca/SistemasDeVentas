using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DATOS;
using CONTROLADOR;

namespace DATOS
{
    public class C_Productos
    {


        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProducto,Codigo,Nombre, p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioVenta, p.Estado from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria= p.IdCategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconenexion);
                    cmd.CommandType = CommandType.Text;

                    oconenexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new Categoria() {IdCategoria=Convert.ToInt32(dr["IdCategoria"]),Descripcion= dr["DescripcionCategoria"].ToString() },
                                Stock = Convert.ToInt32( dr["Stock"].ToString()),
                                PrecioVenta = Convert.ToDecimal( dr["PrecioVenta"].ToString()),
                                Estado = Convert.ToBoolean(dr["Estado"])
                                 
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }

            }
            return lista;
        }





        public int Registrar(Producto obj, out string Mensaje)
        {

            int idogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconenexion);
                   
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    //cmd.Parameters.AddWithValue("Stock", Convert.ToInt32(obj.Stock));
                    //cmd.Parameters.AddWithValue("PrecioVenta",Convert.ToDecimal( obj.PrecioVenta));
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconenexion.Open();
                    cmd.ExecuteNonQuery();
                    idogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                idogenerado = 0;
                Mensaje = ex.Message;
            }
            return idogenerado;

        }



        public bool Editar(Producto obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", oconenexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre ", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion ", obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria ", obj.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconenexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;

        }


        public bool Eliminar(Producto obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", oconenexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.Add("Respueta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconenexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respueta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;

        }





    }
}
