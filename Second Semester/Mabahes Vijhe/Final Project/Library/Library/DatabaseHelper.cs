using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public static class DatabaseHelper
{
    private static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryConnection"].ConnectionString;

    public static void ExecuteQuery(string query, Action<SqlCommand> configureCommand = null)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                configureCommand?.Invoke(command);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void ReadData(string query, Action<SqlDataReader> handleData, Action<SqlCommand> configureCommand = null)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                configureCommand?.Invoke(command);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        handleData(reader);
                    }
                }
            }
        }
    }

    public static DataTable GetData(string query, Action<SqlCommand> parameterize = null)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                parameterize?.Invoke(command);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
        }
        return dataTable;
    }
    /*
    public static int ExecuteScalar(string query, Action<SqlCommand> configureCommand = null)
    {
        using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True;"))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                configureCommand?.Invoke(command);
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int scalarValue))
                {
                    return scalarValue;
                }
                else
                {
                    throw new InvalidOperationException("کوئری هیچ مقداری بازنگرداند یا مقدار بازگشتی قابل تبدیل به عدد صحیح نیست.");
                }
            }
        }
    }
    */
    public static object ExecuteScalar(string query, Action<SqlCommand> configureCommand = null)
    {
        using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True;"))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                configureCommand?.Invoke(command);
                object result = command.ExecuteScalar();
                return result ?? DBNull.Value;
            }
        }
    }
}
