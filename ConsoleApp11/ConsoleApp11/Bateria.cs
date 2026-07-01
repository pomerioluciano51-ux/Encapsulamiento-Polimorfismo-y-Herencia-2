using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bateria
{
    private int _porcentajeCarga;

    public int PorcentajeCarga
    {
        get { return _porcentajeCarga; }
        set
        {
            if (value < 0)
                _porcentajeCarga = 0;
            else if (value > 100)
                _porcentajeCarga = 100;
            else
                _porcentajeCarga = value;
        }
    }

    public Bateria(int porcentajeCarga)
    {
        PorcentajeCarga = porcentajeCarga;
    }

    public virtual string ConsumirEnergia(int puntos)
    {
        PorcentajeCarga -= puntos;
        return $"Carga restante: {PorcentajeCarga}%";
    }
}




