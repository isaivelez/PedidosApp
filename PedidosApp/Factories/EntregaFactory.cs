using PedidosApp.Clases;
using PedidosApp.Interfaces;

namespace PedidosApp.Factories
{
    internal class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "tecnología" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio")
                return new EntregaMoto();
            else if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else
                return new EntregaMoto();
        }
    }
}
