using Models;
using Models.Exceptions;

namespace Repositories;

public class EmployeeRepository
{

    private readonly List<Employee> _employees;

    public EmployeeRepository()
    {
        _employees = new List<Employee>(){
            new FullTimeEmployee(1,"Ebubekir", "Karakurt", 5000 ),
            new FullTimeEmployee(2,"Mehmet", "Irmak", 5500 ),
            new SeasonalEmployee(3,"Pala", "Çöl", 6000 ),
            new SeasonalEmployee(4,"Polat", "Alemdar", 9000 )
        };
    }

    public List<Employee> GetAllEmployees()
    {
        return _employees;
    }

    public Employee GetOneEmployee(int id)
    {
        try
        {
            var entity = _employees.Where(b => b.Id.Equals(id)).SingleOrDefault();
            if (entity == null)
                throw new EmployeeNotFoundExceptions(id);
            return entity;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public int AddEmployee(Employee emp)
    {
        _employees.Add(emp);
        return 1;
    }
}