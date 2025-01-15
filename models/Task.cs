namespace entity_framework.Models;
public class Task
{
    public Guid TaskId { get; set; }
    public Guid CategoryId { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public Priority TaskPriority { get; set; }
    public DateTime CreatedDate { get; set; }
    public virtual Category Category { get; set; }

}

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3
}