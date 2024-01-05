using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("api/employee")]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly RepositoryContext _repositoryContext;

    public EmployeeController(ILogger<EmployeeController> logger, RepositoryContext repositoryContext)
    {
        _logger = logger;
        _repositoryContext = repositoryContext;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        _logger.LogInformation("AllEmployees has been listed.");
        return Ok(_repositoryContext.Employees.ToList());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOneEmployee(int id)
    {
        _logger.LogInformation("OneEmployees has been listed.");
        var entity = _repositoryContext.Employees
            .Where(b => b.Id.Equals(id))
            .SingleOrDefault();
        return Ok(entity);
    }

    [HttpPost]
    public IActionResult CreateEmployee(Employee employee)
    {
        if (employee.Equals(null))
            return BadRequest();
        _repositoryContext.Employees.Add(employee);
        _repositoryContext.SaveChanges();
        return Created("Chat created!", employee);
    }

}