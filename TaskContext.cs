using entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework;

public class TaskContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<ToDoTask> Tasks { get; set; }

    public TaskContext(DbContextOptions<TaskContext> options) : base(options){}
}