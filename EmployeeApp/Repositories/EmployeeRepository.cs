using Models;

namespace Repositories;

public class EmployeeRepository
{
    private List<Employee> employees;

    public EmployeeRepository()
    {
        this.employees = new List<Employee>()
        {
            new Employee(){Id=1, FirstName="Ebubekir", LastName="Karakurt", Company="EkaCompany"},
            new Employee(){Id=2, FirstName="Melis", LastName="Kara", Company="EkaCompany"},
            new Employee(){Id=3, FirstName="Ahmet", LastName="Dağ", Company="EkaCompany"}
        };
    }


    public List<Employee> GetAllEmployees()
    {
        return employees;
    }

    public Employee GetOneEmployee(int id)
    {
        var entity = employees.Where(b => b.Id.Equals(id)).SingleOrDefault();
        return entity;
    }

    public int AddEmployee(Employee employee)
    {
        var item = employees.Where(b => b.Id.Equals(employee.Id)).SingleOrDefault();
        if (item != null)
            return 0;
        employees.Add(employee);
        return 1;
    }

    public int UpdateEmployee(Employee item, int id)
    {
        for (int i = 0; i < employees.Count(); i++)
        {
            if (employees[i].Id == id)
            {
                employees[i] = item;
                return 1;
            }
        }
        return 0;
    }

    public int DeleteAllEmployees()
    {
        employees.Clear();
        return 1;
    }

    public int DeleteOneEmployee(int id)
    {
        var entity = GetOneEmployee(id);
        if (entity != null)
        {
            employees.Remove(entity);
            return 1;
        }
        return 0;

    }
}