using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Agencia_Turismo.Models
{
    public class IngresoDeUsuarios
    {
        public List<Usuario> getUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Usuario_all";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string apellido = dr.GetString(2).Trim();
                    string celular = dr.GetString(3).Trim();
                    string email = dr.GetString(4).Trim();
                    string contrasena = dr.GetString(5).Trim();
                    string rcontrasena = dr.GetString(6).Trim();
                    

                    Usuario usuario = new Usuario(id, nombre, apellido, celular, email, contrasena, rcontrasena);

                    lista.Add(usuario);
                }

                dr.Close();
                conn.Close();
            }

            return lista;
        }

        public bool addUsuario(Usuario usuario)
        {
            bool res = false;

            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Usuario_add";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.apellido);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@contrasena", usuario.contrasena);
                cmd.Parameters.AddWithValue("@rcontrasena", usuario.rcontrasena);
                cmd.Parameters.AddWithValue("@celular", usuario.celular);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }

    }
}