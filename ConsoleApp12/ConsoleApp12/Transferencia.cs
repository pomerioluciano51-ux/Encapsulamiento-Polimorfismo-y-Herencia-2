
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transferencia : Transaccion
{
    private decimal _monto;
    private string _cuentaDestino;

    public decimal Monto
    {
        get { return _monto; }
        set { _monto = value; }
    }

    public string CuentaDestino
    {
        get { return _cuentaDestino; }
        set { _cuentaDestino = value; }
    }

    public Transferencia(string token, decimal monto, string cuentaDestino)
        : base(token)
    {
        _monto = monto;
        _cuentaDestino = cuentaDestino;
    }

    public override string Procesar()
    {
        if (TokenSeguridad.Length != 8)
        {
            return "Token inválido.";
        }

        if (_monto > 50000)
        {
            return "Requiere autorización presencial";
        }

        return $"Transferencia realizada a {_cuentaDestino} por ${_monto}";
    }
}


