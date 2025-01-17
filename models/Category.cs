using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework.Models;
[Table("Categories")]
public class Category
{
    //[Key]
    public Guid CategoryId { get; set; }
    //[Required]
    //[MaxLength(150)]
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public virtual ICollection<ToDoTask> Tasks { get; set; }
}