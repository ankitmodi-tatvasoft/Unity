using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UnitOfWorkExample.DAL
{
    public class DataAccess
    {
        private string ConnectionString = @"Data Source=PCI186\SQL2014;Initial Catalog=ankitTemp;Integrated Security=True";
        public bool InsertCustomer(int CustomerCode,
                                  string CustomerName)
        {
            SqlConnection objConn = new SqlConnection(ConnectionString);
            try
            {

                objConn.Open();
                string str = "insert into Customer values(" + CustomerCode + ",'"
                                                           + CustomerName + "')";
                SqlCommand objCommand = new SqlCommand(str, objConn);
                objCommand.ExecuteNonQuery();
                objConn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return true;
        }

        public SqlDataReader GetCustomer(int CustomerCode)
        {
            SqlConnection objConn = new SqlConnection(ConnectionString);
            objConn.Open();
            string str = "select * from Customer where CustomerCode=" + CustomerCode;
            SqlCommand objCommand = new SqlCommand(str, objConn);
            return objCommand.ExecuteReader();
        }

        public bool UpdateCustomer(int CustomerCode,
                                   string CustomerName)
        {
            SqlConnection objConn = new SqlConnection(ConnectionString);
            objConn.Open();
            string str = "Update  Customer set CustomerName='"
                            + CustomerName +
                            "' where CustomerCode=" + CustomerCode;
            SqlCommand objCommand = new SqlCommand(str, objConn);
            objCommand.ExecuteNonQuery();
            objConn.Close();
            return true;
        }
    }
}