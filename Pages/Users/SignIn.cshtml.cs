#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Authenticator.Data;
using Authenticator.Models;

namespace Authenticator.Pages.Users
{
    public class SignIn : PageModel
    {
        private readonly Authenticator.Data.AuthenticatorContext _context;

        public SignIn(Authenticator.Data.AuthenticatorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Obtengo los campos digitados en el login
            var userName = User.Username;
            var password = User.Password;

            var usuario = from u in _context.User
                          select u;


            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                var c = usuario.Count();//Cuenta la cantidad de registros en la base de datos
                usuario = usuario.Where(x => x.Username.Equals(userName) & x.Password.Equals(password)); //Hace una consulta en la base de datos para saber si existe información que coincida
                var d = usuario.Count();//La cantidad de registros que coinciden


                if (d == 0)
                {
                    return RedirectToPage("./Create");
                }
            }

            return RedirectToPage("./Index");

        }
    }
}
