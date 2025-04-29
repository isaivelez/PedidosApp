using PedidosApp.Clases;
using PedidosApp.Interfaces;

namespace PedidosApp.Factories
{
    public class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {

            if (tipoProducto == "tecnologia" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio")
            {
                if (peso < 2 && !urgente) return new EntregaBicicleta();
                return new EntregaMoto();
            }
            else if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else
                return new EntregaMoto();
        }
    }
}
