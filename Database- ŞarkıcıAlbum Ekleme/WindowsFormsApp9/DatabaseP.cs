using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    internal class DatabaseP
    {
        public SqlConnection baglanti()
        {
            string baglantiC = @"Server=DESKTOP-75OL8LC\SQLEXPRESS;Database=sanatciDB;Integrated Security=True";


            SqlConnection connection = new SqlConnection(baglantiC);
            
                if (connection.State == ConnectionState.Closed)
                {
                connection.Open();  
                }
            return connection;


        }
    }
}
