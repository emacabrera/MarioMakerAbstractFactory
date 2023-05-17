using AbstractFactory.Abstractions;

namespace AbstractFactory.Models
{
    internal class NintendoDSBloque : Bloque
    {
        public NintendoDSBloque()
        {
            _dimension = "3D";
            _plataforma = "NintendoDS";
        }
    }
}
