using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductosElectronicos
{
    public class Inventario
    {
        public List<ProductoElectronico> Productos { get; private set; }

        public Inventario()
        {
            Productos = new List<ProductoElectronico>();
        }

        public bool AgregarProducto(ProductoElectronico producto)
        {
            if (producto != null)
            {
                Productos.Add(producto);
                Console.WriteLine($"Producto agregado: {producto}");
                return true;
            }
            return false;
        }

        public bool VenderProducto(string nombre, int cantidad)
        {
            var producto = Productos.FirstOrDefault(p => p.Nombre.ToLower() == nombre.ToLower());
            if (producto != null && producto.Stock >= cantidad)
            {
                producto.Stock -= cantidad;
                Console.WriteLine($"Venta realizada: {cantidad} de {producto.Nombre}");
                return true;
            }
            return false;
        }
    }
}
