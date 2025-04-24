namespace PedidosApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkUrgente = new System.Windows.Forms.CheckBox();
            this.NudPeso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudDistancia = new System.Windows.Forms.NumericUpDown();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.DtgPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(366, 24);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // CmbProducto
            // 
            this.CmbProducto.FormattingEnabled = true;
            this.CmbProducto.Location = new System.Drawing.Point(366, 61);
            this.CmbProducto.Name = "CmbProducto";
            this.CmbProducto.Size = new System.Drawing.Size(121, 21);
            this.CmbProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // ChkUrgente
            // 
            this.ChkUrgente.AutoSize = true;
            this.ChkUrgente.Location = new System.Drawing.Point(366, 98);
            this.ChkUrgente.Name = "ChkUrgente";
            this.ChkUrgente.Size = new System.Drawing.Size(79, 17);
            this.ChkUrgente.TabIndex = 4;
            this.ChkUrgente.Text = "Es Urgente";
            this.ChkUrgente.UseVisualStyleBackColor = true;
            // 
            // NudPeso
            // 
            this.NudPeso.Location = new System.Drawing.Point(366, 134);
            this.NudPeso.Name = "NudPeso";
            this.NudPeso.Size = new System.Drawing.Size(120, 20);
            this.NudPeso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distancia";
            // 
            // NudDistancia
            // 
            this.NudDistancia.Location = new System.Drawing.Point(366, 170);
            this.NudDistancia.Name = "NudDistancia";
            this.NudDistancia.Size = new System.Drawing.Size(120, 20);
            this.NudDistancia.TabIndex = 7;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(366, 208);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 9;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(237, 250);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(55, 13);
            this.LblResultado.TabIndex = 10;
            this.LblResultado.Text = "Resultado";
            // 
            // DtgPedidos
            // 
            this.DtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPedidos.Location = new System.Drawing.Point(29, 284);
            this.DtgPedidos.Name = "DtgPedidos";
            this.DtgPedidos.Size = new System.Drawing.Size(759, 234);
            this.DtgPedidos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 542);
            this.Controls.Add(this.DtgPedidos);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudDistancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudPeso);
            this.Controls.Add(this.ChkUrgente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkUrgente;
        private System.Windows.Forms.NumericUpDown NudPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudDistancia;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.DataGridView DtgPedidos;
    }
}

