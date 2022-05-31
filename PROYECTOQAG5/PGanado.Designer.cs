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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.Btn_DetalleBovino = new FontAwesome.Sharp.IconButton();
            this.Dgv_ganado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ganado)).BeginInit();
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
            this.Btn_DetalleBovino.Location = new System.Drawing.Point(1100, 14);
            this.Btn_DetalleBovino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_DetalleBovino.Name = "Btn_DetalleBovino";
            this.Btn_DetalleBovino.Size = new System.Drawing.Size(236, 43);
            this.Btn_DetalleBovino.TabIndex = 106;
            this.Btn_DetalleBovino.Text = "Detalle Bovino";
            this.Btn_DetalleBovino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_DetalleBovino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_DetalleBovino.UseVisualStyleBackColor = false;
            this.Btn_DetalleBovino.Click += new System.EventHandler(this.Btn_DetalleBovino_Click);
            // 
            // Dgv_ganado
            // 
            this.Dgv_ganado.AllowUserToAddRows = false;
            this.Dgv_ganado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ganado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_ganado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ganado.Location = new System.Drawing.Point(15, 97);
            this.Dgv_ganado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_ganado.MultiSelect = false;
            this.Dgv_ganado.Name = "Dgv_ganado";
            this.Dgv_ganado.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ganado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_ganado.RowHeadersWidth = 16;
            this.Dgv_ganado.RowTemplate.Height = 28;
            this.Dgv_ganado.Size = new System.Drawing.Size(1321, 802);
            this.Dgv_ganado.TabIndex = 107;
            this.Dgv_ganado.TabStop = false;
            // 
            // PGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 922);
            this.Controls.Add(this.Dgv_ganado);
            this.Controls.Add(this.Btn_DetalleBovino);
            this.Controls.Add(this.btnagregarproducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PGanado";
            this.Text = "PGanado";
            this.Load += new System.EventHandler(this.PGanado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ganado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private FontAwesome.Sharp.IconButton Btn_DetalleBovino;
        public System.Windows.Forms.DataGridView Dgv_ganado;
    }
}