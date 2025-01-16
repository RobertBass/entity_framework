using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework.Models;
[Table("Tasks")]
public class ToDoTask
{
    [Key]
    public Guid TaskId { get; set; }
    [ForeignKey("CategoryId")]
    public Guid CategoryId { get; set; }
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public Priority TaskPriority { get; set; }
    public DateTime CreatedDate { get; set; }
    public virtual Category Category { get; set; }
    [NotMapped]
    public string Resumen { get; set; } = "";

}

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3
}