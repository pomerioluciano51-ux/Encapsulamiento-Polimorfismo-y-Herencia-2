using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SubastaPremium : Subasta
{
    private decimal _montoMinimoIncremento;

    public decimal MontoMinimoIncremento
    {
        get { return _montoMinimoIncremento; }
        set { _montoMinimoIncremento = value; }
    }

    public SubastaPremium(decimal precioActual, decimal montoMinimoIncremento)
        : base(precioActual)
    {
        _montoMinimoIncremento = montoMinimoIncremento;
    }

    public override string RegistrarOferta(decimal oferta)
    {
        if (oferta >= PrecioActual + MontoMinimoIncremento)
        {
            PrecioActual = oferta;
            return $"Oferta aceptada: ${oferta}";
        }

        return $"Oferta rechazada. Debe superar ${PrecioActual + MontoMinimoIncremento}";
    }
}

