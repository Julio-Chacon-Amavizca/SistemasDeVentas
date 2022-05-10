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
    public class C_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
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
                        while (dr.Read())
                        {
                            lista.Add(new Categoria
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }

            }
            return lista;
            }


        public int Registrar(Categoria obj, out string Mensaje)
        {

            int iducategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", oconenexion);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction= ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconenexion.Open();

                    cmd.ExecuteNonQuery();
                    
                    iducategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                iducategoriagenerado = 0;
                Mensaje = ex.Message;
            }
            return iducategoriagenerado;

        }




        public bool Editar(Categoria obj, out string Mensaje)
        {

            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", oconenexion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconenexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;

        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {

            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconenexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", oconenexion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);                   
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconenexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;

        }





    }
}
