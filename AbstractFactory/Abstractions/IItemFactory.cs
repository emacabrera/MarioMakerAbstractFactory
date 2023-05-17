namespace AbstractFactory.Abstractions
{
    public interface IItemFactory
    {
        Moneda CrearMoneda();
        Bloque CrearBloque();
    }
}
