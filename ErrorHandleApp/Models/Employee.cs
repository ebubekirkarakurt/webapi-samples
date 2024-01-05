namespace Models;

public class Employee : IComparable
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string? firstName, string? lastName, double salary)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public int CompareTo(object? obj)
    {
        return this.Salary.CompareTo(((Employee)obj).Salary);
    }
}