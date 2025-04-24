namespace PedidosApp.Interfaces
{
    internal interface IMetodoEntrega
    {
        double CalcularCosto(int km);
        string TipoEntrega();
    }
}
