using PedidosApp.Clases;
using System.Collections.Generic;

namespace PedidosApp.Singleton
{
    public sealed class RegistroPedidos
    {
        private static RegistroPedidos _instancia;
        private static readonly object _lock = new object();
        public List<Pedido> Pedidos { get; private set; }
        private RegistroPedidos() => Pedidos = new List<Pedido>();
        public static RegistroPedidos Instancia
        {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new RegistroPedidos();
                    }
                    return _instancia;
                }
            }
        }
        public void AgregarPedido(Pedido pedido) => Pedidos.Add(pedido);
    }
}
