

using System;

namespace SolucionAppLogica
{
    public abstract class ProductoTecnologico : Producto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        protected ProductoTecnologico() : base()
        { }
        public void VerListaTecno()
        {
            Console.WriteLine($"-- {this.Modelo} {this.Marca}  tiene un costo de: {this.Costo}");
        }

    }
}
