using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>()
        {
            new Particular("AAA111", 500),
            new Particular("BBB222", 50),
            new Camion("CCC333", 1000, 3),
            new Camion("DDD444", 800, 5)
        };

        decimal tarifa = 100;

        foreach (Vehiculo v in vehiculos)
        {
            Console.WriteLine(v.PagarPeaje(tarifa));
        }
    }
}