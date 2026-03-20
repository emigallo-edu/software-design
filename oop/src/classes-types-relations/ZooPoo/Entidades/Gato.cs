namespace ZooPoo.Entidades
{
    // El Gato es un Mamifero
    internal class Gato : Mamifero
    {
        private string _comidaFavorita;

        public Gato(string nombre, DateTime nacimiento, string raza, string comidaFavorita)
              : base(nombre, nacimiento, raza)
        {
            _comidaFavorita = comidaFavorita;
        }

        public void Ronronear()
        {
            Console.WriteLine("Estoy ronroneando");
        }

        public void Cazar()
        {
            Console.WriteLine($"Estoy cazando un {_comidaFavorita}");
        }

        public void Trepar()
        {
            Console.WriteLine("Estoy trepando");
        }

        public override void Comunicarse()
        {
            Console.WriteLine("Estoy maullando");
        }
    }
}