
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Subasta> subastas = new List<Subasta>()
        {
            new SubastaRelampago(1000, 5),
            new SubastaPremium(2000, 500)
        };

        foreach (Subasta s in subastas)
        {
            Console.WriteLine(s.RegistrarOferta(1200));
            Console.WriteLine(s.RegistrarOferta(3000));
            Console.WriteLine();
        }
    }
}