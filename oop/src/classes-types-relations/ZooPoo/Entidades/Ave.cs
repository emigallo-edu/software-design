namespace ZooPoo.Entidades
{
    // El Ave es un Animal
    internal abstract class Ave : Animal
    {

        protected Ave(DateTime nacimiento, string raza)
            : base(nacimiento, raza)
        {

        }

        public void Volar()
        {
            Console.WriteLine("Estoy volando");
        }
    }
}