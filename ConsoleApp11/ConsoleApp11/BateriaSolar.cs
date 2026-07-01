using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BateriaSolar : Bateria
{
    private int _eficienciaPanel;

    public int EficienciaPanel
    {
        get { return _eficienciaPanel; }
        set { _eficienciaPanel = value; }
    }

    public BateriaSolar(int porcentajeCarga, int eficienciaPanel)
        : base(porcentajeCarga)
    {
        _eficienciaPanel = eficienciaPanel;
    }

    public override string ConsumirEnergia(int puntos)
    {
        PorcentajeCarga -= puntos;

        int recuperado = puntos * _eficienciaPanel / 100;
        PorcentajeCarga += recuperado;

        return $"Batería Solar: consumió {puntos}, recuperó {recuperado}. Carga restante: {PorcentajeCarga}%";
    }
}

