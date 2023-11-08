namespace StoreAppError.Models;
public abstract class NotFoundException:Exception
{
    public NotFoundException(string message):base(message)
    {
        
    }
}
