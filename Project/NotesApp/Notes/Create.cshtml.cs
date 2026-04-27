using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NotesApp.Data;
using MySql.Data.MySqlClient;

namespace NotesApp.Pages.Notes
{
    public class CreateModel : PageModel
    {
        [BindProperty] public string Title { get; set; } = "";
        [BindProperty] public new string Content { get; set; } = "";
        [BindProperty] public string Category { get; set; } = "";

        public IActionResult OnPost()
        {
            DbHelper db = new DbHelper();
            using var conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO notes(title, content, category, created_at)
                             VALUES(@t,@c,@cat,NOW())";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@t", Title);
            cmd.Parameters.AddWithValue("@c", Content);
            cmd.Parameters.AddWithValue("@cat", Category);

            cmd.ExecuteNonQuery();

            return RedirectToPage("Index");
        }
    }
}