
namespace PROYECTOQAG5
{
    partial class PVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.Label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProductoDescripcion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.txtProductoCodigo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_registrar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 892);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 78);
            this.panel1.TabIndex = 1;
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Btn_registrar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_registrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_registrar.Location = new System.Drawing.Point(1207, 10);
            this.Btn_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(149, 57);
            this.Btn_registrar.TabIndex = 27;
            this.Btn_registrar.Text = "Aceptar y Registrar";
            this.Btn_registrar.UseVisualStyleBackColor = false;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1042, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 57);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.GroupBox5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 892);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.txtCambio);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Controls.Add(this.txtMontoPago);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.lblIGV);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1372, 759);
            this.panel3.TabIndex = 49;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(189, 392);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(19, 20);
            this.lblSubTotal.TabIndex = 62;
            this.lblSubTotal.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(58, 392);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 20);
            this.label23.TabIndex = 61;
            this.label23.Text = "Sub Total : S/.";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(949, 432);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(114, 22);
            this.txtCambio.TabIndex = 60;
            this.txtCambio.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(855, 432);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 20);
            this.label27.TabIndex = 58;
            this.label27.Text = "Cambio:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(659, 419);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 33);
            this.btnCalcular.TabIndex = 59;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(543, 430);
            this.txtMontoPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(86, 22);
            this.txtMontoPago.TabIndex = 57;
            this.txtMontoPago.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(385, 432);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 20);
            this.label26.TabIndex = 56;
            this.label26.Text = "Monto Pago:";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(362, 393);
            this.lblIGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(19, 20);
            this.lblIGV.TabIndex = 54;
            this.lblIGV.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(522, 392);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 20);
            this.lblTotal.TabIndex = 55;
            this.lblTotal.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(428, 392);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(86, 20);
            this.label25.TabIndex = 52;
            this.label25.Text = "Total : S/.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(259, 393);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 20);
            this.label24.TabIndex = 53;
            this.label24.Text = "IGV : S/.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.Cantidad_item,
            this.Precio_item,
            this.ImporteTotal});
            this.dataGridView1.Location = new System.Drawing.Point(29, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1327, 313);
            this.dataGridView1.TabIndex = 51;
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Cantidad_item
            // 
            this.Cantidad_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad_item.HeaderText = "Cantidad";
            this.Cantidad_item.MinimumWidth = 6;
            this.Cantidad_item.Name = "Cantidad_item";
            // 
            // Precio_item
            // 
            this.Precio_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio_item.HeaderText = "Precio";
            this.Precio_item.MinimumWidth = 6;
            this.Precio_item.Name = "Precio_item";
            // 
            // ImporteTotal
            // 
            this.ImporteTotal.HeaderText = "Importe Total";
            this.ImporteTotal.Name = "ImporteTotal";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.btnAgregarProducto);
            this.GroupBox5.Controls.Add(this.txtCantidad);
            this.GroupBox5.Controls.Add(this.Label12);
            this.GroupBox5.Controls.Add(this.label13);
            this.GroupBox5.Controls.Add(this.label14);
            this.GroupBox5.Controls.Add(this.txtPrecioUnidad);
            this.GroupBox5.Controls.Add(this.txtStock);
            this.GroupBox5.Controls.Add(this.btnBuscarProducto);
            this.GroupBox5.Controls.Add(this.label17);
            this.GroupBox5.Controls.Add(this.label15);
            this.GroupBox5.Controls.Add(this.txtProductoDescripcion);
            this.GroupBox5.Controls.Add(this.label16);
            this.GroupBox5.Controls.Add(this.txtProductoNombre);
            this.GroupBox5.Controls.Add(this.txtProductoCodigo);
            this.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox5.Location = new System.Drawing.Point(0, 0);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox5.Size = new System.Drawing.Size(1372, 133);
            this.GroupBox5.TabIndex = 48;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Producto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(791, 78);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(209, 28);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(662, 82);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(107, 22);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(658, 62);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(65, 16);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(512, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Precio Unidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(383, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Stock:";
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(516, 82);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.ReadOnly = true;
            this.txtPrecioUnidad.Size = new System.Drawing.Size(131, 22);
            this.txtPrecioUnidad.TabIndex = 18;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(387, 82);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(119, 22);
            this.txtStock.TabIndex = 16;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(930, 27);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 28);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(720, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Descripción";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(512, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nombre";
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Location = new System.Drawing.Point(724, 30);
            this.txtProductoDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.ReadOnly = true;
            this.txtProductoDescripcion.Size = new System.Drawing.Size(199, 22);
            this.txtProductoDescripcion.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(383, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Codigo";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(516, 30);
            this.txtProductoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.ReadOnly = true;
            this.txtProductoNombre.Size = new System.Drawing.Size(199, 22);
            this.txtProductoNombre.TabIndex = 15;
            // 
            // txtProductoCodigo
            // 
            this.txtProductoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductoCodigo.Location = new System.Drawing.Point(387, 30);
            this.txtProductoCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductoCodigo.Name = "txtProductoCodigo";
            this.txtProductoCodigo.Size = new System.Drawing.Size(119, 22);
            this.txtProductoCodigo.TabIndex = 14;
            // 
            // PVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1372, 970);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PVentas";
            this.Text = "PVentas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button btnAgregarProducto;
        internal System.Windows.Forms.NumericUpDown txtCantidad;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtPrecioUnidad;
        internal System.Windows.Forms.TextBox txtStock;
        internal System.Windows.Forms.Button btnBuscarProducto;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtProductoDescripcion;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtProductoNombre;
        internal System.Windows.Forms.TextBox txtProductoCodigo;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTotal;
    }
}