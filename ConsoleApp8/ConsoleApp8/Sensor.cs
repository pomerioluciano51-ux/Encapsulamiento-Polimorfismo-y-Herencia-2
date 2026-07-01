using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sensor
{
    private int _id;
    private string _estado;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Estado
    {
        get { return _estado; }
        set { _estado = value; }
    }

    public Sensor(int id)
    {
        _id = id;
        _estado = "Ok";
    }

    public virtual string EvaluarLectura(double valor)
    {
        return $"Sensor {_id}: {valor} - Estado: {_estado}";
    }
}