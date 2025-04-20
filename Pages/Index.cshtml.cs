using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dailee_Konnekt.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = string.Empty; // Initialize with empty string

        [BindProperty]
        public string Password { get; set; } = string.Empty; // Initialize with empty string

        public string? ErrorMessage { get; set; } // Mark as nullable since it's conditional

        public IActionResult OnPost()
        {
            if (Username == "Username" && Password == "123")
            {
                return RedirectToPage("/Home");
            }

            ErrorMessage = "Invalid username or password.";
            return Page();
        }
    }
}