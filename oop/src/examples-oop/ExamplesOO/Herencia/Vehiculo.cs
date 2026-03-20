namespace ExamplesOO.Herencia
{
    public class Vehiculo
    {
        protected string marca;

        public Vehiculo(string marca)
        {
            this.marca = marca;
        }

        public virtual string ObtenerDetalle()
        {
            return $"Marca: {marca}";
        }
    }
}