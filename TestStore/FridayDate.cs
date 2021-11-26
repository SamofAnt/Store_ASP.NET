using System;
using Store.Interfaces;

namespace TestStore;

public class FridayDate:ICurrentDate
{
    public DateTime GetCurrentDate() => new DateTime(2021, 11, 26);
}