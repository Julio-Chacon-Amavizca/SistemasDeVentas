using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using MODELO;
using PROYECTOQAG5.Utilidad;

namespace PROYECTOQAG5
{
    public partial class pModificarUsuario : Form
    {
        public pModificarUsuario(CONTROLADOR.Usuario objusuario)
        {
            InitializeComponent();
            txtid.Text = objusuario.IdUsuario.ToString();
            txtUsuario.Text = objusuario.Documento;
            txtNombrecompleto.Text = objusuario.NombreCompleto;
            txtcorreo.Text = objusuario.Correo;


            foreach (OpcionCombo oc in cbxrolusuario.Items)
            {
                if (Convert.ToInt32(oc.valor) == Convert.ToInt32(objusuario.oRol))
                {
                    int indice_combo = cbxrolusuario.Items.IndexOf(oc);
                    cbxrolusuario.SelectedIndex = indice_combo;
                    break;
                }
            }

            foreach (OpcionCombo oc in cbxestadousuario.Items)
            {
                if (Convert.ToInt32(oc.valor) == Convert.ToInt32(objusuario.Estado))
                {
                    int indice_combo = cbxestadousuario.Items.IndexOf(oc);
                    cbxestadousuario.SelectedIndex = indice_combo;
                    break;
                }
            }
        }

        private void pModificarUsuario_Load(object sender, EventArgs e)
        {
            cbxestadousuario.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cbxestadousuario.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cbxestadousuario.DisplayMember = "Texto";
            cbxestadousuario.ValueMember = "Valor";
            cbxestadousuario.SelectedIndex = 0;

            List<Rol> listaRol = new M_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cbxrolusuario.Items.Add(new OpcionCombo() { valor = item.IdRol, Texto = item.Descripcion });

            }
            cbxrolusuario.DisplayMember = "Texto";
            cbxrolusuario.ValueMember = "Valor";
            cbxrolusuario.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtUsuario.Text,
                NombreCompleto = txtNombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtContraseña.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbxrolusuario.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbxestadousuario.SelectedItem).valor) == 1 ? true : false
            };

                if (txtContraseña.Text != txtconfirmarcontraseña.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
                else
                {
                    bool resultado = new M_Usuario().Editar(objusuario, out mensaje);
                    if (resultado)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            
        }
    }
}
