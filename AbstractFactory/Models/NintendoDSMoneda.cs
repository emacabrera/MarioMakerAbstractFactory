using AbstractFactory.Abstractions;

namespace AbstractFactory.Models
{
    internal class NintendoDSMoneda : Moneda
    {
        public NintendoDSMoneda()
        {
            _dimension = "3D";
            _plataforma = "NintendoDS";
        }
    }
}
