using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Subasta
{
    private decimal _precioActual;

    public decimal PrecioActual
    {
        get { return _precioActual; }
        set { _precioActual = value; }
    }

    public Subasta(decimal precioActual)
    {
        _precioActual = precioActual;
    }

    public virtual string RegistrarOferta(decimal oferta)
    {
        if (oferta > _precioActual)
        {
            _precioActual = oferta;
            return $"Oferta aceptada: ${oferta}";
        }

        return "Oferta rechazada";
    }
}
