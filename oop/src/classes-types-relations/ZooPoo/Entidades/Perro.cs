namespace ZooPoo.Entidades
{
    // El Perro es un Mamifero
    internal class Perro : Mamifero
    {
        private Juguete _juegueteFavorito;
        private Ojo _ojoDerecho;
        private Ojo _ojoIzquierdo;

        public Perro(string nombre, DateTime nacimiento, string raza)
            : base(nombre, nacimiento, raza)
        {
            // El perro esta conformado (composición) por 1 ojo derecho y 1 ojo izquierdo
            _ojoDerecho = new Ojo() { Color = "Marrón" };
            _ojoIzquierdo = new Ojo() { Color = "Celeste" };
        }

        // El perro está asociado a un juguete
        public void SetearJugueteFavorito(Juguete juguete)
        {
            _juegueteFavorito = juguete;
        }

        // El perro usa a la persona solo para pasear
        public void SalirAPAsear(Persona persona)
        {
            Console.WriteLine($"Estoy paseando con {persona.Nombre}");
        }

        public void Olfatear()
        {
            if (_juegueteFavorito != null)
            {
                Console.WriteLine("No quiero olfatear porque estoy jugando");
            }
            else
            {
                Console.WriteLine("Estoy olfateando");
            }
        }

        public void Jugar()
        {
            if (_juegueteFavorito != null)
            {
                Console.WriteLine($"Estoy jugando con un {_juegueteFavorito}");
            }
            else
            {
                Console.WriteLine("No puedo jugar porque no tengo un jueguete");
            }
        }

        public override void Comunicarse()
        {
            Console.WriteLine("Estoy ladrando");
        }

        public void MoverLaCola()
        {
        }

        public override void Presentarse()
        {
            int edad = (int)(DateTime.Today - _nacimiento).TotalDays / 365;
            Console.WriteLine($"Hola, soy {_nombre} y tengo {edad * 7} años");
        }

        public void Pestañar()
        {
            _ojoDerecho.Pestañar();
            _ojoIzquierdo.Pestañar();
        }
    }
}