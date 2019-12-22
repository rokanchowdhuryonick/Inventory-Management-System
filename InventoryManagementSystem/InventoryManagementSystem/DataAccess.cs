using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public class DataAccess
    {
        public static string CONNECTION_STRING = @"";

        //This returns the connection string  
        private static string _connectionString = string.Empty;

        public static string ConnectionString
        {
            get
            {
                if (_connectionString == string.Empty)
                {
                    _connectionString = CONNECTION_STRING;
                }

                return _connectionString;
            }
        }

        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataAccess()
        {
            CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\GitHub Repository\Inventory-Management-System\InventoryManagementSystem\InventoryManagementSystem\inventoryDB.mdf';Integrated Security=True;Connect Timeout=30";
        }

        /// <summary>
        /// Brings a SqlCommand object to be able to add some parameters in it. After you send this to Execute method.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand GetCommand(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Execute(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetCommand(sql);

            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }

        /// <summary>
        /// Returns Datatable
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {

                command.Connection.Open();
                dt.Load(command.ExecuteReader());
            }
            catch (Exception ex) {
                // MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }

            return dt;
        }

        /// <summary>
        /// returns affected row count
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            int result = 0;
            try
            {
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(SqlCommand command)
        {
            int result = 0;
            try
            {
                command.Connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                command.Connection.Close();
            }

            return result;
        }

    }
}