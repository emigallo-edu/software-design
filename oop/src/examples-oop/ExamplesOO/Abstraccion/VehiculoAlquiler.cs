namespace ExamplesOO.Abstraccion
{
    class VehiculoAlquiler
    {
        private string marca;
        private double consumo;
        private double tarifaDiaria;
        private int limiteKm;

        public VehiculoAlquiler(string marca, double consumo, double tarifa, int limiteKm)
        {
            this.marca = marca;
            this.consumo = consumo;
            this.tarifaDiaria = tarifa;
            this.limiteKm = limiteKm;
        }

        public string ObtenerDetalle()
        {
            return $"[Alquiler] Marca: {marca}, Tarifa: ${tarifaDiaria}/día, Límite: {limiteKm} km, Consumo: {consumo} L/100km";
        }
    }
}