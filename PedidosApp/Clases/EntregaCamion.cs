using PedidosApp.Interfaces;

namespace PedidosApp.Clases
{
    public class EntregaCamion : IMetodoEntrega
    {
        public double CalcularCosto(int km) => 5 * km;
        public string TipoEntrega() => "Camión";
    }
}
