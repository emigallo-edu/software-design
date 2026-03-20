namespace ExamplesOO.Abstraccion
{
    class VehiculoReparto
    {
        private string marca;
        private double cargaMaxima;
        private int garantiaMeses;
        private double consumo;

        public VehiculoReparto(string marca, double carga, int garantia, double consumo)
        {
            this.marca = marca;
            this.cargaMaxima = carga;
            this.garantiaMeses = garantia;
            this.consumo = consumo;
        }

        public string ObtenerDetalle()
        {
            return $"[Reparto] Marca: {marca}, Carga: {cargaMaxima} kg, Garantía: {garantiaMeses} meses, Consumo: {consumo} L/100km";
        }
    }
}