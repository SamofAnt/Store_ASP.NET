using Store.Model;

namespace Store.Interfaces;

public interface ICatalog
{
    public IReadOnlyCollection<Product> GetProducts();
}