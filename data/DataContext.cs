
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SmsDotNet.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SmsDotNet.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            :base(options)
        {
        }
        public DbSet<ContactModel> Contact { get; set; }
        public DbSet<HistoryPasswordModel> History { get; set; }
        public DbSet<MessageModel> Message { get; set; }
        public DbSet<ProfileModel> Profile { get; set; }
        public DbSet<StoryModel> Story { get; set; }
        public DbSet<UserModel> User { get; set; }

        public override int SaveChanges()
        {
            Audit();
            return base.SaveChanges();
        }
        public void Audit()
        {
            var entries = ChangeTracker.Entries()
                .Where(entry => entry.Entity is AuditModel &&
                    entry.State == EntityState.Added ||
                    entry.State == EntityState.Deleted ||
                    entry.State == EntityState.Modified);
            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        ((AuditModel)entry.Entity).CeatedDate = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        ((AuditModel)entry.Entity).LastUpdate = DateTime.Now;
                        ((AuditModel)entry.Entity).IsDeleted = true;
                            break;
                    case EntityState.Modified:
                        ((AuditModel)entry.Entity).LastUpdate = DateTime.Now;
                        break;
                }
            }
        }
       
        public override Task <int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {                          
            Audit();
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => new { u.Email })
                .IsUnique(true);

            modelBuilder.Entity<ContactModel>()
                .HasOne(c => c.Owner)
                .WithMany(u => u.Contact)
                .HasForeignKey(c => c.IdOwner);

            modelBuilder.Entity<ContactModel>()
                .HasOne(c => c.Target)
                .WithMany(u => u.Contact)
                .HasForeignKey(c => c.IdTarget);

            modelBuilder.Entity<UserModel>()
                .HasMany(u => u.History)
                .WithOne(h => h.Owner)
                .HasForeignKey(c => c.IdOwner);

            modelBuilder.Entity<MessageModel>()
                .HasOne(m => m.Owner)
                .WithMany(u => u.Message)
                .HasForeignKey(u => u.IdOwner);

            modelBuilder.Entity<MessageModel>()
                .HasOne(m => m.Target)
                .WithMany(u => u.Message)
                .HasForeignKey(m => m.IdTarget);

            modelBuilder.Entity<UserModel>()
                .HasMany(u => u.History)
                .WithOne(h => h.Owner)
                .HasForeignKey(h => h.IdOwner);
        }
    }
}