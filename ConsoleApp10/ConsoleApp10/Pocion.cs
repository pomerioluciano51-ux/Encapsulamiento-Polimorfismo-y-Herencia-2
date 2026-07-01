using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Pocion : ItemMercado
{
    public Pocion(string nombre, decimal precioBase, int stock)
        : base(nombre, precioBase, stock)
    {
    }

    public override string CotizarVenta(int cantidad)
    {
        if (cantidad > Stock)
        {
            decimal total = PrecioBase * Stock;
            return $"{Nombre}: Stock insuficiente. Solo hay {Stock} unidades. Total = ${total}";
        }

        Stock -= cantidad;
        decimal precio = PrecioBase * cantidad;

        return $"{Nombre}: Venta realizada. Total = ${precio}. Stock restante: {Stock}";
    }
}