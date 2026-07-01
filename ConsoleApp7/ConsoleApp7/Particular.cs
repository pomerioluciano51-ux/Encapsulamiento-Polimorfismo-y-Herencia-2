using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Particular : Vehiculo
{
    public Particular(string patente, decimal saldo)
        : base(patente, saldo)
    {
    }

    public override string PagarPeaje(decimal tarifa)
    {
        if (Saldo < tarifa)
        {
            return $"{Patente}: Paso denegado.";
        }

        return base.PagarPeaje(tarifa);
    }
}

