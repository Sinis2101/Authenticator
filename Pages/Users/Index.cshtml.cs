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
    public class IndexModel : PageModel
    {
        private readonly Authenticator.Data.AuthenticatorContext _context;

        public IndexModel(Authenticator.Data.AuthenticatorContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
