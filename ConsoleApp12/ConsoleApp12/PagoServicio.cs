using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PagoServicio : Transaccion
{
    private string _empresa;

    public string Empresa
    {
        get { return _empresa; }
        set { _empresa = value; }
    }

    public PagoServicio(string token, string empresa)
        : base(token)
    {
        _empresa = empresa;
    }

    public override string Procesar()
    {
        if (TokenSeguridad.Length != 8)
        {
            return "Token inválido.";
        }

        return $"Pago de servicio autorizado para {_empresa}";
    }
}


