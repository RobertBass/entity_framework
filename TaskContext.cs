using entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework;

public class TaskContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<ToDoTask> Tasks { get; set; }

    public TaskContext(DbContextOptions<TaskContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(category => 
        {
            category.ToTable("Categories");
            category.HasKey(c => c.CategoryId);

            category.Property(c => c.Name).IsRequired().HasMaxLength(150);
            category.Property(c => c.Description);
            category.Property(c => c.Level);
        });

        modelBuilder.Entity<ToDoTask>(task =>
        {
            task.ToTable("Tasks");
            task.HasKey(t => t.TaskId);
            task.HasOne(t => t.Category).WithMany(c => c.Tasks).HasForeignKey(c => c.CategoryId);

            task.Property(t => t.Title).IsRequired().HasMaxLength(200);
            task.Property(t => t.Description);
            task.Property(t => t.TaskPriority);
            task.Property(t => t.CreatedDate);
            task.Ignore(t => t.Resumen);
        });
    }

}