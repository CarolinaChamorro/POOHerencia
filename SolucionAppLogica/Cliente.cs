using System;

namespace SolucionAppLogica
{
    public  class Cliente:Persona
    {
        public Cliente():base()
        {}
        Computadora computadora;
        public Computadora Micomputadora
        {
            get
            {
                return computadora;
            }

            set
            {
                computadora = value;
            }
        }
        RelojDigital reloj;
        public RelojDigital Mireloj
        {
            get
            {
                return reloj;
            }

            set
            {
                reloj = value;
            }
        }
        Television tv;

        public Television Mitv
        {
            get
            {
                return tv;
            }

            set
            {
                tv = value;
            }
        }

        Lavadora lavadora;

        public Lavadora Milava
        {
            get
            {
                return lavadora;
            }

            set
            {
                lavadora = value;
            }
        }

        Refrigeradora refrigeradora;

        public Refrigeradora Mirefri
        {
            get
            {
                return refrigeradora;
            }

            set
            {
                refrigeradora= value;
            }
        }

        Celular celular;

        public Celular Micelu
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        //saludar
        public string Saludar( string nombre)
        {
            return $"Buen dia {nombre}, ¿Me podría ayudar?";
        }     
        
    }
}