using System.Text.Json;

namespace Models.ErrorModel;

// "{"StatusCode":"200", "Message":"Error message..."}"

public class ErrorDetails
{
    public int StatusCode { get; set; } // 404
    public int Message { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}