using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AvionComercial : Aeronave
{
    private int _pasajerosMaximos;

    public int PasajerosMaximos
    {
        get { return _pasajerosMaximos; }
        set { _pasajerosMaximos = value; }
    }

    public AvionComercial(int horasVuelo, int pasajerosMaximos)
        : base(horasVuelo)
    {
        _pasajerosMaximos = pasajerosMaximos;
    }

    public override string GenerarReporteMantenimiento()
    {
        string reporte =
            $"Avión Comercial - Horas: {HorasVuelo} - Capacidad: {_pasajerosMaximos} pasajeros";

        if (HorasVuelo > 10000)
        {
            reporte += " - Revisión de Turbinas";
        }

        return reporte;
    }
}



