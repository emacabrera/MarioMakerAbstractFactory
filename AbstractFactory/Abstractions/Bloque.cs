using System;

namespace AbstractFactory.Abstractions
{
    public class Bloque : IItem
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
            Console.WriteLine($"Soy un bloque de dimension {_dimension} hecho para {_plataforma}");
        }
    }
}
