namespace StoreAppError.Models;

public class Product : IComparable
{
    public int Id { get; set; }
    public string? ProdctName { get; set; }
    public double Price { get; set; }
    public int CompareTo(object? obj)
    {
        return this.Price.CompareTo(((Product)obj).Price);
    }
}