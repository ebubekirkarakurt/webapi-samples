using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;

namespace Controllers;

[ApiController]
[Route("api/employee")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeRepository _employeeRepo;

    public EmployeeController(EmployeeRepository employeeRepository)
    {
        _employeeRepo = employeeRepository;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        return Ok(_employeeRepo.GetAllEmployees());
    }

    [HttpGet("id:int")]
    public IActionResult GetOneEmployee(int id)
    {
        return Ok(_employeeRepo.GetOneEmployee(id));
    }

    [HttpPost]
    public IActionResult CreateEmployee(Employee emp)
    {
        return Ok(_employeeRepo.AddEmployee(emp));
    }
}