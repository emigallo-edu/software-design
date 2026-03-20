namespace ExamplesOO.Abstraccion
{
    internal class EjemploDeUso
    {
        public void Usar()
        {
            VehiculoAlquiler alquiler = new VehiculoAlquiler("Toyota", 7.5, 65, 300);
            VehiculoParticular particular = new VehiculoParticular("Ford", "Azul", 18000, 10);
            VehiculoReparto reparto = new VehiculoReparto("Iveco", 1500, 24, 12.0);

            Console.WriteLine(alquiler.ObtenerDetalle());
            Console.WriteLine(particular.ObtenerDetalle());
            Console.WriteLine(reparto.ObtenerDetalle());
        }
    }
}