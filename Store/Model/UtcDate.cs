using Store.Interfaces;

namespace Store.Model;

public class UtcDate:ICurrentDate
{
    public DateTime GetCurrentDate() => DateTime.UtcNow;
}