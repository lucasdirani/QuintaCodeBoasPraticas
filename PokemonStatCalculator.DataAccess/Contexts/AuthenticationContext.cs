using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokemonStatCalculator.DataAccess.DataModels.Logging;

namespace PokemonStatCalculator.DataAccess.Contexts
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options)
            : base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }
    }
}