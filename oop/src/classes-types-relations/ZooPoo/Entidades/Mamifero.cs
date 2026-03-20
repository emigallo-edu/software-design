namespace ZooPoo.Entidades
{
    // Un mamífero es un Animal
    internal abstract class Mamifero : Animal
    {
        protected string _nombre;

        protected Mamifero(string nombre, DateTime nacimiento, string raza)
            : base(nacimiento, raza)
        {
            _nombre = nombre;
        }

        public void Caminar()
        {
            Console.WriteLine("Estoy caminando como mamífero");
        }

        public virtual void Presentarse()
        {
            int edad = (int)(DateTime.Today - _nacimiento).TotalDays / 365;
            Console.WriteLine($"Hola, soy {_nombre} y tengo {edad} años");
        }
    }
}