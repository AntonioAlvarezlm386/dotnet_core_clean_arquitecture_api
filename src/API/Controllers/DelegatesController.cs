using Application.Employees.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("v1/[Controller]")]
public class DelegatesController : ControllerBase
{
    private readonly ISender _sender;
    
    public DelegatesController(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Endpoint para mostrar los resulados del primer ejercicio de delegados del curso de Gavin Lon
    /// </summary>
    /// <returns></returns>
    [HttpGet("abstraction-intro", Name = "Delegates")]
    public async Task<IActionResult> Salary()
    {
        var totalSalary = await _sender.Send(new GetEmployeesSalaryQuery());
        return Ok(totalSalary);
    }
}