namespace ExamplesOO.Herencia
{
    internal class EjemploDeUso
    {
        public void Usar()
        {
            VehiculoAlquiler v1 = new VehiculoAlquiler("Toyota", 7.5, 65, 300);
            VehiculoParticular v2 = new VehiculoParticular("Ford", "Azul", 18000, 10);
            VehiculoReparto v3 = new VehiculoReparto("Iveco", 1500, 24, 12.0);

            Console.WriteLine(v1.ObtenerDetalle());
            Console.WriteLine(v2.ObtenerDetalle());
            Console.WriteLine(v3.ObtenerDetalle());
        }
    }
}