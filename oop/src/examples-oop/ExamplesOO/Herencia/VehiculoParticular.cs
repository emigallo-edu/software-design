namespace ExamplesOO.Herencia
{
    public class VehiculoParticular : Vehiculo
    {
        private string color;
        private double valorReventa;
        private int duracionComponentes;

        public VehiculoParticular(string marca, string color, double valorReventa, int duracion)
            : base(marca)
        {
            this.color = color;
            this.valorReventa = valorReventa;
            this.duracionComponentes = duracion;
        }

        public override string ObtenerDetalle()
        {
            return $"[Particular] Marca: {marca}, Color: {color}, Reventa: ${valorReventa}, Durabilidad: {duracionComponentes} años";
        }
    }
}