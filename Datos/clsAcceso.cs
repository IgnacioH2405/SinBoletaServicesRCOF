using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace Datos
{
    public class clsAcceso
    {
        SqlConnection Conn = new SqlConnection();
        private void Open()
        {

            ConnectionStringSettings SQLConnection = ConfigurationManager.ConnectionStrings["conexion"];
            Conn.ConnectionString = SQLConnection.ToString();

            Conn.Open();
        }

        private SqlConnection GetConnection()
        {
            return Conn;
        }

        private void Cerrar()
        {
            Conn.Close();
        }

        public  DataSet ExecutarSP(String StoredProcedure, List<SqlParameter> parametros)
        {
            SqlCommand cmd;
            SqlDataAdapter adap;
            DataSet ds;
            
            try
            {
                Open();
                cmd = new SqlCommand();
                cmd.Connection = GetConnection();
                cmd.CommandText = StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                if (parametros != null)
                    foreach (SqlParameter param in parametros)
                    {
                        cmd.Parameters.Add(param);
                    }

                adap = new SqlDataAdapter();
                adap.SelectCommand = cmd;
                ds = new DataSet();


                adap.Fill(ds);


                return ds;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
                cmd = null;
                adap = null;
                ds = null;
                Cerrar();
            }
        }






    }



}
