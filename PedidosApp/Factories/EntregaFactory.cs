using PedidosApp.Clases;
using PedidosApp.Interfaces;

namespace PedidosApp.Factories
{
    public class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else if (tipoProducto == "tecnologia" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio")
                return new EntregaMoto();
            else
                return new EntregaMoto(); 
        }
    }
}
