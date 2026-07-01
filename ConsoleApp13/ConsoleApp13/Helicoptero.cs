using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Helicoptero : Aeronave
{
    private int _ciclosRotor;

    public int CiclosRotor
    {
        get { return _ciclosRotor; }
        set { _ciclosRotor = value; }
    }

    public Helicoptero(int horasVuelo, int ciclosRotor)
        : base(horasVuelo)
    {
        _ciclosRotor = ciclosRotor;
    }

    public override string GenerarReporteMantenimiento()
    {
        int desgaste = HorasVuelo * _ciclosRotor;

        if (desgaste > 50000)
        {
            return $"Helicóptero - Desgaste: {desgaste} - Alerta: Reemplazo de palas requerido";
        }

        return $"Helicóptero - Desgaste: {desgaste} - Estado normal";
    }
}

