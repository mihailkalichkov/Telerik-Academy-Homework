using System;
using System.Data.SqlClient;

namespace Task02_GetNameAndDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.; " + "Database=Nortwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand dbNameandDescription = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);

                SqlDataReader reader = dbNameandDescription.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine((string)reader["CategoryName"] + " " + (string)reader["Description"]);
                    }
                }
            }
        }
    }
}
