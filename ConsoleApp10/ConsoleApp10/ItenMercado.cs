using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemMercado
{
    private string _nombre;
    private decimal _precioBase;
    private int _stock;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public decimal PrecioBase
    {
        get { return _precioBase; }
        set { _precioBase = value; }
    }

    public int Stock
    {
        get { return _stock; }
        set { _stock = value; }
    }

    public ItemMercado(string nombre, decimal precioBase, int stock)
    {
        _nombre = nombre;
        _precioBase = precioBase;
        _stock = stock;
    }

    public virtual string CotizarVenta(int cantidad)
    {
        decimal total = _precioBase * cantidad;
        return $"{_nombre}: Total = ${total}";
    }
}
