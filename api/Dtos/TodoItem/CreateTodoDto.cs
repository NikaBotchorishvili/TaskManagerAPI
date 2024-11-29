using System.Text.Json.Serialization;

namespace api.Dtos.TodoItem;

public class CreateTodoDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }

    public bool Completed { get; set; } = false;
}