using System;
using System.Data.SqlClient;

namespace Task01_GEtNumberOFRowsInCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " + "Database=Nortwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand dbNumberOfCategories = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);

                int numberOfCategories = (int)dbNumberOfCategories.ExecuteScalar();

                Console.WriteLine(numberOfCategories);
            }
        }
    }
}
