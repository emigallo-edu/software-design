namespace ZooPoo.Entidades
{
    internal class Aguila : Ave
    {
        public Aguila(DateTime nacimiento, string raza)
            : base(nacimiento, raza)
        {
        }

        public void Cazar()
        {
        }

        public override void Comunicarse()
        {
            Console.WriteLine("Me estoy comunicando como un águila");
        }
    }
}