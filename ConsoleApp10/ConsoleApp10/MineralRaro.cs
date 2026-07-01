using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MineralRaro : ItemMercado
{
    private decimal _factorEscasez;

    public decimal FactorEscasez
    {
        get { return _factorEscasez; }
        set { _factorEscasez = value; }
    }

    public MineralRaro(string nombre, decimal precioBase, int stock, decimal factorEscasez)
        : base(nombre, precioBase, stock)
    {
        _factorEscasez = factorEscasez;
    }

    public override string CotizarVenta(int cantidad)
    {
        decimal precioUnitario = PrecioBase;

        if (Stock < 5)
        {
            precioUnitario *= _factorEscasez;
        }

        if (cantidad > Stock)
        {
            cantidad = Stock;
        }

        decimal total = precioUnitario * cantidad;
        Stock -= cantidad;

        string mensaje = $"{Nombre}: Total = ${total}. Stock restante: {Stock}";

        if (Stock < 5)
        {
            mensaje += " ¡Precio inflado por alta demanda!";
        }

        return mensaje;
    }
}

