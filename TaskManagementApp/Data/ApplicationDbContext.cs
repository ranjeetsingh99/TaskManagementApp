using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Models;

namespace TaskManagementApp.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<TaskItem> TaskItems { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<TaskItem>(entity =>
        {
            entity.Property(t => t.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()")
            .ValueGeneratedOnAdd();

            //entity.Property(t => t.UpdatedAt)
            //.HasDefaultValueSql("GETUTCDATE()")
            //.ValueGeneratedOnAddOrUpdate();
        });

        builder.Entity<User>(entity =>
        {
            entity.Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()")
            .ValueGeneratedOnAdd();

            //entity.Property(u => u.UpdatedAt)
            //.HasDefaultValueSql("GETUTCDATE()")
            //.ValueGeneratedOnAddOrUpdate();
        });
    }

    public override int SaveChanges()
    {
        UpdateTimeStamps();
        return base.SaveChanges();
    }
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
    {
        UpdateTimeStamps();
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateTimeStamps()
    {
        var modifiedEntries = ChangeTracker.Entries<TaskItem>().Where(e => e.State == EntityState.Modified);

        foreach(var entry in modifiedEntries)
        {
            entry.Entity.UpdatedAt = DateTime.UtcNow;
        }
    }
}
