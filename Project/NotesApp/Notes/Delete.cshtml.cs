using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NotesApp.Data;
using MySql.Data.MySqlClient;

namespace NotesApp.Pages.Notes
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(int id)
        {
            DbHelper db = new DbHelper();
            using var conn = db.GetConnection();
            conn.Open();

            string query = "DELETE FROM notes WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return RedirectToPage("Index");
        }
    }
}