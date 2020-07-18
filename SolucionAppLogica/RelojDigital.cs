
using System;
using System.Runtime.CompilerServices;

namespace SolucionAppLogica
{
    public class RelojDigital : ProductoTecnologico
    {

        public RelojDigital() : base()
        { }
        public static DateTime Now { get; }
        public RelojDigital(string modelo, string marca, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Costo = costo;
        }


        public string DarLaHora()
        {
            return $" hoy es {DateTime.Now}";
        }
        //tomar pulso
        public string TomarPulso()
        {
            Random pulso = new Random();
            int numeroDePulso = pulso.Next(60, 100);
            return $"su pulso cardiaco es: {numeroDePulso} BPM";
        }
        public new string Encender()
        {
            return $"{this.Modelo} {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{base.Apagar()} {this.Modelo} {base.Apagar()}";
        }
        public  string  ContarPasos( int km)
        {
            return $"En {km} metros ha dado {km*500} ";
        }
        public static string Notificaciones(string app)
        {
            return $"Esta recibiendo notificaciones de {app} en su celular..";
        }
        public virtual string Describir()
        {
            return $"Su equipo de tecnologico {this.Modelo} {this.Marca}  tiene un costo de: {this.Costo}";
        }




    }
}
