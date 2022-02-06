#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Authenticator.Models;

namespace Authenticator.Data
{
    public class AuthenticatorContext : DbContext
    {
        public AuthenticatorContext (DbContextOptions<AuthenticatorContext> options)
            : base(options)
        {
        }

        public DbSet<Authenticator.Models.User> User { get; set; }
    }
}
