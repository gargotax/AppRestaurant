using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MioProgetto
{
    internal class Class1
    {
        public void connect(object sender, EventArgs e)
        {
            string connectionstring = null;

            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            cnn = new SqlConnection(connectionstring);

            connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mioProgetto;Integrated Security=True;" +
                              "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                              "MultiSubnetFailover=False";
            sql = "Your SQL Statement Here like Select Count(*) from product";

            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            var insert = "INSERT INTO dbo.restaurant(id, [data],[totale]) VALUES (@id,@data,@totale)";
            /* using (var cmd = new SqlCommand(sql, cnn))
             {
             }*/
            cnn.Close();


        }

        public void reader(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }
            }
        }
    }
}
