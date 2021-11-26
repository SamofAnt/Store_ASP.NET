using Store.Interfaces;

namespace Store.Model;

public class InMemoryCatalog:ICatalog
{
    
    private readonly IReadOnlyCollection<Product> _products = new Product[]
    {
        new("Apple", 100m),
        new("Book", 235m),
        new ("Bicycle", 450m)
    };
    private readonly ICurrentDate _currentDate;

    public IReadOnlyCollection<Product> GetProducts()
    {
        var date = _currentDate.GetCurrentDate();
        if (date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            return _products
                .Select(it => it with {Price = it.Price * 1.5m})
                .ToList();
        return _products;
    }
    public InMemoryCatalog(ICurrentDate currentDate)
    {
        _currentDate = currentDate;
    }

}