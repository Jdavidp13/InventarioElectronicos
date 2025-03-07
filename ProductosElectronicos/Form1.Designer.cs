namespace ProductosElectronicos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.ListBox listBoxInventario;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Button btnVenderProducto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.listBoxInventario = new System.Windows.Forms.ListBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(159, 109);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(136, 22);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(159, 67);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(136, 22);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(159, 28);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(136, 22);
            this.txtCantidadStock.TabIndex = 2;
            // 
            // listBoxInventario
            // 
            this.listBoxInventario.ItemHeight = 16;
            this.listBoxInventario.Location = new System.Drawing.Point(520, 28);
            this.listBoxInventario.Name = "listBoxInventario";
            this.listBoxInventario.Size = new System.Drawing.Size(236, 180);
            this.listBoxInventario.TabIndex = 4;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(179, 325);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(200, 22);
            this.txtBuscarProducto.TabIndex = 5;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(179, 272);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(200, 22);
            this.txtCantidadVenta.TabIndex = 6;
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Location = new System.Drawing.Point(572, 317);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(200, 30);
            this.btnVenderProducto.TabIndex = 7;
            this.btnVenderProducto.Text = "Vender Producto";
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad Venta";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(179, 149);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(130, 23);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(861, 425);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.listBoxInventario);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtCantidadVenta);
            this.Controls.Add(this.btnVenderProducto);
            this.Name = "Form1";
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}

