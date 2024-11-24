using Json.More;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Task_Manager_API.dtos.Task;
using Task = Task_Manager_API.Models.Task;

namespace Task_Manager_API.Controllers;

[Route("api/tasks")]
[ApiController]
[Tags("Tasks")]
public class TaskController(Context context) : ControllerBase
{
    [HttpGet]
    [SwaggerOperation(Summary ="Returns a List of tasks", Description = "Returns a List of tasks")]
    public async Task<List<Task>> GetAll([FromQuery] string? ordering)
    {
    
        List<Task> tasks = await context.Tasks.ToListAsync();
        return tasks;
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create a task using this endpoint")]
    public async Task<Task> CreateTask([FromBody] CreateTaskDto createTask)
    {
        var task = new Task
        {
            Title = createTask.Title
        };
        context.Tasks.Add(task);
        await context.SaveChangesAsync();

        return task;
    }
}