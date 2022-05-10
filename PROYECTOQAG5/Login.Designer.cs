
namespace PROYECTOQAG5
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Btn_salir;
            System.Windows.Forms.Button Btn_iniciarSesion;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new FontAwesome.Sharp.IconButton();
            this.Btn_close = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Txt_usuarios = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Btn_salir = new System.Windows.Forms.Button();
            Btn_iniciarSesion = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_salir
            // 
            Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_salir.FlatAppearance.BorderSize = 0;
            Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_salir.ForeColor = System.Drawing.Color.White;
            Btn_salir.Location = new System.Drawing.Point(108, 409);
            Btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Btn_salir.Name = "Btn_salir";
            Btn_salir.Size = new System.Drawing.Size(315, 46);
            Btn_salir.TabIndex = 24;
            Btn_salir.Text = "SALIR";
            Btn_salir.UseVisualStyleBackColor = false;
            Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_iniciarSesion
            // 
            Btn_iniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            Btn_iniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_iniciarSesion.FlatAppearance.BorderSize = 0;
            Btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_iniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_iniciarSesion.ForeColor = System.Drawing.Color.White;
            Btn_iniciarSesion.Location = new System.Drawing.Point(108, 348);
            Btn_iniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Btn_iniciarSesion.Name = "Btn_iniciarSesion";
            Btn_iniciarSesion.Size = new System.Drawing.Size(315, 46);
            Btn_iniciarSesion.TabIndex = 23;
            Btn_iniciarSesion.Text = "INICIAR SESION";
            Btn_iniciarSesion.UseVisualStyleBackColor = false;
            Btn_iniciarSesion.Click += new System.EventHandler(this.Btn_iniciarSesion_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Gainsboro;
            label2.Location = new System.Drawing.Point(104, 260);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 21);
            label2.TabIndex = 21;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Gainsboro;
            label1.Location = new System.Drawing.Point(104, 194);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 21);
            label1.TabIndex = 19;
            label1.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.Btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 41);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Btn_Minimizar.IconColor = System.Drawing.Color.White;
            this.Btn_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Minimizar.IconSize = 20;
            this.Btn_Minimizar.Location = new System.Drawing.Point(448, 0);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(44, 41);
            this.Btn_Minimizar.TabIndex = 2;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Visible = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
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
            this.Btn_close.Location = new System.Drawing.Point(492, 0);
            this.Btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(44, 41);
            this.Btn_close.TabIndex = 0;
            this.Btn_close.UseVisualStyleBackColor = false;
            this.Btn_close.Visible = false;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel2.Controls.Add(this.Txt_contraseña);
            this.panel2.Controls.Add(this.Txt_usuarios);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(Btn_salir);
            this.panel2.Controls.Add(Btn_iniciarSesion);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 551);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.ForeColor = System.Drawing.Color.White;
            this.Txt_contraseña.Location = new System.Drawing.Point(112, 290);
            this.Txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.PasswordChar = '*';
            this.Txt_contraseña.Size = new System.Drawing.Size(310, 27);
            this.Txt_contraseña.TabIndex = 22;
            this.Txt_contraseña.Text = "1234";
            this.Txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_usuarios_KeyPress);
            // 
            // Txt_usuarios
            // 
            this.Txt_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Txt_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_usuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuarios.ForeColor = System.Drawing.Color.White;
            this.Txt_usuarios.Location = new System.Drawing.Point(112, 225);
            this.Txt_usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_usuarios.Name = "Txt_usuarios";
            this.Txt_usuarios.Size = new System.Drawing.Size(310, 27);
            this.Txt_usuarios.TabIndex = 21;
            this.Txt_usuarios.Text = "Admin";
            this.Txt_usuarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_usuarios_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 536);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 15);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(168, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Minimizar;
        private FontAwesome.Sharp.IconButton Btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox Txt_usuarios;
        public System.Windows.Forms.TextBox Txt_contraseña;
    }
}

