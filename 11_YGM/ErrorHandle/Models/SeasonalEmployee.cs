namespace ErrorHandle.Models;

public class SeasonalEmployee : Employee
{
    public double SeasonalSalary=>Salary/2;
    public SeasonalEmployee(int id, string? firstName, string? lastName, double salary) : base(id, firstName, lastName, salary)
    {
    }
}
