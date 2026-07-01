
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Sensor> sensores = new List<Sensor>()
        {
            new SensorTemperatura(1, 80),
            new SensorPresion(2)
        };

        Console.WriteLine(sensores[0].EvaluarLectura(90));

        Console.WriteLine(sensores[1].EvaluarLectura(10));
        Console.WriteLine(sensores[1].EvaluarLectura(20));
        Console.WriteLine(sensores[1].EvaluarLectura(30));
    }
}
