namespace Entities.Models;

public class Employee
{
    public int Id { get; set; }
    public string? FirtName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public string? CompanyName { get; set; }

    public Employee()
    {
        CompanyName = string.Empty;
    }
}