using System.Text.Json.Serialization;

namespace Task_Manager_API.dtos.Task;

public class CreateTaskDto
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
}