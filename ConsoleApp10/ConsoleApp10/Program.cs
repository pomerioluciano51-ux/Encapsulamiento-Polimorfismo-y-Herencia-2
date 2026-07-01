using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<ItemMercado> items = new List<ItemMercado>()
        {
            new Pocion("Pocion Vida", 50, 15),
            new MineralRaro("Cristal Magico", 100, 4, 1.5m)
        };

        foreach (ItemMercado item in items)
        {
            Console.WriteLine(item.CotizarVenta(10));
        }
    }
}
