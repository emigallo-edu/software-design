namespace ExamplesOO.Abstraccion
{
    class VehiculoParticular
    {
        private string marca;
        private string color;
        private double valorReventa;
        private int duracionComponentes; // en años

        public VehiculoParticular(string marca, string color, double valorReventa, int duracion)
        {
            this.marca = marca;
            this.color = color;
            this.valorReventa = valorReventa;
            this.duracionComponentes = duracion;
        }

        public string ObtenerDetalle()
        {
            return $"[Particular] Marca: {marca}, Color: {color}, Reventa: ${valorReventa}, Durabilidad: {duracionComponentes} años";
        }
    }
}