using System;


namespace SolucionAppLogica
{
    public  class GeneradorDeId
    {
        private readonly Random generador = new Random();
        public  int Id { get; set; }

        protected GeneradorDeId()
        {
            this.Id = generador.Next();
        }
        protected GeneradorDeId(int id)
        {
           this.Id = id;
        }
        protected GeneradorDeId(string id)
            
        {
            this.Id = Convert.ToInt32(id);
          
        }
    }
}
