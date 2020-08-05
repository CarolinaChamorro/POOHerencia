namespace SolucionAppLogica
{
    public abstract class Producto:GeneradorDeId
    {
        protected Producto():base()
        {}
        public virtual string Encender()
        {
            return $"encendiendo ";
        }
        public virtual string Apagar()
        {
            return $"apagando ";
        }
    }
}
