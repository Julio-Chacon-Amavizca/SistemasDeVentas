
namespace PROYECTOQAG5
{
    partial class PInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxbusquedas = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.Btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiardatos = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDescargar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxbusquedas
            // 
            this.cbxbusquedas.BackColor = System.Drawing.Color.White;
            this.cbxbusquedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbusquedas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxbusquedas.FormattingEnabled = true;
            this.cbxbusquedas.Location = new System.Drawing.Point(475, 148);
            this.cbxbusquedas.Name = "cbxbusquedas";
            this.cbxbusquedas.Size = new System.Drawing.Size(218, 29);
            this.cbxbusquedas.TabIndex = 62;
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
            this.Btnlimpiar.Location = new System.Drawing.Point(1112, 143);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(81, 42);
            this.Btnlimpiar.TabIndex = 65;
            this.Btnlimpiar.UseVisualStyleBackColor = false;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
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
            this.Btnbuscar.Location = new System.Drawing.Point(1001, 143);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(81, 42);
            this.Btnbuscar.TabIndex = 64;
            this.Btnbuscar.UseVisualStyleBackColor = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(239, 56);
            this.txtindice.Name = "txtindice";
            this.txtindice.ReadOnly = true;
            this.txtindice.Size = new System.Drawing.Size(47, 22);
            this.txtindice.TabIndex = 101;
            this.txtindice.TabStop = false;
            this.txtindice.Text = "-1";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(292, 56);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(47, 22);
            this.txtid.TabIndex = 100;
            this.txtid.TabStop = false;
            this.txtid.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 114;
            this.label7.Text = "PRODUCTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtprecioventa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtstock);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtindice);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnlimpiardatos);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbxestado);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbxcategoria);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 970);
            this.panel1.TabIndex = 69;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioventa.Location = new System.Drawing.Point(26, 297);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(296, 27);
            this.txtprecioventa.TabIndex = 115;
            this.txtprecioventa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 118;
            this.label1.Text = "Precio:";
            this.label1.Visible = false;
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(26, 368);
            this.txtstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(296, 27);
            this.txtstock.TabIndex = 116;
            this.txtstock.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 117;
            this.label3.Text = "Stock";
            this.label3.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 35;
            this.btneliminar.Location = new System.Drawing.Point(30, 903);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(296, 46);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiardatos
            // 
            this.btnlimpiardatos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlimpiardatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiardatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiardatos.ForeColor = System.Drawing.Color.White;
            this.btnlimpiardatos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiardatos.IconColor = System.Drawing.Color.White;
            this.btnlimpiardatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiardatos.IconSize = 35;
            this.btnlimpiardatos.Location = new System.Drawing.Point(30, 851);
            this.btnlimpiardatos.Name = "btnlimpiardatos";
            this.btnlimpiardatos.Size = new System.Drawing.Size(296, 46);
            this.btnlimpiardatos.TabIndex = 8;
            this.btnlimpiardatos.Text = "Limpiar";
            this.btnlimpiardatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiardatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiardatos.UseVisualStyleBackColor = false;
            this.btnlimpiardatos.Click += new System.EventHandler(this.btnlimpiardatos_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 35;
            this.btnguardar.Location = new System.Drawing.Point(30, 799);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(296, 46);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 110;
            this.label11.Text = "Estado:";
            // 
            // cbxestado
            // 
            this.cbxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxestado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(30, 507);
            this.cbxestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(296, 27);
            this.cbxestado.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(30, 150);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(296, 27);
            this.txtnombre.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 108;
            this.label10.Text = "Nombre:";
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(30, 436);
            this.cbxcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(296, 27);
            this.cbxcategoria.TabIndex = 5;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(30, 221);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(296, 27);
            this.txtdescripcion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Categoria:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(30, 86);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(296, 27);
            this.txtcodigo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 102;
            this.label8.Text = "Codigo:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(753, 150);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(218, 27);
            this.txtbusqueda.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "BUSCAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "ORDENAR POR";
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.PrecioVenta,
            this.EstadoValor,
            this.Estado});
            this.Dgv_usuarios.Location = new System.Drawing.Point(389, 239);
            this.Dgv_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_usuarios.MultiSelect = false;
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_usuarios.RowHeadersWidth = 16;
            this.Dgv_usuarios.RowTemplate.Height = 28;
            this.Dgv_usuarios.Size = new System.Drawing.Size(959, 514);
            this.Dgv_usuarios.TabIndex = 66;
            this.Dgv_usuarios.TabStop = false;
            this.Dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellContentClick);
            this.Dgv_usuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_usuarios_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnseleccionar.FillWeight = 120F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // BtnDescargar
            // 
            this.BtnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.BtnDescargar.IconColor = System.Drawing.Color.Green;
            this.BtnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDescargar.IconSize = 30;
            this.BtnDescargar.Location = new System.Drawing.Point(1052, 901);
            this.BtnDescargar.Name = "BtnDescargar";
            this.BtnDescargar.Size = new System.Drawing.Size(296, 46);
            this.BtnDescargar.TabIndex = 70;
            this.BtnDescargar.Text = "Descargar Excel";
            this.BtnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDescargar.UseVisualStyleBackColor = true;
            this.BtnDescargar.Click += new System.EventHandler(this.BtnDescargar_Click);
            // 
            // PInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1372, 970);
            this.Controls.Add(this.BtnDescargar);
            this.Controls.Add(this.cbxbusquedas);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgv_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PInventario";
            this.Text = "PInventario";
            this.Load += new System.EventHandler(this.PInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxbusquedas;
        private FontAwesome.Sharp.IconButton Btnlimpiar;
        private FontAwesome.Sharp.IconButton Btnbuscar;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiardatos;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cbxestado;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbxcategoria;
        public System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton BtnDescargar;
        public System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label3;
    }
}