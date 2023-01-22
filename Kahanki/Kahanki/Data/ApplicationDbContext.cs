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
        public DbSet<UserMatchAction> UserMatchActions { get; set; } = null!;
        public DbSet<Message> Messages { get; set; } = null!;
        
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserMatchAction>()
                .HasOne(c => c.ActedUser)
                .WithMany(c => c.OwnMatchActions)
                .HasForeignKey(c => c.ActedUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<UserMatchAction>()
                .HasOne(c => c.TargetUser)
                .WithMany(c => c.TargetMatchActions)
                .HasForeignKey(c => c.TargetUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<Message>()
                .HasOne(c => c.Sender)
                .WithMany(c => c.MessagesSent)
                .HasForeignKey(c => c.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Message>()
                .HasOne(c => c.Reciever)
                .WithMany(c => c.MessagesReceived)
                .HasForeignKey(c => c.RecieverId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            // TODO
            //прописать связи к чату 1) от пользователей и 2) от сообщений
        }
    }
}