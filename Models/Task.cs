using System.Text.Json.Serialization;

namespace Task_Manager_API.Models;

public class Task
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
}

