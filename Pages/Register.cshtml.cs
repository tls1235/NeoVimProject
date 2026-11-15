using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NeoVimProject.Pages;

public class RegisterModel : PageModel
{
    [BindProperty, Required] public string Username { get; set; }
    [BindProperty, Required, DataType(DataType.Password)] public string Password { get; set; }
    [BindProperty, Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match.")] public string ConfirmPassword { get; set; }
    [BindProperty, Required] public string FirstName { get; set; }
    [BindProperty, Required] public string LastName { get; set; }
    [BindProperty, Required] public string City { get; set; }
    [BindProperty, Required, Phone] public string Phone { get; set; }
    [BindProperty, Required, EmailAddress] public string Email { get; set; }
    [BindProperty, Required] public DateTime? BirthDate { get; set; }
    [BindProperty, Required] public string Gender { get; set; }
    [BindProperty, Required] public string Question1 { get; set; }
    [BindProperty, Required] public string Answer1 { get; set; }
    [BindProperty, Required] public string Question2 { get; set; }
    [BindProperty, Required] public string Answer2 { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        // TODO: hash the password and save the new user to your database.
        return RedirectToPage("/Login");
    }
}
