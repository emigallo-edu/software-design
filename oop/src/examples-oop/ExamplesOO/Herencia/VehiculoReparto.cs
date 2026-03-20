namespace ExamplesOO.Herencia
{
    public class VehiculoReparto : Vehiculo
    {
        private double cargaMaxima;
        private int garantiaMeses;
        private double consumo;

        public VehiculoReparto(string marca, double carga, int garantia, double consumo)
            : base(marca)
        {
            this.cargaMaxima = carga;
            this.garantiaMeses = garantia;
            this.consumo = consumo;
        }

        public override string ObtenerDetalle()
        {
            return $"[Reparto] Marca: {marca}, Carga: {cargaMaxima} kg, Garantía: {garantiaMeses} meses, Consumo: {consumo} L/100km";
        }
    }
}