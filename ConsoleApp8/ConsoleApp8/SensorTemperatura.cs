using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SensorTemperatura : Sensor
{
    private double _limiteCritico;

    public double LimiteCritico
    {
        get { return _limiteCritico; }
        set { _limiteCritico = value; }
    }

    public SensorTemperatura(int id, double limiteCritico)
        : base(id)
    {
        _limiteCritico = limiteCritico;
    }

    public override string EvaluarLectura(double valor)
    {
        string mensaje = $"Sensor {Id}: {valor} - Estado: {Estado}";

        if (valor > _limiteCritico)
        {
            Estado = "Peligro";
            mensaje = $"Sensor {Id}: {valor} - Estado: {Estado}";
            return mensaje.ToUpper();
        }

        return mensaje;
    }
}
