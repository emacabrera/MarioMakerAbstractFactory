using AbstractFactory.Abstractions;

namespace AbstractFactory.Models
{
    internal class GameboyMoneda : Moneda
    {
        public GameboyMoneda()
        {
            _dimension = "2D";
            _plataforma = "Gameboy";
        }
    }
}
