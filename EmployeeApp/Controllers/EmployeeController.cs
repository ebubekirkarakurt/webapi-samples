using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;

namespace Controllers;

[ApiController]
[Route("api/employee")]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;

    private readonly EmployeeRepository _repo;

    public EmployeeController(ILogger<EmployeeController> logger, EmployeeRepository repository)
    {
        _logger = logger;
        _repo = repository;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        _logger.LogInformation("GetAllEmployees has been called.");
        return Ok(_repo.GetAllEmployees());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOneEmployee(int id)
    {
        _logger.LogInformation($"GetOneEmployee with {id} has been called.");
        return Ok(_repo.GetOneEmployee(id));
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        _logger.LogInformation($"AddEmployee has been called.");
        return Ok(_repo.AddEmployee(employee));
    }

    [HttpPut]
    public IActionResult UpdateEmployee(int id, Employee employee)
    {
        _logger.LogInformation($"UpdateOneEmployee with {id} has been called.");
        var result = _repo.UpdateEmployee(employee, id);
        return result == 0 ? NotFound("Employee not found!") : Ok("Employee successfully updated!");
    }

    [HttpDelete]
    public IActionResult DeleteAllEmployees()
    {
        _logger.LogInformation($"AllEmployees deleted.");
        return Ok(_repo.DeleteAllEmployees());
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteOneEmployee(int id)
    {
        _logger.LogInformation($"DeleteOneEmployee with {id} has been called.");
        return Ok(_repo.DeleteOneEmployee(id));
    }
}