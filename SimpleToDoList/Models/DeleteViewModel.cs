
using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Models;

public class DeleteViewModel {
    [Required]
    public ToDo TD { get; set; }

    [RegularExpression("delete")]
    public string DeleteConfirmation { get; set; } = "";
}
