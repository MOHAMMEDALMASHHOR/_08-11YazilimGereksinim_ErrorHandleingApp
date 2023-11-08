namespace ErrorHandleApp.Models.Esception;

public class EmployeeNotFoundEception : NotFoundEception
{
    public EmployeeNotFoundEception(int id) : base($"FullTimeEmployee with id: {id}")
    {
    }
}
