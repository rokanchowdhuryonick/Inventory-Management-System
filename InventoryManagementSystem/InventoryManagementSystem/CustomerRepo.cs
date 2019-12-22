using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class CustomerRepo
    {
        public static DataAccess DataAccess;
        public CustomerRepo()
        {
            if (DataAccess == null)
            {
                DataAccess = new DataAccess();
            }
        }

        public int InsertCustomer(string customerName, string customerPhone, string customerAddress)
        {
            String _insertQuery =
                "INSERT INTO customers (Name, Phone, Address) " +
                "VALUES (@Name,@Phone,@Address)";

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@Name", customerName);
            cmd.Parameters.AddWithValue("@Phone", customerPhone);
            cmd.Parameters.AddWithValue("@Address", customerAddress);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public int UpdateCustomer(string customerId, string customerName, string customerPhone, string customerAddress)
        {
            String _insertQuery =
                "UPDATE customers SET Name=@Name, Phone=@Phone, Address=@Address WHERE Id=@Id " ;

            SqlCommand cmd = DataAccess.GetCommand(_insertQuery);

            cmd.Parameters.AddWithValue("@Name", customerName);
            cmd.Parameters.AddWithValue("@Phone", customerPhone);
            cmd.Parameters.AddWithValue("@Address", customerAddress);
            cmd.Parameters.AddWithValue("@Id", customerId);
            return DataAccess.ExecuteNonQuery(cmd);

        }

        public int DeleteCustomer(string customerId)
        {
            String _deleteQuery ="DELETE FROM customers WHERE Id=@Id ";

            SqlCommand cmd = DataAccess.GetCommand(_deleteQuery);
            
            cmd.Parameters.AddWithValue("@Id", customerId);
            return DataAccess.ExecuteNonQuery(cmd);
        }

        public DataTable GetAllCustomer()
        {
            String query = "select * from customers";

            return DataAccess.Execute(query);
        }

        public DataTable GetCustomerByID(string CustomerId)
        {
            String query = "select * from customers where Id=@CustomerId";

            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
            return DataAccess.Execute(cmd);
        }

        public DataTable GetCustomerByPhone(string CustomerPhone)
        {
            String query = "select * from customers where Phone=@CustomerPhone";

            SqlCommand cmd = DataAccess.GetCommand(query);
            cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhone);
            return DataAccess.Execute(cmd);
        }
    }
}
