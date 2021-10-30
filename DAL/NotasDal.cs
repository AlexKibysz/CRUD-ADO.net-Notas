using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NotasDal
    {
        public List<Notas> GetNotas(string connectionString)
        {
            List<Notas> NotasList = new List<Notas>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select idNota,Mensaje, FechaEscritura, FechaEntrega from Notas";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Notas notas = new Notas();
                    notas.mensaje = Convert.ToString(dr["Mensaje"]);
                    try
                    {
                        notas.fechaEntrega = Convert.ToDateTime(dr["FechaEntrega"]);
                        notas.fechaEscritura = Convert.ToDateTime(dr["FechaEscritura"]);
                    }
                    catch (System.InvalidCastException)
                    {
                        notas.fechaEntrega = DateTime.MinValue;
                        notas.fechaEscritura = DateTime.MinValue;
                    }

                    notas.idNotas = Convert.ToInt32(dr["idNota"]);
                    NotasList.Add(notas);
                }
            }
            con.Close();

            return NotasList;
        }

        public Notas GetNotasData(string connectionString, int idnota)
        {
            Notas nota = new Notas();

            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select idNota, mensaje, fechaEscritura, fechaEntrega from Notas where idNota=" + idnota;

            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    nota.idNotas = Convert.ToInt32(dr["idNota"]);
                    nota.mensaje = Convert.ToString(dr["mensaje"]);
                    nota.fechaEscritura = Convert.ToDateTime(dr["fechaEscritura"]);
                    nota.fechaEntrega = Convert.ToDateTime(dr["fechaEntrega"]);
                }
            }

            return nota;
        }

        public void EditarNotas(string connectionString, Notas notas)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateNota", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@idNota", notas.idNotas));

                    cmd.Parameters.Add(new SqlParameter("@mensaje", notas.mensaje));

                    cmd.Parameters.Add(new SqlParameter("@fechaEscritura", notas.fechaEscritura));

                    cmd.Parameters.Add(new SqlParameter("@fechaEntrega", notas.fechaEntrega));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CrearNotas(string connectionString, Notas nota)
        {
            try

            {
                using (SqlConnection con = new SqlConnection(connectionString))

                {
                    SqlCommand cmd = new SqlCommand("CrearNotas", con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Mensaje", nota.mensaje));

                    cmd.Parameters.Add(new SqlParameter("@FechaEscritura", nota.fechaEscritura));

                    cmd.Parameters.Add(new SqlParameter("@FechaEntrega", nota.fechaEntrega));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteNotas(String connectionString, int idNotas)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteNotas", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@idNotas", idNotas));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}