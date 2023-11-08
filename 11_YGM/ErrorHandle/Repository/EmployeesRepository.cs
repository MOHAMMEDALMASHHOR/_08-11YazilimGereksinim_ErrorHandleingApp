using ErrorHandle.Models;
using ErrorHandle.Models.Exeptions;

namespace ErrorHandle.Repository;
public class EmployeesRepository
{
    private List<Employee> _employees { get; set; }
    public EmployeesRepository()
    {
        this._employees = new List<Employee>(){
            new SeasonalEmployee(1,"Mohammed","Almashhor",50_000),
            new FullTimeEmployee(2,"Manger","Fanger",40_000),
            new SeasonalEmployee(3,"Fakid","Alhadi",20_000),
            new FullTimeEmployee(4,"Ahmed","Yilmaz",30_000)
        };
    }
    public void Addone(Employee employee){
        _employees.Add(employee);
    }
    public List<Employee> GetAll(){
        return _employees;
    }
    public Employee GetOne(int id){
        try
        {
            
        var employee= _employees.SingleOrDefault(emp=>emp.Id.Equals(id));
        if (employee is null)
        {
            throw new EmployeeNotFoundException(id);
        }
        return employee;
        }
        catch(Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }
    /* public Employee GetOne(int id){
        return _employees.SingleOrDefault(emp=>emp.Id.Equals(id));
    } */

    

}