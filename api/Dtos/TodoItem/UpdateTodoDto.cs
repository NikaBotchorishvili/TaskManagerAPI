namespace api.Dtos.TodoItem;

public class UpdateTodoDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public bool Completed { get; set; }
}