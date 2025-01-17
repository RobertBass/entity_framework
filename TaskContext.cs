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
            category.ToTable("Category");
            category.HasKey(c => c.CategoryId);

            category.Property(c => c.Name).IsRequired().HasMaxLength(150);
            category.Property(c => c.Description);
        });
    }

}