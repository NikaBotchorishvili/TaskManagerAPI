using Microsoft.EntityFrameworkCore;
using Task_Manager_API.Models;
namespace Task_Manager_API;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
        
    }
    
    public DbSet<Models.Task> Tasks { get; set; }
}