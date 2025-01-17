namespace entity_framework.Models;

public class Category
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int Level { get; set; }
    public virtual ICollection<ToDoTask> Tasks { get; set; } = new List<ToDoTask>();
}