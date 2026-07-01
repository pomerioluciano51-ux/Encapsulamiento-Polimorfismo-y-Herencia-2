using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SubastaRelampago : Subasta
{
    private int _tiempoRestanteSegundos;

    public int TiempoRestanteSegundos
    {
        get { return _tiempoRestanteSegundos; }
        set { _tiempoRestanteSegundos = value; }
    }

    public SubastaRelampago(decimal precioActual, int tiempoRestanteSegundos)
        : base(precioActual)
    {
        _tiempoRestanteSegundos = tiempoRestanteSegundos;
    }

    public override string RegistrarOferta(decimal oferta)
    {
        if (TiempoRestanteSegundos < 10)
        {
            TiempoRestanteSegundos += 30;

            if (oferta > PrecioActual)
            {
                PrecioActual = oferta;
                return $"¡Oferta de último segundo! Tiempo extendido. Nueva oferta: ${oferta}";
            }

            return "Oferta rechazada";
        }

        return base.RegistrarOferta(oferta);
    }
}