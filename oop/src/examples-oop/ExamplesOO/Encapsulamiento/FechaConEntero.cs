namespace ExamplesOO.Encapsulamiento
{
    internal class FechaConEntero
    {
        // Atributos privados (estado interno)
        private int dia;
        private int mes;
        private int anio;

        // Constructor
        public FechaConEntero(int dia, int mes, int anio)
        {
            if (EsFechaValida(dia, mes, anio))
            {
                this.dia = dia;
                this.mes = mes;
                this.anio = anio;
            }
            else
            {
                throw new ArgumentException("Fecha inválida.");
            }
        }

        // Métodos públicos (interfaz segura)
        public string ObtenerFormatoCorto()
        {
            return $"{dia:D2}/{mes:D2}/{anio}";
        }

        public void CambiarFecha(int nuevoDia, int nuevoMes, int nuevoAnio)
        {
            if (EsFechaValida(nuevoDia, nuevoMes, nuevoAnio))
            {
                dia = nuevoDia;
                mes = nuevoMes;
                anio = nuevoAnio;
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }
        }

        // Método privado de validación
        private bool EsFechaValida(int d, int m, int a)
        {
            return d >= 1 && d <= 31 && m >= 1 && m <= 12 && a >= 1;
        }
    }

}
