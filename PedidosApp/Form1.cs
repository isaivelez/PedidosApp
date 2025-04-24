using PedidosApp.Clases;
using PedidosApp.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso;
                int distancia;
                if (string.IsNullOrEmpty(TxtCliente.Text) || string.IsNullOrEmpty(TxtCliente.Text))
                {
                    MessageBox.Show("El cliente es obligatorio");
                    return;
                }
                if (CmbProducto.SelectedItem == null)
                {
                    MessageBox.Show("El Producto es obligatorio");
                    return;
                }
                if (!double.TryParse(NudPeso.Value.ToString(), out peso) || peso < 1 ||
                    !int.TryParse(NudDistancia.Value.ToString(), out distancia) || distancia < 1)
                {
                    MessageBox.Show("Por favor recuerde que el peso y el recorrido debe ser mayor a 0");
                    return;
                }

                string cliente = TxtCliente.Text;
                string producto = CmbProducto.SelectedItem.ToString();
                peso = Convert.ToDouble(NudPeso.Value);
                distancia = Convert.ToInt32(NudDistancia.Value);
                bool urgente = ChkUrgente.Checked;

                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);

                LblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} " +
                                    $"Costo: ${pedido.ObtenerCosto():0.00}";

                ActualizarDataGridPedidos(RegistroPedidos.Instancia.Pedidos);
                //LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListarOpcionesCmbProducto();
            InicializarDataGrid();
        }

        #region[Form]
        private void LimpiarFormulario()
        {
            TxtCliente.Text = "";
            CmbProducto.SelectedIndex = -1;
            ChkUrgente.Checked = false;
            NudPeso.Value = NudPeso.Minimum;
            NudDistancia.Value = NudDistancia.Minimum;
            LblResultado.Text = "";
        }

        private void ListarOpcionesCmbProducto()
        {
            CmbProducto.Items.Add("tecnologia");
            CmbProducto.Items.Add("accesorio");
            CmbProducto.Items.Add("componente");
        }
        #endregion

        #region[Datagrig functions]
        private void ActualizarDataGridPedidos(List<Pedido> pedidos)
        {
            DtgPedidos.Rows.Clear();

            foreach (var pedido in pedidos)
            {
                DtgPedidos.Rows.Add(
                    pedido.Cliente,
                    pedido.Producto,
                    pedido.Urgente,
                    pedido.Peso,
                    pedido.Distancia,
                    pedido.ObtenerCosto(),
                    pedido.MetodoEntrega.TipoEntrega()
                );
            }
        }

        private void InicializarDataGrid()
        {
            DtgPedidos.Rows.Clear();

            DtgPedidos.Columns.Clear();
            DtgPedidos.Columns.Add("Cliente", "Cliente");
            DtgPedidos.Columns.Add("Producto", "Producto");
            DtgPedidos.Columns.Add("Es urgente", "Es urgente");
            DtgPedidos.Columns.Add("Peso", "Peso");
            DtgPedidos.Columns.Add("Distancia", "Distancia");
            DtgPedidos.Columns.Add("Costo", "Costo");
            DtgPedidos.Columns.Add("Tipo de entrega", "Tipo de entrega");
            DtgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgPedidos.MultiSelect = false;
            DtgPedidos.ReadOnly = true;
        }
        #endregion
    }
}
