
namespace PROYECTOQAG5
{
    partial class PDetalleVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmontopago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmontocambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btndescargar = new FontAwesome.Sharp.IconButton();
            this.Btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.Btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(376, 787);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 234;
            this.label6.Text = "Monto Pago:";
            // 
            // txtmontopago
            // 
            this.txtmontopago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtmontopago.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtmontopago.Location = new System.Drawing.Point(542, 784);
            this.txtmontopago.Margin = new System.Windows.Forms.Padding(4);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.ReadOnly = true;
            this.txtmontopago.Size = new System.Drawing.Size(61, 27);
            this.txtmontopago.TabIndex = 235;
            this.txtmontopago.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(112, 787);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 232;
            this.label5.Text = "Monto Total:";
            // 
            // txtmontocambio
            // 
            this.txtmontocambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtmontocambio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtmontocambio.Location = new System.Drawing.Point(809, 784);
            this.txtmontocambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtmontocambio.Name = "txtmontocambio";
            this.txtmontocambio.ReadOnly = true;
            this.txtmontocambio.Size = new System.Drawing.Size(61, 27);
            this.txtmontocambio.TabIndex = 233;
            this.txtmontocambio.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(632, 787);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 230;
            this.label1.Text = "Monto Cambio:";
            // 
            // txtmontototal
            // 
            this.txtmontototal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtmontototal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtmontototal.Location = new System.Drawing.Point(267, 784);
            this.txtmontototal.Margin = new System.Windows.Forms.Padding(4);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.ReadOnly = true;
            this.txtmontototal.Size = new System.Drawing.Size(61, 27);
            this.txtmontototal.TabIndex = 231;
            this.txtmontototal.Text = "0";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dgvdata.Location = new System.Drawing.Point(116, 407);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(1080, 341);
            this.dgvdata.TabIndex = 229;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtnumerodocumento);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 116);
            this.groupBox1.TabIndex = 227;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtusuario.Location = new System.Drawing.Point(583, 65);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(251, 27);
            this.txtusuario.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(579, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 92;
            this.label2.Text = "Usuario:";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txttipodocumento.Location = new System.Drawing.Point(254, 65);
            this.txttipodocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.ReadOnly = true;
            this.txttipodocumento.Size = new System.Drawing.Size(267, 27);
            this.txttipodocumento.TabIndex = 87;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtfecha.Location = new System.Drawing.Point(12, 65);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(177, 27);
            this.txtfecha.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(250, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Documento:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label26.Location = new System.Drawing.Point(429, 198);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(174, 21);
            this.label26.TabIndex = 225;
            this.label26.Text = "Numero Documento:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(666, 198);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(171, 27);
            this.txtbusqueda.TabIndex = 223;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 222;
            this.label9.Text = "Detalle Venta";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(1205, 676);
            this.label10.TabIndex = 221;
            // 
            // btndescargar
            // 
            this.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btndescargar.IconColor = System.Drawing.Color.Black;
            this.btndescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndescargar.IconSize = 17;
            this.btndescargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndescargar.Location = new System.Drawing.Point(1017, 787);
            this.btndescargar.Margin = new System.Windows.Forms.Padding(4);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(179, 26);
            this.btndescargar.TabIndex = 236;
            this.btndescargar.Text = "Descargar en PDF";
            this.btndescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = true;
            this.btndescargar.Visible = false;
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.Btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.Btnlimpiar.IconColor = System.Drawing.Color.White;
            this.Btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btnlimpiar.IconSize = 30;
            this.Btnlimpiar.Location = new System.Drawing.Point(1034, 192);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(81, 42);
            this.Btnlimpiar.TabIndex = 238;
            this.Btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscar.ForeColor = System.Drawing.Color.White;
            this.Btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Btnbuscar.IconColor = System.Drawing.Color.White;
            this.Btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btnbuscar.IconSize = 30;
            this.Btnbuscar.Location = new System.Drawing.Point(923, 192);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(81, 42);
            this.Btnbuscar.TabIndex = 237;
            this.Btnbuscar.UseVisualStyleBackColor = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(959, 55);
            this.txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(71, 21);
            this.txtnumerodocumento.TabIndex = 195;
            this.txtnumerodocumento.Visible = false;
            // 
            // PDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 970);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmontopago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmontocambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PDetalleVentas";
            this.Text = "PDetalleVentas";
            this.Load += new System.EventHandler(this.PDetalleVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btndescargar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmontopago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmontocambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton Btnlimpiar;
        private FontAwesome.Sharp.IconButton Btnbuscar;
        private System.Windows.Forms.TextBox txtnumerodocumento;
    }
}