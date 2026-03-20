namespace ZooPoo.Entidades
{
    internal class Cotorra : Ave
    {
        public Cotorra(DateTime nacimiento, string raza)
            : base(nacimiento, raza)
        {

        }

        public override void Comunicarse()
        {
            Console.WriteLine("Me estoy comunicando como una cotorra");
        }
    }
}