using ExamplesOO.Herencia;

namespace ExamplesOO.Polimorfismo
{
    internal class EjemploDeUso
    {
        public void Usar()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new VehiculoAlquiler("Toyota", 7.5, 65, 300));
            vehiculos.Add(new VehiculoParticular("Ford", "Azul", 18000, 10));
            vehiculos.Add(new VehiculoReparto("Iveco", 1500, 24, 12.0));

            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine(v.ObtenerDetalle());
            }
        }
    }
}