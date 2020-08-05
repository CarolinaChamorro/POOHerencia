using System;

namespace SolucionAppLogica
{
    public class Refrigeradora:ProductoElectrodomestico
    {
        public float Peso { get; set; }
        public float ConsumoElectrico{ get; set; }
        public string TipoDeDescongelacion { get; set; }
        public string TipoDeIluminacion { get; set; }

        protected Refrigeradora():base()
        {}
        public Refrigeradora(string modelo, string marca, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Costo = costo;
        }
        public new string Encender()
        {
            return $"{this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{this.Marca} {base.Apagar()} {base.Apagar()}";
        }
        public string AbrirRefri()
        {
            var luz = "LED";
            TipoDeIluminacion = luz;
            return $"abriendo refrigeradora {this.Marca} con iluminación {TipoDeIluminacion}";
        }
        public string Describir()
        {
            Random consumo = new Random();
            int numeroConsumo = consumo.Next(30, 60);
            int numeroPeso = consumo.Next(40, 70);
            ConsumoElectrico = numeroConsumo;
            Peso = numeroPeso;
            var luz = "LED";
            TipoDeIluminacion = luz;
            return $"Su equipo de refrigeración {this.Marca} tiene un peso de {this.Peso} Kg, con un consumo electrico al mes de {this.ConsumoElectrico} kWh y con iluminación {this.TipoDeIluminacion}";
        }

    }
}
