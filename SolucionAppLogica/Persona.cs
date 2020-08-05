namespace SolucionAppLogica
{
    public abstract class Persona:GeneradorDeId
    {
        public string Nombre { get; set; }

        public Persona():base()
        {}
    }
}
