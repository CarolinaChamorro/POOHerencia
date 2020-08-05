using System;

namespace SolucionAppLogica
{
    public abstract class GeneradorDeId
    {
        private int id;
        private readonly Random generador = new Random();
        public  int Id { get { return id; } set { id = value; } }

        protected GeneradorDeId()
        {
            this.Id = generador.Next();
        }
        protected GeneradorDeId(int id)
        {
           this.Id = id;
        }
    }
}
