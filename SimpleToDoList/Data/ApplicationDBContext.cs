using Microsoft.EntityFrameworkCore;
using SimpleToDoList.Models;

namespace SimpleToDoList.Data;
public class ApplicationDBContext :DbContext {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){
        
    }

    public DbSet<ToDo> ToDos { get; set; }
}
