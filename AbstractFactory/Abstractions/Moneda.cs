using System;

namespace AbstractFactory.Abstractions
{
    public abstract class Moneda : IItem
    {
        protected string _dimension;
        protected string _plataforma;

        public string Dimension
        {
            get { return _dimension; }
        }

        public string Plataforma
        {
            get { return _plataforma; }
        }


        public void Render()
        {
            Console.WriteLine($"Soy una moneda de dimension {_dimension} hecha para {_plataforma}");
        }
    }
}
