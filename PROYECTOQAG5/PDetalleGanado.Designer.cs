namespace PROYECTOQAG5
{
    partial class PDetalleGanado
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_General = new FontAwesome.Sharp.IconButton();
            this.Btn_progenie = new FontAwesome.Sharp.IconButton();
            this.Btn_vacunacion = new FontAwesome.Sharp.IconButton();
            this.Btn_desparacitacion = new FontAwesome.Sharp.IconButton();
            this.Btn_Pesaje = new FontAwesome.Sharp.IconButton();
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
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_usuarios);
            this.panel1.Controls.Add(this.Btn_Pesaje);
            this.panel1.Controls.Add(this.Btn_desparacitacion);
            this.panel1.Controls.Add(this.Btn_vacunacion);
            this.panel1.Controls.Add(this.Btn_progenie);
            this.panel1.Controls.Add(this.Btn_General);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 739);
            this.panel1.TabIndex = 0;
            // 
            // Btn_General
            // 
            this.Btn_General.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_General.IconColor = System.Drawing.Color.Black;
            this.Btn_General.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_General.Location = new System.Drawing.Point(0, 0);
            this.Btn_General.Name = "Btn_General";
            this.Btn_General.Size = new System.Drawing.Size(111, 54);
            this.Btn_General.TabIndex = 0;
            this.Btn_General.Text = "General";
            this.Btn_General.UseVisualStyleBackColor = true;
            // 
            // Btn_progenie
            // 
            this.Btn_progenie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_progenie.IconColor = System.Drawing.Color.Black;
            this.Btn_progenie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_progenie.Location = new System.Drawing.Point(108, 0);
            this.Btn_progenie.Name = "Btn_progenie";
            this.Btn_progenie.Size = new System.Drawing.Size(111, 54);
            this.Btn_progenie.TabIndex = 1;
            this.Btn_progenie.Text = "Progenie";
            this.Btn_progenie.UseVisualStyleBackColor = true;
            // 
            // Btn_vacunacion
            // 
            this.Btn_vacunacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_vacunacion.IconColor = System.Drawing.Color.Black;
            this.Btn_vacunacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_vacunacion.Location = new System.Drawing.Point(216, 0);
            this.Btn_vacunacion.Name = "Btn_vacunacion";
            this.Btn_vacunacion.Size = new System.Drawing.Size(111, 54);
            this.Btn_vacunacion.TabIndex = 2;
            this.Btn_vacunacion.Text = "Vacunacion";
            this.Btn_vacunacion.UseVisualStyleBackColor = true;
            // 
            // Btn_desparacitacion
            // 
            this.Btn_desparacitacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_desparacitacion.IconColor = System.Drawing.Color.Black;
            this.Btn_desparacitacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_desparacitacion.Location = new System.Drawing.Point(323, 0);
            this.Btn_desparacitacion.Name = "Btn_desparacitacion";
            this.Btn_desparacitacion.Size = new System.Drawing.Size(111, 54);
            this.Btn_desparacitacion.TabIndex = 3;
            this.Btn_desparacitacion.Text = "Desparacitacion";
            this.Btn_desparacitacion.UseVisualStyleBackColor = true;
            // 
            // Btn_Pesaje
            // 
            this.Btn_Pesaje.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Pesaje.IconColor = System.Drawing.Color.Black;
            this.Btn_Pesaje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Pesaje.Location = new System.Drawing.Point(431, 0);
            this.Btn_Pesaje.Name = "Btn_Pesaje";
            this.Btn_Pesaje.Size = new System.Drawing.Size(111, 54);
            this.Btn_Pesaje.TabIndex = 4;
            this.Btn_Pesaje.Text = "Pesaje";
            this.Btn_Pesaje.UseVisualStyleBackColor = true;
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
            this.Estado,
            this.Ver,
            this.Edit,
            this.Eliminar});
            this.Dgv_usuarios.Location = new System.Drawing.Point(0, 49);
            this.Dgv_usuarios.Margin = new System.Windows.Forms.Padding(2);
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
            this.Dgv_usuarios.Size = new System.Drawing.Size(1011, 688);
            this.Dgv_usuarios.TabIndex = 106;
            this.Dgv_usuarios.TabStop = false;
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
            this.Usuario.HeaderText = "Arete";
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
            this.Correo.HeaderText = "Sexo";
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
            this.Rol.HeaderText = "ejemplo1";
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
            this.Estado.HeaderText = "Ejemplo2";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // PDetalleGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 763);
            this.Controls.Add(this.panel1);
            this.Name = "PDetalleGanado";
            this.Text = "PDetalleGanado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Pesaje;
        private FontAwesome.Sharp.IconButton Btn_desparacitacion;
        private FontAwesome.Sharp.IconButton Btn_vacunacion;
        private FontAwesome.Sharp.IconButton Btn_progenie;
        private FontAwesome.Sharp.IconButton Btn_General;
        public System.Windows.Forms.DataGridView Dgv_usuarios;
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
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}