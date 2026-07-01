using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Bateria> baterias = new List<Bateria>()
        {
            new BateriaLitio(30),
            new BateriaSolar(50, 20)
        };

        for (int ronda = 1; ronda <= 3; ronda++)
        {
            Console.WriteLine($"\n--- Ronda {ronda} ---");

            foreach (Bateria bateria in baterias)
            {
                Console.WriteLine(bateria.ConsumirEnergia(20));
            }
        }
    }
}