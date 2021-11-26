using System;
using Store.Interfaces;

namespace TestStore;

public class SundayDate:ICurrentDate
{
    public DateTime GetCurrentDate() => new DateTime(2021, 11, 28);

}