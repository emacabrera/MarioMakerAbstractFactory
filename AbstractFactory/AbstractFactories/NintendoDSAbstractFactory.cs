using AbstractFactory.Abstractions;
using AbstractFactory.Models;

namespace AbstractFactory.AbstractFactories
{
    public class NintendoDSAbstractFactory : IItemFactory
    {
        public Bloque CrearBloque()
        {
            return new NintendoDSBloque();
        }

        public Moneda CrearMoneda()
        {
            return new NintendoDSMoneda();
        }
    }
}
