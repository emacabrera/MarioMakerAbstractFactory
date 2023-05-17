namespace AbstractFactory.Abstractions
{
    internal interface IItem
    {
        string Dimension { get; }
        string Plataforma { get; }
        void Render();
    }
}
