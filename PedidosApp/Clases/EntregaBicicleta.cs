using PedidosApp.Interfaces;

namespace PedidosApp.Clases
{
    public class EntregaBicicleta : IMetodoEntrega
    {
        public double CalcularCosto(int km) => 3 * km;
        public string TipoEntrega() => "Bicicleta";
    }
}
