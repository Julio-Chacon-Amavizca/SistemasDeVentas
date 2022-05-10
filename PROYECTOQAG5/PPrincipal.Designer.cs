
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuGanaderia = new FontAwesome.Sharp.IconMenuItem();
            this.MenuContabilidad = new FontAwesome.Sharp.IconMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInventario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuPcategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPproducto = new System.Windows.Forms.ToolStripMenuItem();
            this.nEGOCIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MenuAcercade = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.panel2.Controls.Add(this.toolStripContainer1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.MenuAcercade);
            this.panel2.Controls.Add(this.lbl_Usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_cerrarSesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 788);
            this.panel2.TabIndex = 7;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(185, 353);
            this.toolStripContainer1.Location = new System.Drawing.Point(21, 189);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(185, 353);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVentas,
            this.MenuGanaderia,
            this.MenuContabilidad,
            this.MenuUsuarios,
            this.MenuInventario});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(185, 353);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.ForeColor = System.Drawing.Color.White;
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.White;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(240, 69);
            this.MenuVentas.Text = "VENTAS";
            this.MenuVentas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuVentas.Click += new System.EventHandler(this.MenuVentas_Click);
            // 
            // MenuGanaderia
            // 
            this.MenuGanaderia.AutoSize = false;
            this.MenuGanaderia.ForeColor = System.Drawing.Color.White;
            this.MenuGanaderia.IconChar = FontAwesome.Sharp.IconChar.HatCowboy;
            this.MenuGanaderia.IconColor = System.Drawing.Color.White;
            this.MenuGanaderia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuGanaderia.IconSize = 50;
            this.MenuGanaderia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuGanaderia.Name = "MenuGanaderia";
            this.MenuGanaderia.Size = new System.Drawing.Size(240, 69);
            this.MenuGanaderia.Text = "GANADERIA";
            this.MenuGanaderia.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuGanaderia.Click += new System.EventHandler(this.MenuGanaderia_Click);
            // 
            // MenuContabilidad
            // 
            this.MenuContabilidad.AutoSize = false;
            this.MenuContabilidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem});
            this.MenuContabilidad.ForeColor = System.Drawing.Color.White;
            this.MenuContabilidad.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.MenuContabilidad.IconColor = System.Drawing.Color.White;
            this.MenuContabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuContabilidad.IconSize = 50;
            this.MenuContabilidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuContabilidad.Name = "MenuContabilidad";
            this.MenuContabilidad.Size = new System.Drawing.Size(240, 69);
            this.MenuContabilidad.Text = "CONTABILIDAD";
            this.MenuContabilidad.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuContabilidad.Click += new System.EventHandler(this.MenuContabilidad_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.AutoSize = false;
            this.MenuUsuarios.ForeColor = System.Drawing.Color.White;
            this.MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.MenuUsuarios.IconColor = System.Drawing.Color.White;
            this.MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuarios.IconSize = 50;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(240, 69);
            this.MenuUsuarios.Text = "USUARIOS";
            this.MenuUsuarios.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // MenuInventario
            // 
            this.MenuInventario.AutoSize = false;
            this.MenuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPcategoria,
            this.MenuPproducto,
            this.nEGOCIOToolStripMenuItem});
            this.MenuInventario.ForeColor = System.Drawing.Color.White;
            this.MenuInventario.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuInventario.IconColor = System.Drawing.Color.White;
            this.MenuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInventario.IconSize = 50;
            this.MenuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInventario.Name = "MenuInventario";
            this.MenuInventario.Size = new System.Drawing.Size(240, 69);
            this.MenuInventario.Text = "CONFIGURACIONES";
            this.MenuInventario.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuInventario.Click += new System.EventHandler(this.MenuInventario_Click);
            // 
            // MenuPcategoria
            // 
            this.MenuPcategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPcategoria.Name = "MenuPcategoria";
            this.MenuPcategoria.Size = new System.Drawing.Size(166, 24);
            this.MenuPcategoria.Text = "CATEGORIA";
            this.MenuPcategoria.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuPcategoria.Click += new System.EventHandler(this.MenuPcategoria_Click);
            // 
            // MenuPproducto
            // 
            this.MenuPproducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPproducto.Name = "MenuPproducto";
            this.MenuPproducto.Size = new System.Drawing.Size(166, 24);
            this.MenuPproducto.Text = "PRODUCTO";
            this.MenuPproducto.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MenuPproducto.Click += new System.EventHandler(this.MenuPproducto_Click);
            // 
            // nEGOCIOToolStripMenuItem
            // 
            this.nEGOCIOToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nEGOCIOToolStripMenuItem.Name = "nEGOCIOToolStripMenuItem";
            this.nEGOCIOToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.nEGOCIOToolStripMenuItem.Text = "NEGOCIO";
            this.nEGOCIOToolStripMenuItem.Click += new System.EventHandler(this.nEGOCIOToolStripMenuItem_Click_1);
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
            this.MenuAcercade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAcercade.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuAcercade.Location = new System.Drawing.Point(81, 679);
            this.MenuAcercade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lbl_Usuario.Location = new System.Drawing.Point(27, 151);
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
            this.label1.Location = new System.Drawing.Point(79, 129);
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
            this.pictureBox1.Location = new System.Drawing.Point(40, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_cerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuInventario;
        private FontAwesome.Sharp.IconMenuItem MenuGanaderia;
        private FontAwesome.Sharp.IconMenuItem MenuContabilidad;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem MenuPcategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuPproducto;
        private System.Windows.Forms.ToolStripMenuItem nEGOCIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
    }
}