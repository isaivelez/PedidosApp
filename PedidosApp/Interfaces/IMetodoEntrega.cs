namespace PedidosApp.Interfaces
{
    public interface IMetodoEntrega
    {
        double CalcularCosto(int km);
        string TipoEntrega();
    }
}
