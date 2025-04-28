using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using testGit.Model;

namespace testGit.Data
{
    public class DbHelper
    {
        private string connectionString = "Data Source=DESKTOP-GRA8A3I;Initial Catalog=APISample;Integrated Security=True";
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select*From Products", connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ID = (int)reader["ID"],
                            Name = reader["Name"].ToString(),
                            Price = (decimal)reader["Price"]
                        });
                    }
                }
            }
            return products;
        }
    }
}
