using System;

namespace SolucionAppLogica
{
   public  class Television:ProductoElectrodomestico
    {
        public Television():base()
        {}

        public Television(string modelo, string marca, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Costo = costo;
        }
        public new string Encender()
        {
            return $" {this.Modelo} {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{this.Modelo} {base.Apagar()} {base.Apagar()}";
        }
        public  string Conectar(string red)
        {
            return $"Conectando se a {red}";
        }
        public  string Funciones(string funcion)
        {
            return $"su Smart esta {funcion}";
        }
        public virtual string Describir()
        {
            return $"Su equipo tecnologico {this.Modelo} {this.Marca}  tiene un costo de: {this.Costo}";
        }
    }
}
