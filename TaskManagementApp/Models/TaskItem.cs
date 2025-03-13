using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementApp.Models;

public enum TaskPriority
{
    Low,
    Medium,
    High
}

public enum TaskStatus
{
    Pending,
    InProgress,
    Completed
}

public class TaskItem
{
    [Key]
    public int TaskId { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    public DateTime DueTime { get; set; }

    public TaskPriority Priority { get; set; } = TaskPriority.Medium;

    public TaskStatus Status { get; set; } = TaskStatus.Pending;


    public DateTime CreatedAt { get; private set; } 

    public DateTime UpdatedAt { get; set; }


    [ForeignKey("CreatedBy")]
    public string CreatedById { get; set; } = string.Empty;
    public virtual User CreatedBy { get; set; } = null!;

    [ForeignKey("AssignedTo")]
    public string? AssignedToId { get; set; }
    public virtual User AssignedTo { get; set; } = null!;

}
