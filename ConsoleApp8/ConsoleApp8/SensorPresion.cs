using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SensorPresion : Sensor
{
    private List<double> _historialLecturas;

    public List<double> HistorialLecturas
    {
        get { return _historialLecturas; }
        set { _historialLecturas = value; }
    }

    public SensorPresion(int id)
        : base(id)
    {
        _historialLecturas = new List<double>();
    }

    public override string EvaluarLectura(double valor)
    {
        _historialLecturas.Add(valor);

        string mensaje = $"Sensor {Id}: {valor} - Estado: {Estado}";

        if (_historialLecturas.Count >= 3)
        {
            int n = _historialLecturas.Count;

            if (_historialLecturas[n - 3] <
                _historialLecturas[n - 2] &&
                _historialLecturas[n - 2] <
                _historialLecturas[n - 1])
            {
                mensaje += " - Tendencia inestable";
            }
        }

        return mensaje;
    }
}