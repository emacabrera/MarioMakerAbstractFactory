using AbstractFactory.Abstractions;

namespace AbstractFactory.Models
{
    internal class GameboyBloque : Bloque
    {
        public GameboyBloque()
        {
            _dimension = "2D";
            _plataforma = "Gameboy";
        }
    }
}
