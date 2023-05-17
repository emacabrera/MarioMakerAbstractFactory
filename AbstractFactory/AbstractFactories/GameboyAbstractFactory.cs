using AbstractFactory.Abstractions;
using AbstractFactory.Models;

namespace AbstractFactory.AbstractFactories
{
    public class GameboyAbstractFactory : IItemFactory
    {
        public Bloque CrearBloque()
        {
            return new GameboyBloque();
        }

        public Moneda CrearMoneda()
        {
            return new GameboyMoneda();
        }
    }
}
