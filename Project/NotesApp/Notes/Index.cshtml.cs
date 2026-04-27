using Microsoft.AspNetCore.Mvc.RazorPages;
using NotesApp.Models;
using NotesApp.Data;
using MySql.Data.MySqlClient;

namespace NotesApp.Pages.Notes
{
    public class IndexModel : PageModel
    {
        public List<Note> Notes = new List<Note>();

        public void OnGet()
        {
            DbHelper db = new DbHelper();
            using var conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM notes ORDER BY created_at DESC";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Notes.Add(new Note
                {
                    Id = reader.GetInt32("id"),
                    Title = reader.GetString("title"),
                    Content = reader.GetString("content"),
                    Category = reader.GetString("category"),
                    CreatedAt = reader.GetDateTime("created_at")
                });
            }
        }
    }
}