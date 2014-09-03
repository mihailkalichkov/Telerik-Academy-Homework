using System;
using System.Data.SqlClient;

namespace Task04_AddNewProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Dancing Groot doll";
            string supplierID = "4";
            string categoryID = "2";

            SqlConnection dbCon = new SqlConnection("Server=.; " + "Database=Nortwind; Integrated Security=true");

            SqlCommand dbAddProduct = new SqlCommand(
                "INSERT INTO Products(ProductName, SupplierID, CategoryID) " +
                "VALUES (@productName, @supplierID, @categoryID)", dbCon);
            dbAddProduct.Parameters.AddWithValue("@productName", productName);
            dbAddProduct.Parameters.AddWithValue("@supplierID", supplierID);
            dbAddProduct.Parameters.AddWithValue("@categoryID", categoryID);

            dbCon.Open();

            using (dbCon)
            {
                dbAddProduct.ExecuteNonQuery();

                SqlCommand dbSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
                int insertedProductID = (int)(decimal)dbSelectIdentity.ExecuteScalar();
                Console.WriteLine(productName + " " + supplierID + " " + categoryID + " " + insertedProductID);
            }
        }
    }
}
