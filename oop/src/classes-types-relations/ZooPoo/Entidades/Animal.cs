namespace ZooPoo.Entidades
{
    internal abstract class Animal
    {
        protected DateTime _nacimiento;
        private string _raza;

        protected Animal(DateTime nacimiento, string raza)
        {
            if (nacimiento >= DateTime.Today)
            {
                // Arrojo un error
            }

            if (raza == "")
            {
                // Arrojo un error
            }
            _nacimiento = nacimiento;
            _raza = raza;
        }

        public abstract void Comunicarse();
    }
}