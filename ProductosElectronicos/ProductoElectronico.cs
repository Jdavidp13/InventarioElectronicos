namespace ProductosElectronicos
{
    public class ProductoElectronico
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public ProductoElectronico(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Nombre} - ${Precio} - Stock: {Stock}";
        }
    }
}
