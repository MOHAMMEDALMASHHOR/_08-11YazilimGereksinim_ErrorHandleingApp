namespace ErrorHandle.Models.Exeptions;
public abstract class NotFoundException : Exception
{
    protected NotFoundException(string message):base(message)
    {

    }
}
public class EmployeeNotFoundException : NotFoundException
{
    public EmployeeNotFoundException(int id) : base($"There is no Employee with the id: {id}!!!!!!!!")
    {
    }
}