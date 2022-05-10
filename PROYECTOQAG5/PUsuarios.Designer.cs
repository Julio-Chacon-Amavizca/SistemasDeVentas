
namespace PROYECTOQAG5
{
    partial class PUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxestadousuario = new System.Windows.Forms.ComboBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtconfirmarcontraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxrolusuario = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrecompleto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxbusquedas = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.Btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiardatos = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(786, 86);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(218, 27);
            this.txtbusqueda.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "BUSCAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "ORDENAR POR";
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Usuario,
            this.NombreCompleto,
            this.Correo,
            this.Contraseña,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.Dgv_usuarios.Location = new System.Drawing.Point(401, 198);
            this.Dgv_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_usuarios.MultiSelect = false;
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_usuarios.RowHeadersWidth = 16;
            this.Dgv_usuarios.RowTemplate.Height = 28;
            this.Dgv_usuarios.Size = new System.Drawing.Size(959, 514);
            this.Dgv_usuarios.TabIndex = 52;
            this.Dgv_usuarios.TabStop = false;
            this.Dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellContentClick);
            this.Dgv_usuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_usuarios_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FillWeight = 120F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 40;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "IdUsuario";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtindice);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnlimpiardatos);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbxestadousuario);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtconfirmarcontraseña);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxrolusuario);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombrecompleto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 970);
            this.panel1.TabIndex = 61;
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
            this.txtindice.Visible = false;
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
            this.txtid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 114;
            this.label7.Text = "USUARIOS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 110;
            this.label11.Text = "Estado:";
            // 
            // cbxestadousuario
            // 
            this.cbxestadousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxestadousuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestadousuario.FormattingEnabled = true;
            this.cbxestadousuario.Location = new System.Drawing.Point(29, 578);
            this.cbxestadousuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxestadousuario.Name = "cbxestadousuario";
            this.cbxestadousuario.Size = new System.Drawing.Size(296, 27);
            this.cbxestadousuario.TabIndex = 6;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(30, 150);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(296, 27);
            this.txtcorreo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 108;
            this.label10.Text = "Correo:";
            // 
            // txtconfirmarcontraseña
            // 
            this.txtconfirmarcontraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmarcontraseña.Location = new System.Drawing.Point(30, 363);
            this.txtconfirmarcontraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfirmarcontraseña.Name = "txtconfirmarcontraseña";
            this.txtconfirmarcontraseña.PasswordChar = '*';
            this.txtconfirmarcontraseña.Size = new System.Drawing.Size(296, 27);
            this.txtconfirmarcontraseña.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 19);
            this.label9.TabIndex = 106;
            this.label9.Text = "Confirmar Contraseña:";
            // 
            // cbxrolusuario
            // 
            this.cbxrolusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxrolusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxrolusuario.FormattingEnabled = true;
            this.cbxrolusuario.Location = new System.Drawing.Point(29, 507);
            this.cbxrolusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxrolusuario.Name = "cbxrolusuario";
            this.cbxrolusuario.Size = new System.Drawing.Size(296, 27);
            this.cbxrolusuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(30, 290);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(296, 27);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(30, 221);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(296, 27);
            this.txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 98;
            this.label3.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Rol:";
            // 
            // txtNombrecompleto
            // 
            this.txtNombrecompleto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrecompleto.Location = new System.Drawing.Point(30, 86);
            this.txtNombrecompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrecompleto.Name = "txtNombrecompleto";
            this.txtNombrecompleto.Size = new System.Drawing.Size(296, 27);
            this.txtNombrecompleto.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 19);
            this.label8.TabIndex = 102;
            this.label8.Text = "Nombre Completo:";
            // 
            // cbxbusquedas
            // 
            this.cbxbusquedas.BackColor = System.Drawing.Color.White;
            this.cbxbusquedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbusquedas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxbusquedas.FormattingEnabled = true;
            this.cbxbusquedas.Location = new System.Drawing.Point(508, 84);
            this.cbxbusquedas.Name = "cbxbusquedas";
            this.cbxbusquedas.Size = new System.Drawing.Size(218, 29);
            this.cbxbusquedas.TabIndex = 10;
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
            this.Btnlimpiar.Location = new System.Drawing.Point(1145, 79);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(81, 42);
            this.Btnlimpiar.TabIndex = 13;
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
            this.Btnbuscar.Location = new System.Drawing.Point(1034, 79);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(81, 42);
            this.Btnbuscar.TabIndex = 12;
            this.Btnbuscar.UseVisualStyleBackColor = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
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
            // PUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1372, 970);
            this.Controls.Add(this.cbxbusquedas);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgv_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PUsuarios";
            this.Text = "PUsuarios";
            this.Load += new System.EventHandler(this.PUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtconfirmarcontraseña;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbxrolusuario;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombrecompleto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cbxestadousuario;
        public System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiardatos;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton Btnbuscar;
        private FontAwesome.Sharp.IconButton Btnlimpiar;
        private System.Windows.Forms.ComboBox cbxbusquedas;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtindice;
    }
}