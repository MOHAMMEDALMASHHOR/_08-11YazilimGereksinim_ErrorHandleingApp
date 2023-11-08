using StoreAppError.Models;

namespace StoreAppError.Repository;
public class ProductRepository
{
    private List<Product> _products;
    public ProductRepository()
    {
        _products = new List<Product>(){
            new Product(){Id =1, ProdctName = "Computer", Price =20_000},
            new Product(){Id =2, ProdctName = "Phone", Price =50_000},
            new Product(){Id =3, ProdctName = "Laptop", Price =60_000},
            new Product(){Id =4, ProdctName = "Fold", Price =80_000},
        };
    }
    public void Add(Product product){
        _products.Add(product);
    }
    public List<Product> GetAllProducts(){
        return _products;
    }
    public Product GetOneProduct(int id){
        try
        {
            
        var product =_products.SingleOrDefault(pro=>pro.Id.Equals(id));
        if (product is null)
        {
            
            throw new ProductNotFoundException(id);
        }
        return product;
        }
        catch (System.Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
        // foreach (var item in _products)
        // {
        //     if (item.Id.Equals(id))
        //     {
        //         return item;
        //     }
        // }
        // throw new Exception();
    }
    /* public Product GetOneProduct(int id){
        return _products.Single(pro=>pro.Id.Equals(id));
        // foreach (var item in _products)
        // {
        //     if (item.Id.Equals(id))
        //     {
        //         return item;
        //     }
        // }
        // throw new Exception();
    } */
}