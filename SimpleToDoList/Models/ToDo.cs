using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Models;

public class ToDo
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public DateTime UpdatedOn { get; set; } = DateTime.Now;
}
