using AbstractFactory.AbstractFactories;
using AbstractFactory.Abstractions;
using System;

namespace MarioMakerAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IItemFactory abstractFactory = new NintendoDSAbstractFactory();
            abstractFactory.CrearMoneda().Render();
            abstractFactory.CrearBloque().Render();

            Console.WriteLine();

            abstractFactory = new GameboyAbstractFactory();
            abstractFactory.CrearMoneda().Render();
            abstractFactory.CrearBloque().Render();

            Console.ReadLine();
        }
    }
}
