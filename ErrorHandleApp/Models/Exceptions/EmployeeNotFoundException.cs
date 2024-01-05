namespace Models.Exceptions;

public class EmployeeNotFoundExceptions : NotFoundException
{
    public EmployeeNotFoundExceptions(int id) 
    : base($"The full time employee with id:{id}")
    {
    }
}