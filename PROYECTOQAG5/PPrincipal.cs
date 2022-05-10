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
using CONTROLADOR;
using MODELO;
using FontAwesome.Sharp;

namespace PROYECTOQAG5
{
    public partial class PPrincipal : Form
    {
        private int borderSize = 2;
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo;
        private static Form FormularioActivo;
        public PPrincipal(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }

        public PPrincipal()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }

        //drag form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void PPrincipal_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PPrincipal_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new M_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menuStrip.Items) 
            {
                bool encontrado = ListaPermisos.Any(m=> m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }
            lbl_Usuario.Text = usuarioActual.NombreCompleto;
        }


        public void AbrirFormHijo(object formhija)
        {
            
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
            
        }
        public void AbrirFormulario(IconMenuItem menu,Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(46, 59, 104);
            }
            menu.BackColor = Color.SteelBlue;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new PVenta(usuarioActual));
            //AbrirFormHijo(new PVentas());
        }

        private void MenuInventario_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(MenuInventario, new PInventario());
            //AbrirFormHijo(new PInventario());
        }

        private void MenuGanaderia_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuGanaderia, new PGanaderia());
            //AbrirFormHijo(new PGanaderia());
        }

        private void MenuContabilidad_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(MenuContabilidad, new PDetalleVentas());
            //AbrirFormHijo(new PContabilidad());
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuUsuarios, new PUsuarios());
            //AbrirFormHijo(new PUsuarios());
        }

        private void MenuPcategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInventario, new PCategoria());
        }

        private void MenuPproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInventario, new PInventario());
        }


        private void nEGOCIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInventario, new PNegocio());
        }

        private void MenuAcercade_Click(object sender, EventArgs e)
        {
            PAcercaDe frm = new PAcercaDe();
            frm.ShowDialog();
            //AbrirFormulario(MenuAcercade, new PAcercaDe());
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuContabilidad, new PDetalleVentas());
        }
    }
}
