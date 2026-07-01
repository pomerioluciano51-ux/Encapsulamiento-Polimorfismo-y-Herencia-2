using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BateriaLitio : Bateria
{
    private bool _modoAhorro;

    public BateriaLitio(int porcentajeCarga)
        : base(porcentajeCarga)
    {
        _modoAhorro = false;
    }

    public override string ConsumirEnergia(int puntos)
    {
        if (_modoAhorro)
        {
            puntos /= 2;
        }

        PorcentajeCarga -= puntos;

        if (PorcentajeCarga == 0)
        {
            _modoAhorro = true;
            return "Batería agotada. Modo ahorro de energía activado.";
        }

        return $"Batería Litio: carga restante {PorcentajeCarga}%";
    }
}

