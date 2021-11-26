using System.Linq;
using NUnit.Framework;
using Store.Interfaces;
using Store.Model;

namespace TestStore;

public class TestStore
{
    private Product _fridayProduct;
    private ICatalog _fridayCatalog;
    
    [SetUp]
    public void Setup()
    {
        _fridayCatalog = new InMemoryCatalog(new FridayDate());
        _fridayProduct = _fridayCatalog.GetProducts().First();
    }

    [Test]
    public void Price_increase_50_percent_Saturday()
    {
        var saturdayCatalog = new InMemoryCatalog(new SaturdayDate());
        var saturdayProduct = saturdayCatalog.GetProducts().First();
        
        Assert.AreEqual(_fridayProduct.Price * 1.5m, saturdayProduct.Price);
    }

    [Test]
    public void Price_increase_50_percent_Sunday()
    {
        var sundayCatalog = new InMemoryCatalog(new SundayDate());
        var sundayProduct = sundayCatalog.GetProducts().First();
        
        Assert.AreEqual(_fridayProduct.Price * 1.5m, sundayProduct.Price);
    }
}