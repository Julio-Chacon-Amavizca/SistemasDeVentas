namespace PROYECTOQAG5
{
    partial class PGanado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.Btn_DetalleBovino = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxbusquedas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.Dgv_Ganado = new System.Windows.Forms.DataGridView();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdGanado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAretado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ganado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnagregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarproducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnagregarproducto.IconColor = System.Drawing.Color.White;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 35;
            this.btnagregarproducto.Location = new System.Drawing.Point(15, 14);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(236, 43);
            this.btnagregarproducto.TabIndex = 104;
            this.btnagregarproducto.Text = "Agregar Bovino";
            this.btnagregarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // Btn_DetalleBovino
            // 
            this.Btn_DetalleBovino.BackColor = System.Drawing.Color.ForestGreen;
            this.Btn_DetalleBovino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DetalleBovino.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_DetalleBovino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DetalleBovino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DetalleBovino.ForeColor = System.Drawing.Color.White;
            this.Btn_DetalleBovino.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Btn_DetalleBovino.IconColor = System.Drawing.Color.White;
            this.Btn_DetalleBovino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_DetalleBovino.IconSize = 35;
            this.Btn_DetalleBovino.Location = new System.Drawing.Point(257, 14);
            this.Btn_DetalleBovino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_DetalleBovino.Name = "Btn_DetalleBovino";
            this.Btn_DetalleBovino.Size = new System.Drawing.Size(236, 43);
            this.Btn_DetalleBovino.TabIndex = 106;
            this.Btn_DetalleBovino.Text = "Detalle Bovino";
            this.Btn_DetalleBovino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_DetalleBovino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_DetalleBovino.UseVisualStyleBackColor = false;
            this.Btn_DetalleBovino.Visible = false;
            this.Btn_DetalleBovino.Click += new System.EventHandler(this.Btn_DetalleBovino_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(966, 50);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(217, 26);
            this.txtbusqueda.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(962, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "BUSCAR";
            // 
            // cbxbusquedas
            // 
            this.cbxbusquedas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxbusquedas.BackColor = System.Drawing.Color.White;
            this.cbxbusquedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbusquedas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxbusquedas.FormattingEnabled = true;
            this.cbxbusquedas.Location = new System.Drawing.Point(734, 45);
            this.cbxbusquedas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxbusquedas.Name = "cbxbusquedas";
            this.cbxbusquedas.Size = new System.Drawing.Size(217, 29);
            this.cbxbusquedas.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(730, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 115;
            this.label6.Text = "ORDENAR POR";
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscarproducto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproducto.ForeColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 30;
            this.btnbuscarproducto.Location = new System.Drawing.Point(1227, 41);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(84, 38);
            this.btnbuscarproducto.TabIndex = 113;
            this.btnbuscarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // Dgv_Ganado
            // 
            this.Dgv_Ganado.AllowUserToAddRows = false;
            this.Dgv_Ganado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Ganado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Ganado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Ganado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ganado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.IdGanado,
            this.Apodo,
            this.Proposito,
            this.FechaAretado});
            this.Dgv_Ganado.Location = new System.Drawing.Point(12, 202);
            this.Dgv_Ganado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Ganado.MultiSelect = false;
            this.Dgv_Ganado.Name = "Dgv_Ganado";
            this.Dgv_Ganado.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Ganado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Ganado.RowHeadersWidth = 16;
            this.Dgv_Ganado.RowTemplate.Height = 28;
            this.Dgv_Ganado.Size = new System.Drawing.Size(1327, 709);
            this.Dgv_Ganado.TabIndex = 118;
            this.Dgv_Ganado.TabStop = false;
            this.Dgv_Ganado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_Ganado_CellPainting);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(518, 13);
            this.txtindice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtindice.Name = "txtindice";
            this.txtindice.ReadOnly = true;
            this.txtindice.Size = new System.Drawing.Size(47, 22);
            this.txtindice.TabIndex = 120;
            this.txtindice.TabStop = false;
            this.txtindice.Text = "-1";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(571, 13);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(47, 22);
            this.txtid.TabIndex = 119;
            this.txtid.TabStop = false;
            this.txtid.Text = "0";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FillWeight = 120F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 40;
            // 
            // IdGanado
            // 
            this.IdGanado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdGanado.HeaderText = "Arete";
            this.IdGanado.Name = "IdGanado";
            this.IdGanado.ReadOnly = true;
            // 
            // Apodo
            // 
            this.Apodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apodo.HeaderText = "Apodo";
            this.Apodo.Name = "Apodo";
            this.Apodo.ReadOnly = true;
            // 
            // Proposito
            // 
            this.Proposito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proposito.HeaderText = "Proposito";
            this.Proposito.Name = "Proposito";
            this.Proposito.ReadOnly = true;
            // 
            // FechaAretado
            // 
            this.FechaAretado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaAretado.HeaderText = "Fecha Aretado";
            this.FechaAretado.Name = "FechaAretado";
            this.FechaAretado.ReadOnly = true;
            // 
            // PGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 922);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Dgv_Ganado);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxbusquedas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.Btn_DetalleBovino);
            this.Controls.Add(this.btnagregarproducto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PGanado";
            this.Text = "PGanado";
            this.Load += new System.EventHandler(this.PGanado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ganado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private FontAwesome.Sharp.IconButton Btn_DetalleBovino;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxbusquedas;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        public System.Windows.Forms.DataGridView Dgv_Ganado;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGanado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAretado;
    }
}