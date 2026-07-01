using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aeronave
{
    private int _horasVuelo;

    public int HorasVuelo
    {
        get { return _horasVuelo; }
        set { _horasVuelo = value; }
    }

    public Aeronave(int horasVuelo)
    {
        _horasVuelo = horasVuelo;
    }

    public virtual string GenerarReporteMantenimiento()
    {
        return $"Horas de vuelo: {_horasVuelo}";
    }
}


