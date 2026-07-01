using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehiculo
{
    private string _patente;
    private decimal _saldo;

    public string Patente
    {
        get { return _patente; }
        set { _patente = value; }
    }

    public decimal Saldo
    {
        get { return _saldo; }
        set { _saldo = value; }
    }

    public Vehiculo(string patente, decimal saldo)
    {
        _patente = patente;
        _saldo = saldo;
    }

    public virtual string PagarPeaje(decimal tarifa)
    {
        if (_saldo >= tarifa)
        {
            _saldo -= tarifa;
            return $"{_patente}: pasó. Saldo restante: ${_saldo}";
        }

        return $"{_patente}: paso denegado.";
    }
}