
using System.Runtime.CompilerServices;

namespace SolucionAppLogica
{
    public class Celular:ProductoTecnologico
    {
        public string Almacenamiento { get; set; }
        public string MemoriaRam { get; set; }
        public Celular():base()
        {

        }
        public Celular(string modelo,string marca,string almacenamiento,string memoria,float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Almacenamiento = almacenamiento;
            MemoriaRam = memoria;
            Costo = costo;
        }
        public new string Encender()
        {
            return $"{this.Modelo} {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{this.Modelo} {base.Apagar()} {base.Apagar()}";
        }
        public virtual string Conectar(string red)
        {
            return $"Su celular esta conectado a la red {red}";
        }
        public virtual string Describir()
        {
            return $"Su dispositivo {this.Modelo} {this.Marca} con " +
                $" {this.Almacenamiento} de almacenamiento y {this.MemoriaRam} de memoria Ram, tiene un costo de: {this.Costo}";
        }
        public virtual string Describir(string gama)
        {
            return $"su celular tiene una gama {gama}";
        }
    }
}
