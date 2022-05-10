using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOQAG5
{
    public partial class PGanaderia : Form
    {
        PPrincipal fMain = new PPrincipal();
        private static IconMenuItem MenuActivo;
        private static Form FormularioActivo;
        public PGanaderia()
        {
            InitializeComponent();
        }

        public void AbrirFormularioGanaderia(IconMenuItem menu, Form formulario)
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

        private void MenuGanados_Click(object sender, EventArgs e)
        {
            AbrirFormularioGanaderia(MenuGanados, new PGanado());
        }
    }
}
