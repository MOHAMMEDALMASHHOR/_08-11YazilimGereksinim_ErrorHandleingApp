using Microsoft.AspNetCore.Mvc;
using ErrorHandle.Models;
using ErrorHandle.Repository;

namespace ErrorHandle.Controllers;
[ApiController]
[Route("/api/employees")]
public class EmployeeController:ControllerBase
{
    private readonly EmployeesRepository employeesRepository;

    public EmployeeController(EmployeesRepository emoplyeesRepository)
    {
        this.employeesRepository = emoplyeesRepository;
    }
    [HttpGet]
    public IActionResult GetAllEmployees(){
       
        return Ok(employeesRepository.GetAll());
    }
    [HttpGet("{id:int}")]
    public IActionResult GetOneEmployee(int id){
        return Ok(employeesRepository.GetOne(id));
    }
    [HttpPost]
    public void AddOneEmpolyee(Employee employee){
        employeesRepository.Addone(employee);
    }
}