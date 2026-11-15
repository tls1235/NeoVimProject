using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeoVimProject.Pages;

public class LoginModel : PageModel
{
    [BindProperty, Required] public string Username { get; set; }
    [BindProperty, Required, DataType(DataType.Password)] public string Password { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        // TODO: validate credentials against your user store and sign the user in.
        return RedirectToPage("/Index");
    }
}
