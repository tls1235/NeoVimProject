using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeoVimProject.Pages;

public class RegisterModel : PageModel
{
    [BindProperty, Required] public string Username { get; set; } = string.Empty;
    [BindProperty, Required, DataType(DataType.Password)] public string Password { get; set; } = string.Empty;
    [BindProperty, Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match.")] public string ConfirmPassword { get; set; } = string.Empty;
    [BindProperty, Required] public string FirstName { get; set; } = string.Empty;
    [BindProperty, Required] public string LastName { get; set; } = string.Empty;
    [BindProperty, Required] public string City { get; set; } = string.Empty;
    [BindProperty, Required, Phone] public string Phone { get; set; } = string.Empty;
    [BindProperty, Required, EmailAddress] public string Email { get; set; } = string.Empty;
    [BindProperty, Required] public DateTime? BirthDate { get; set; }
    [BindProperty, Required] public string Gender { get; set; } = string.Empty;
    [BindProperty, Required] public string Question1 { get; set; } = string.Empty;
    [BindProperty, Required] public string Answer1 { get; set; } = string.Empty;
    [BindProperty, Required] public string Question2 { get; set; } = string.Empty;
    [BindProperty, Required] public string Answer2 { get; set; } = string.Empty;

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        // TODO: hash the password and save the new user to your database.
        return RedirectToPage("/Login");
    }
}
