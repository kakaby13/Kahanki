using Duende.IdentityServer.EntityFramework.Options;
using Kahanki.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Kahanki.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<UserSettings> UserSettings { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;


        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }
    }
}