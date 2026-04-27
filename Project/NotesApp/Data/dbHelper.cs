using MySql.Data.MySqlClient;

namespace NotesApp.Data
{
    public class DbHelper
    {
        private string connectionString = "server=localhost;database=notes_db;user=root;password=yourpassword";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}