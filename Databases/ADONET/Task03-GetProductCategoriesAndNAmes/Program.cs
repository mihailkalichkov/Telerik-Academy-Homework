using System;
using System.Data.SqlClient;

namespace Task03_GetProductCategoriesAndNAmes
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " + "Database=Nortwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand dbCategoriesandProductNsmes = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Categories c" + 
                    "JOIN Products p " +
                    "ON c.CategoryID = p.CategoryID " +
                    "GROUP BY c.CategoryID, p.ProductName", dbCon);

                SqlDataReader reader = dbCategoriesandProductNsmes.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine((string)reader["CategoryName"] + " " + (string)reader["ProductName"]);
                    }
                }
            }
        }
    }
}
