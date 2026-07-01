using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaccion
{
    private string _tokenSeguridad;

    public string TokenSeguridad
    {
        get { return _tokenSeguridad; }
        set { _tokenSeguridad = value; }
    }

    public Transaccion(string tokenSeguridad)
    {
        _tokenSeguridad = tokenSeguridad;
    }

    public virtual string Procesar()
    {
        if (_tokenSeguridad.Length != 8)
        {
            return "Token inválido.";
        }

        return "Transacción autorizada.";
    }
}
