namespace StoreAppError.Models;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(int id) : base($"There is now product with the id: {id}")
    {
    }
}