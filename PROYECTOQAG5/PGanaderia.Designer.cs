
namespace PROYECTOQAG5
{
    partial class PGanaderia
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
            this.MenuGanaderia = new System.Windows.Forms.MenuStrip();
            this.MenuVacas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuGanados = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.uPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hACERVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManejo = new FontAwesome.Sharp.IconMenuItem();
            this.fERTILIDADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAvisos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuGanaderia.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGanaderia
            // 
            this.MenuGanaderia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.MenuGanaderia.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuGanaderia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVacas,
            this.MenuManejo,
            this.MenuAvisos,
            this.MenuReportes});
            this.MenuGanaderia.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuGanaderia.Location = new System.Drawing.Point(0, 0);
            this.MenuGanaderia.Name = "MenuGanaderia";
            this.MenuGanaderia.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuGanaderia.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuGanaderia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuGanaderia.Size = new System.Drawing.Size(1372, 66);
            this.MenuGanaderia.TabIndex = 3;
            this.MenuGanaderia.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // MenuVacas
            // 
            this.MenuVacas.AutoSize = false;
            this.MenuVacas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGanados,
            this.iconMenuItem2,
            this.uPPToolStripMenuItem,
            this.hACERVENTAToolStripMenuItem});
            this.MenuVacas.ForeColor = System.Drawing.Color.White;
            this.MenuVacas.IconChar = FontAwesome.Sharp.IconChar.HatCowboy;
            this.MenuVacas.IconColor = System.Drawing.Color.White;
            this.MenuVacas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVacas.IconSize = 50;
            this.MenuVacas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVacas.Name = "MenuVacas";
            this.MenuVacas.Size = new System.Drawing.Size(122, 62);
            this.MenuVacas.Text = "VACAS";
            this.MenuVacas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuVacas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // MenuGanados
            // 
            this.MenuGanados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MenuGanados.IconColor = System.Drawing.Color.Black;
            this.MenuGanados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuGanados.Name = "MenuGanados";
            this.MenuGanados.Size = new System.Drawing.Size(150, 22);
            this.MenuGanados.Text = "GANADO";
            this.MenuGanados.Click += new System.EventHandler(this.MenuGanados_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.iconMenuItem2.Text = "VACUNA";
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // uPPToolStripMenuItem
            // 
            this.uPPToolStripMenuItem.Name = "uPPToolStripMenuItem";
            this.uPPToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.uPPToolStripMenuItem.Text = "UPP";
            this.uPPToolStripMenuItem.Click += new System.EventHandler(this.uPPToolStripMenuItem_Click);
            // 
            // hACERVENTAToolStripMenuItem
            // 
            this.hACERVENTAToolStripMenuItem.Name = "hACERVENTAToolStripMenuItem";
            this.hACERVENTAToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hACERVENTAToolStripMenuItem.Text = "HACER VENTA";
            // 
            // MenuManejo
            // 
            this.MenuManejo.AutoSize = false;
            this.MenuManejo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fERTILIDADToolStripMenuItem});
            this.MenuManejo.ForeColor = System.Drawing.Color.White;
            this.MenuManejo.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.MenuManejo.IconColor = System.Drawing.Color.White;
            this.MenuManejo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuManejo.IconSize = 50;
            this.MenuManejo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuManejo.Name = "MenuManejo";
            this.MenuManejo.Size = new System.Drawing.Size(122, 62);
            this.MenuManejo.Text = "MANEJOS";
            this.MenuManejo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // fERTILIDADToolStripMenuItem
            // 
            this.fERTILIDADToolStripMenuItem.Name = "fERTILIDADToolStripMenuItem";
            this.fERTILIDADToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fERTILIDADToolStripMenuItem.Text = "PARTOS";
            this.fERTILIDADToolStripMenuItem.Click += new System.EventHandler(this.fERTILIDADToolStripMenuItem_Click);
            // 
            // MenuAvisos
            // 
            this.MenuAvisos.AutoSize = false;
            this.MenuAvisos.ForeColor = System.Drawing.Color.White;
            this.MenuAvisos.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.MenuAvisos.IconColor = System.Drawing.Color.White;
            this.MenuAvisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAvisos.IconSize = 50;
            this.MenuAvisos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAvisos.Name = "MenuAvisos";
            this.MenuAvisos.Size = new System.Drawing.Size(122, 62);
            this.MenuAvisos.Text = "AVISOS";
            this.MenuAvisos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem});
            this.MenuReportes.ForeColor = System.Drawing.Color.White;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.MenuReportes.IconColor = System.Drawing.Color.White;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(122, 62);
            this.MenuReportes.Text = "REPORTES";
            this.MenuReportes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            this.vENTASToolStripMenuItem.Click += new System.EventHandler(this.vENTASToolStripMenuItem_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 66);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1372, 818);
            this.PanelContenedor.TabIndex = 11;
            // 
            // PGanaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1372, 884);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuGanaderia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PGanaderia";
            this.Text = "PGanaderia";
            this.MenuGanaderia.ResumeLayout(false);
            this.MenuGanaderia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem MenuVacas;
        private FontAwesome.Sharp.IconMenuItem MenuManejo;
        private System.Windows.Forms.ToolStripMenuItem fERTILIDADToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MenuAvisos;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MenuGanaderia;
        private System.Windows.Forms.Panel PanelContenedor;
        private FontAwesome.Sharp.IconMenuItem MenuGanados;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hACERVENTAToolStripMenuItem;
    }
}