namespace ExamplesOO.Encapsulamiento
{
    internal class EjemploDeUso
    {
        public void UsoFechaConDatetime()
        {
            FechaConDatetime hoy = new FechaConDatetime(4, 7, 2025);
            Console.WriteLine("Hoy es: " + hoy.ObtenerFormatoCorto());

            hoy.CambiarFecha(31, 2, 2025); // Inválido
            hoy.CambiarFecha(15, 8, 2025); // Válido
            Console.WriteLine("Nueva fecha: " + hoy.ObtenerFormatoCorto());
        }

        public void UsoFechaConEntero()
        {
            FechaConEntero hoy = new FechaConEntero(4, 7, 2025);
            Console.WriteLine("Hoy es: " + hoy.ObtenerFormatoCorto());

            hoy.CambiarFecha(31, 2, 2025); // Inválido
            hoy.CambiarFecha(15, 8, 2025); // Válido
            Console.WriteLine("Nueva fecha: " + hoy.ObtenerFormatoCorto());
        }
    }
}