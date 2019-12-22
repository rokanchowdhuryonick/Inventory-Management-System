using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class ProductRepo
    {
        public static DataAccess DataAccess;
        public ProductRepo()
        {
            if (DataAccess == null)
            {
                DataAccess = new DataAccess();
            }
        }

        public int InsertProduct(string Barcode, string Name, string Category, string PurchasePrice, string SellPrice, string Stock, string Status)
        {
            String _insertQuery =
                "INSERT INTO products (productBarcode, Name, PurchasePrice, SellPrice, Stock, Category, Status) " +
                "VALUES (@Barcode,@Name,@PurchasePrice,@SellPrice,@Stock,@Category,@Status)";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@Barcode", Barcode);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
            cmd.Parameters.AddWithValue("@SellPrice", SellPrice);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Category", Category);
            cmd.Parameters.AddWithValue("@Status", Status);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public int UpdateProduct(string productId, string Name, string Category, string PurchasePrice, string SellPrice, string Stock, string Status)
        {
            String _insertQuery =
                "UPDATE products SET Name=@Name, PurchasePrice=@PurchasePrice, SellPrice=@SellPrice, Stock=@Stock, Category=@Category, Status=@Status WHERE Id=@productId";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
            cmd.Parameters.AddWithValue("@SellPrice", SellPrice);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Category", Category);
            cmd.Parameters.AddWithValue("@Status", Status);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public int DeleteProduct(string productId)
        {
            String _deleteQuery = "DELETE FROM products WHERE Id=@Id ";

            SqlCommand cmd = DataAccess.GetCommand(_deleteQuery);

            cmd.Parameters.AddWithValue("@Id", productId);
            return DataAccess.ExecuteNonQuery(cmd);

        }

        public DataTable GetAllCategory()
        {
            String query = "select Id, cat_name as 'Category Name' from category";
            return DataAccess.Execute(query);
        }

        public int InsertCategory(string categoryName)
        {
            String _insertQuery =
                "INSERT INTO category (cat_name) " +
                "VALUES (@categoryName)";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);
            
            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public int UpdateCategory(string categoryId, string categoryName)
        {
            String _insertQuery =
                "UPDATE category SET  cat_name=@categoryName WHERE Id=@categoryId" ;

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            cmd.Parameters.AddWithValue("@categoryId", categoryId);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetAllProducts()
        {
            String query = "select * from products";
            return DataAccess.Execute(query);
        }

        public DataTable GetAllBills()
        {
            String query = "select * from bills";
            return DataAccess.Execute(query);
        }

        public DataTable GetProductByID(string productId)
        {
            String _selectQuery = "SELECT * FROM products WHERE Id=@id";

            SqlCommand cmd = DataAccess.GetCommand(_selectQuery);
            
            cmd.Parameters.AddWithValue("@id", productId);
            return DataAccess.Execute(cmd);
        }

        public DataTable GetProductByBarcode(string barcode)
        {
            String _selectQuery = "SELECT * FROM products WHERE productBarcode=@barcode";

            SqlCommand cmd = DataAccess.GetCommand(_selectQuery);

            cmd.Parameters.AddWithValue("@barcode", barcode);
            return DataAccess.Execute(cmd);
        }

        public int SellProduct(string billNo, string total, string customerId, string barcode)
        {
            String _insertQuery =
                "INSERT INTO bills (BillNo, NetBill, CustomerId) " +
                "VALUES (@BillNo, @NetBill, @CustomerId)";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@BillNo", billNo);
            cmd.Parameters.AddWithValue("@NetBill", total);
            cmd.Parameters.AddWithValue("@CustomerId", customerId);

            return DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetCategoryByID(string categoryId)
        {
            String _selectQuery = "SELECT * FROM category WHERE Id=@id";

            SqlCommand cmd = DataAccess.GetCommand(_selectQuery);

            cmd.Parameters.AddWithValue("@id", categoryId);
            return DataAccess.Execute(cmd);
        }

        public int UpdateStock(string barcode, string newStock)
        {
            String _insertQuery =
                "UPDATE products SET Stock=@stock WHERE productBarcode=@barcode";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@stock", newStock);
            cmd.Parameters.AddWithValue("@barcode", barcode);
            return DataAccess.ExecuteNonQuery(cmd);
        }

       // public DataTable GetAllSells()
       // {

      //  }


    }
}
