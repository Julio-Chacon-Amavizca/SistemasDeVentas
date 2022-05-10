using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADOR;

namespace PROYECTOQAG5
{
    public partial class Login : Form
    {
        private int borderSize = 2;

        public Login()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
           

        }

        //drag form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;

            }
            base.WndProc(ref m);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_iniciarSesion_Click(object sender, EventArgs e)
        {

            IniciarSesion();
            
        }

        private void IniciarSesion()
        {
            List<Usuario> TEST = new M_Usuario().Listar();

            Usuario ousuario = new M_Usuario().Listar().Where(u => u.Documento == Txt_usuarios.Text && u.Clave == Txt_contraseña.Text).FirstOrDefault();

            if (ousuario != null)
            {
                PPrincipal form = new PPrincipal(ousuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_usuarios.Focus();
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            Txt_usuarios.Text = "";
            Txt_contraseña.Text = "";
            this.Show();
        }

        private void Txt_usuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
