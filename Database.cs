using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace habana_sample
{
    public static class Database
    {
        private static readonly string DatabasePath = FindDatabasePath();

        private static readonly string ConnectionString =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Persist Security Info=False;";
    
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }

        private static string FindDatabasePath()
        {
            DirectoryInfo? directory = new(AppContext.BaseDirectory);

            while (directory != null)
            {
                string databasePath = Path.Combine(directory.FullName, "habana_IMS.accdb");
                if (File.Exists(databasePath))
                {
                    return databasePath;
                }

                directory = directory.Parent;
            }

            throw new FileNotFoundException(
                "The habana_IMS.accdb database file could not be found.");
        }

        public static bool RegisterUser(string username, string email, string password)
        {
            using OleDbConnection connection = GetConnection();
            connection.Open();
            EnsureUsersTable(connection);

            using OleDbCommand command = new(
                "SELECT COUNT(*) FROM [Users] WHERE [Username] = ?",
                connection);
            command.Parameters.AddWithValue("@Username", username);

            if (Convert.ToInt32(command.ExecuteScalar()) > 0)
            {
                return false;
            }

            using OleDbCommand insertCommand = new(
                "INSERT INTO [Users] ([Username], [Email], [PasswordHash]) VALUES (?, ?, ?)",
                connection);
            insertCommand.Parameters.AddWithValue("@Username", username);
            insertCommand.Parameters.AddWithValue("@Email", email);
            insertCommand.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
            insertCommand.ExecuteNonQuery();

            return true;
        }

        public static bool ValidateUser(string username, string password)
        {
            using OleDbConnection connection = GetConnection();
            connection.Open();
            EnsureUsersTable(connection);

            using OleDbCommand command = new(
                "SELECT [PasswordHash] FROM [Users] WHERE [Username] = ?",
                connection);
            command.Parameters.AddWithValue("@Username", username);

            object? result = command.ExecuteScalar();
            return result is string storedHash
                && storedHash == HashPassword(password);
        }

        private static void EnsureUsersTable(OleDbConnection connection)
        {
            DataTable tables = connection.GetSchema("Tables");
            bool tableExists = tables.Rows.Cast<DataRow>().Any(row =>
                string.Equals(row["TABLE_NAME"].ToString(), "Users", StringComparison.OrdinalIgnoreCase)
                && string.Equals(row["TABLE_TYPE"].ToString(), "TABLE", StringComparison.OrdinalIgnoreCase));

            if (!tableExists)
            {
                using OleDbCommand command = new(
                    "CREATE TABLE [Users] ([Username] TEXT(100) NOT NULL, [Email] TEXT(254) NOT NULL, [PasswordHash] TEXT(64) NOT NULL, CONSTRAINT [PK_Users] PRIMARY KEY ([Username]))",
                    connection);
                command.ExecuteNonQuery();
            }
            else
            {
                DataTable columns = connection.GetSchema("Columns");
                bool emailColumnExists = columns.Rows.Cast<DataRow>().Any(row =>
                    string.Equals(row["TABLE_NAME"].ToString(), "Users", StringComparison.OrdinalIgnoreCase)
                    && string.Equals(row["COLUMN_NAME"].ToString(), "Email", StringComparison.OrdinalIgnoreCase));

                if (!emailColumnExists)
                {
                    using OleDbCommand command = new(
                        "ALTER TABLE [Users] ADD COLUMN [Email] TEXT(254)",
                        connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static string HashPassword(string password)
        {
            byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(hash);
        }
    }
}
