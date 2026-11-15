using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeoVimProject.Pages;

public class PasswordRecoverModel : PageModel
{
    [BindProperty, Required] public string Username { get; set; } = string.Empty;
    [BindProperty, Required] public string Question1 { get; set; } = string.Empty;
    [BindProperty, Required] public string Answer1 { get; set; } = string.Empty;
    [BindProperty, Required] public string Question2 { get; set; } = string.Empty;
    [BindProperty, Required] public string Answer2 { get; set; } = string.Empty;

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        // TODO: verify both recovery answers for this user, then let them set a new password.
        return RedirectToPage("/Login");
    }
}
