
namespace PROYECTOQAG5
{
    partial class PCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxbusquedas = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.Btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiardatos = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbxbusquedas.Location = new System.Drawing.Point(514, 84);
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
            this.Btnlimpiar.Location = new System.Drawing.Point(1151, 79);
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
            this.Btnbuscar.Location = new System.Drawing.Point(1040, 79);
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
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 114;
            this.label7.Text = "CATEGORIAS";
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
            this.panel1.Controls.Add(this.cbxestado);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 970);
            this.panel1.TabIndex = 69;
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
            this.label11.Location = new System.Drawing.Point(30, 128);
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
            this.cbxestado.Location = new System.Drawing.Point(34, 158);
            this.cbxestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(296, 27);
            this.cbxestado.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(30, 86);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(296, 27);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 102;
            this.label8.Text = "Descripcion";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(792, 86);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(218, 27);
            this.txtbusqueda.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(788, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "BUSCAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(510, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "ORDENAR POR";
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Descripcion,
            this.EstadoValor,
            this.Estado});
            this.Dgv_usuarios.Location = new System.Drawing.Point(407, 198);
            this.Dgv_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_usuarios.MultiSelect = false;
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            this.btnseleccionar.FillWeight = 120F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 40;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            // PCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "PCategoria";
            this.Text = "PCategoria";
            this.Load += new System.EventHandler(this.PCategoria_Load);
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
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}