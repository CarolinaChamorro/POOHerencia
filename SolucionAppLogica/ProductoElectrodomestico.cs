
using System;

namespace SolucionAppLogica
{
    public abstract class ProductoElectrodomestico:Producto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        protected ProductoElectrodomestico():base()
        {}
        public void VerListaElectro()
        {
            Console.WriteLine($"-- {this.Modelo} {this.Marca} tiene un costo de: {this.Costo}");
        }
    }
}
