using PedidosApp.Interfaces;

namespace PedidosApp.Clases
{
    public class EntregaDron: IMetodoEntrega
    {
        public double CalcularCosto(int km) => 20 * km;
        public string TipoEntrega() => "Dron";
    }
}
