using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Transaccion> transacciones = new List<Transaccion>()
        {
            new Transferencia("ABC12345", 30000, "Cuenta001"),
            new Transferencia("XYZ98765", 60000, "Cuenta002"),
            new PagoServicio("SERV2025", "Edenor"),
            new PagoServicio("123", "AySA")
        };

        foreach (Transaccion t in transacciones)
        {
            Console.WriteLine(t.Procesar());
        }
    }
}