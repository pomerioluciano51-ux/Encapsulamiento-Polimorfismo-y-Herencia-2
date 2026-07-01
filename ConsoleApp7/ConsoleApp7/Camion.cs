using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Camion : Vehiculo
{
    private int _ejes;

    public int Ejes
    {
        get { return _ejes; }
        set { _ejes = value; }
    }

    public Camion(string patente, decimal saldo, int ejes)
        : base(patente, saldo)
    {
        _ejes = ejes;
    }

    public override string PagarPeaje(decimal tarifa)
    {
        decimal total = tarifa * _ejes;

        if (_ejes > 4)
        {
            total *= 0.9m;
        }

        if (Saldo >= total)
        {
            Saldo -= total;
            return $"{Patente}: pasó. Tarifa cobrada: ${total}. Saldo restante: ${Saldo}";
        }

        return $"{Patente}: paso denegado.";
    }
}