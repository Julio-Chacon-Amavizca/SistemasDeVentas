﻿
namespace PROYECTOQAG5
{
    partial class PPrincipal
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
            this.btn_minimizar = new FontAwesome.Sharp.IconButton();
            this.Btn_close = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_negocio = new FontAwesome.Sharp.IconButton();
            this.Btn_categorias = new FontAwesome.Sharp.IconButton();
            this.Btn_producto = new FontAwesome.Sharp.IconButton();
            this.Btn_usuarios = new FontAwesome.Sharp.IconButton();
            this.Btn_contabilidad = new FontAwesome.Sharp.IconButton();
            this.Btn_ganaderia = new FontAwesome.Sharp.IconButton();
            this.Btn_Ventas = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MenuAcercade = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 33);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimizar.IconColor = System.Drawing.Color.White;
            this.btn_minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimizar.IconSize = 20;
            this.btn_minimizar.Location = new System.Drawing.Point(1182, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 33);
            this.btn_minimizar.TabIndex = 101;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.BackColor = System.Drawing.Color.Red;
            this.Btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Btn_close.IconColor = System.Drawing.Color.White;
            this.Btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_close.IconSize = 20;
            this.Btn_close.Location = new System.Drawing.Point(1215, 0);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(33, 33);
            this.Btn_close.TabIndex = 100;
            this.Btn_close.TabStop = false;
            this.Btn_close.UseVisualStyleBackColor = false;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel2.Controls.Add(this.Btn_negocio);
            this.panel2.Controls.Add(this.Btn_categorias);
            this.panel2.Controls.Add(this.Btn_producto);
            this.panel2.Controls.Add(this.Btn_usuarios);
            this.panel2.Controls.Add(this.Btn_contabilidad);
            this.panel2.Controls.Add(this.Btn_ganaderia);
            this.panel2.Controls.Add(this.Btn_Ventas);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.MenuAcercade);
            this.panel2.Controls.Add(this.lbl_Usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_cerrarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 788);
            this.panel2.TabIndex = 7;
            // 
            // Btn_negocio
            // 
            this.Btn_negocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_negocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_negocio.ForeColor = System.Drawing.Color.White;
            this.Btn_negocio.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_negocio.IconColor = System.Drawing.Color.White;
            this.Btn_negocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_negocio.IconSize = 40;
            this.Btn_negocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_negocio.Location = new System.Drawing.Point(9, 479);
            this.Btn_negocio.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_negocio.Name = "Btn_negocio";
            this.Btn_negocio.Size = new System.Drawing.Size(197, 55);
            this.Btn_negocio.TabIndex = 31;
            this.Btn_negocio.Text = "NEGOCIO";
            this.Btn_negocio.UseVisualStyleBackColor = true;
            this.Btn_negocio.Click += new System.EventHandler(this.Btn_negocio_Click);
            // 
            // Btn_categorias
            // 
            this.Btn_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_categorias.ForeColor = System.Drawing.Color.White;
            this.Btn_categorias.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_categorias.IconColor = System.Drawing.Color.White;
            this.Btn_categorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_categorias.IconSize = 40;
            this.Btn_categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_categorias.Location = new System.Drawing.Point(9, 424);
            this.Btn_categorias.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_categorias.Name = "Btn_categorias";
            this.Btn_categorias.Size = new System.Drawing.Size(197, 55);
            this.Btn_categorias.TabIndex = 30;
            this.Btn_categorias.Text = "CATEGORIAS";
            this.Btn_categorias.UseVisualStyleBackColor = true;
            this.Btn_categorias.Click += new System.EventHandler(this.Btn_categorias_Click);
            // 
            // Btn_producto
            // 
            this.Btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_producto.ForeColor = System.Drawing.Color.White;
            this.Btn_producto.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_producto.IconColor = System.Drawing.Color.White;
            this.Btn_producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_producto.IconSize = 40;
            this.Btn_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_producto.Location = new System.Drawing.Point(9, 369);
            this.Btn_producto.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_producto.Name = "Btn_producto";
            this.Btn_producto.Size = new System.Drawing.Size(197, 55);
            this.Btn_producto.TabIndex = 29;
            this.Btn_producto.Text = "PRODUCTO";
            this.Btn_producto.UseVisualStyleBackColor = true;
            this.Btn_producto.Click += new System.EventHandler(this.Btn_producto_Click);
            // 
            // Btn_usuarios
            // 
            this.Btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.Btn_usuarios.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_usuarios.IconColor = System.Drawing.Color.White;
            this.Btn_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_usuarios.IconSize = 40;
            this.Btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_usuarios.Location = new System.Drawing.Point(9, 314);
            this.Btn_usuarios.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_usuarios.Name = "Btn_usuarios";
            this.Btn_usuarios.Size = new System.Drawing.Size(197, 55);
            this.Btn_usuarios.TabIndex = 28;
            this.Btn_usuarios.Text = "USUARIOS";
            this.Btn_usuarios.UseVisualStyleBackColor = true;
            this.Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            // 
            // Btn_contabilidad
            // 
            this.Btn_contabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_contabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_contabilidad.ForeColor = System.Drawing.Color.White;
            this.Btn_contabilidad.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_contabilidad.IconColor = System.Drawing.Color.White;
            this.Btn_contabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_contabilidad.IconSize = 40;
            this.Btn_contabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_contabilidad.Location = new System.Drawing.Point(9, 259);
            this.Btn_contabilidad.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_contabilidad.Name = "Btn_contabilidad";
            this.Btn_contabilidad.Size = new System.Drawing.Size(197, 55);
            this.Btn_contabilidad.TabIndex = 27;
            this.Btn_contabilidad.Text = "CONTABILIDAD";
            this.Btn_contabilidad.UseVisualStyleBackColor = true;
            this.Btn_contabilidad.Click += new System.EventHandler(this.Btn_contabilidad_Click);
            // 
            // Btn_ganaderia
            // 
            this.Btn_ganaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ganaderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ganaderia.ForeColor = System.Drawing.Color.White;
            this.Btn_ganaderia.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_ganaderia.IconColor = System.Drawing.Color.White;
            this.Btn_ganaderia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_ganaderia.IconSize = 40;
            this.Btn_ganaderia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ganaderia.Location = new System.Drawing.Point(9, 204);
            this.Btn_ganaderia.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ganaderia.Name = "Btn_ganaderia";
            this.Btn_ganaderia.Size = new System.Drawing.Size(197, 55);
            this.Btn_ganaderia.TabIndex = 26;
            this.Btn_ganaderia.Text = "GANADERIA";
            this.Btn_ganaderia.UseVisualStyleBackColor = true;
            this.Btn_ganaderia.Click += new System.EventHandler(this.Btn_ganaderia_Click);
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.Btn_Ventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Btn_Ventas.IconColor = System.Drawing.Color.White;
            this.Btn_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Ventas.IconSize = 40;
            this.Btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ventas.Location = new System.Drawing.Point(9, 149);
            this.Btn_Ventas.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.Size = new System.Drawing.Size(197, 55);
            this.Btn_Ventas.TabIndex = 25;
            this.Btn_Ventas.Text = "VENTAS";
            this.Btn_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Ventas.Click += new System.EventHandler(this.Btn_Ventas_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(21, 679);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 44);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            // 
            // MenuAcercade
            // 
            this.MenuAcercade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuAcercade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.MenuAcercade.FlatAppearance.BorderSize = 0;
            this.MenuAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuAcercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAcercade.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuAcercade.Location = new System.Drawing.Point(81, 679);
            this.MenuAcercade.Margin = new System.Windows.Forms.Padding(2);
            this.MenuAcercade.Name = "MenuAcercade";
            this.MenuAcercade.Size = new System.Drawing.Size(125, 44);
            this.MenuAcercade.TabIndex = 23;
            this.MenuAcercade.Text = "Acerca de";
            this.MenuAcercade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuAcercade.UseVisualStyleBackColor = false;
            this.MenuAcercade.Click += new System.EventHandler(this.MenuAcercade_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(27, 120);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(63, 13);
            this.lbl_Usuario.TabIndex = 22;
            this.lbl_Usuario.Text = "labelusuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PROYECTOQAG5.Properties.Resources.png_transparent_logo_business_logistics_service_business_angle_hand_service;
            this.pictureBox1.Location = new System.Drawing.Point(40, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cerrarSesion
            // 
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btn_cerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(0, 735);
            this.btn_cerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrarSesion.Name = "btn_cerrarSesion";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(219, 53);
            this.btn_cerrarSesion.TabIndex = 5;
            this.btn_cerrarSesion.Text = "Cerrar Sesion";
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.btn_cerrarSesion_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(219, 33);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1029, 788);
            this.PanelContenedor.TabIndex = 8;
            // 
            // PPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 821);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPrincipal";
            this.Load += new System.EventHandler(this.PPrincipal_Load);
            this.Resize += new System.EventHandler(this.PPrincipal_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cerrarSesion;
        private FontAwesome.Sharp.IconButton btn_minimizar;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Usuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button MenuAcercade;
        public FontAwesome.Sharp.IconButton Btn_Ventas;
        public FontAwesome.Sharp.IconButton Btn_negocio;
        public FontAwesome.Sharp.IconButton Btn_categorias;
        public FontAwesome.Sharp.IconButton Btn_producto;
        public FontAwesome.Sharp.IconButton Btn_usuarios;
        public FontAwesome.Sharp.IconButton Btn_contabilidad;
        public FontAwesome.Sharp.IconButton Btn_ganaderia;
    }
}