using ErrorHandleApp.Models;
using ErrorHandleApp.Models.Esception;

namespace ErrorHandleApp.Repositories;
public class EmployeeRepository
{
    private List<Employee> _employees;
    public EmployeeRepository()
    {
        _employees = new List<Employee>(){
            new FullTimeEmployee(1,"Ahmed","Can",50_000),
            new FullTimeEmployee(2,"Ali","Tan",60_000),
            new SeasonalEmployee(3,"Hmed","Can",70_000),

        };
    }
    public void Add(Employee item){
        _employees.Add(item);
    }
    public List<Employee> GetAllEmployees(){
        return _employees;
    }
    public Employee GetOneEmployee(int id){
        try{

        var employee = _employees.SingleOrDefault(emp=>emp.Id.Equals(id));
        if (employee is null)
        {
            throw new EmployeeNotFoundEception(id);
        }
        return employee;
        }
        catch{
            throw new EmployeeNotFoundEception(id);
        }
    }
}