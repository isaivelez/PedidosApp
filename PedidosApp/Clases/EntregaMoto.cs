using PedidosApp.Interfaces;

namespace PedidosApp.Clases
{
    internal class EntregaMoto: IMetodoEntrega
    {
        public double CalcularCosto(int km) => 10 * km;
        public string TipoEntrega() => "Motocicleta";
    }
}
