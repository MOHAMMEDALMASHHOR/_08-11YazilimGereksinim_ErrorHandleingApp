namespace ErrorHandleApp.Models.Esception;

public abstract class NotFoundEception:Exception
{
    protected NotFoundEception(string message):base(message)
    {
        
    }
}
