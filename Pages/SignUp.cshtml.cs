using Authenticator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Authenticator.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {

        }
        
        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/Index");
        }
    }
}
