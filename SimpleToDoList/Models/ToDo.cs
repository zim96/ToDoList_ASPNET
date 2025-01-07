using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Models;

public enum StatusType {
    LATER,
    DOING,
    DONE
}
public class ToDo
{
    [Key]
    public int Id { get; set; }
    public StatusType Status { get; set; } = (int) StatusType.LATER;
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public DateTime UpdatedOn { get; set; } = DateTime.Now;
}
