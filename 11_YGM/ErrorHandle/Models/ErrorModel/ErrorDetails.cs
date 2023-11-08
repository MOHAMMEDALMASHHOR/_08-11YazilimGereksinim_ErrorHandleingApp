using System.Text.Json;

namespace ErrorHandle.Models;
public class ErrorDetails
{
    public int StatusCode { get; set; } //404
    public string? Message { get; set; } //Message...............
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}