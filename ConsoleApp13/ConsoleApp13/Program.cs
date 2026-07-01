using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Aeronave> aeronaves = new List<Aeronave>()
        {
            new AvionComercial(12000, 180),
            new AvionComercial(8000, 120),
            new Helicoptero(300, 200),
            new Helicoptero(100, 100)
        };

        foreach (Aeronave a in aeronaves)
        {
            Console.WriteLine(a.GenerarReporteMantenimiento());
        }
    }
}