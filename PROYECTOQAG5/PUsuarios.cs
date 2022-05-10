using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTOQAG5.Utilidad;
using CONTROLADOR;
using MODELO;

namespace PROYECTOQAG5
{
    public partial class PUsuarios : Form
    {
        public PUsuarios()
        {
            InitializeComponent();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            PModificarUsuarios frm = new PModificarUsuarios();
            frm.ShowDialog();

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            PAgregarUsuarios frm = new PAgregarUsuarios();
            frm.ShowDialog();
        }

        private void PUsuarios_Load(object sender, EventArgs e)
        {
            txtNombrecompleto.Select();

            cbxestadousuario.Items.Add(new OpcionCombo() { valor = 1, Texto="Activo"});
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

            foreach(DataGridViewColumn columna in Dgv_usuarios.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbxbusquedas.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }                
            }
            cbxbusquedas.DisplayMember = "Texto";
            cbxbusquedas.ValueMember = "Valor";
            cbxbusquedas.SelectedIndex = 0;

            //Mostrar los usuarios en datagridView
            List<Usuario> listaUsuario = new M_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                Dgv_usuarios.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado==true ?1:0,
                    item.Estado==true ?"Activo":"No Activo"

            });

            }
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

            if (objusuario.IdUsuario==0)
            {
                int idusuariogenereado = new M_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenereado != 0)
                {
                    Dgv_usuarios.Rows.Add(new object[] {"",idusuariogenereado,txtUsuario.Text,txtNombrecompleto.Text,txtcorreo.Text,txtContraseña.Text,
                ((OpcionCombo)cbxrolusuario.SelectedItem).valor.ToString(),
                ((OpcionCombo)cbxrolusuario.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cbxestadousuario.SelectedItem).valor.ToString(),
                ((OpcionCombo)cbxestadousuario.SelectedItem).Texto.ToString()
            });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {

                bool resultado = new M_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = Dgv_usuarios.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Usuario"].Value = txtUsuario.Text;
                    row.Cells["NombreCompleto"].Value = txtNombrecompleto.Text;
                    row.Cells["Contraseña"].Value = txtContraseña.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cbxrolusuario.SelectedItem).valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbxrolusuario.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbxestadousuario.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbxestadousuario.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else 
                {
                    MessageBox.Show(mensaje);
                
                }
            }
           



           
        }

        private void Limpiar()
        {
            txtindice.Text  = "-1";
            txtid.Text = "0";
            txtUsuario.Text = "";
            txtNombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtContraseña.Text = "";
            txtconfirmarcontraseña.Text = "";
            cbxrolusuario.SelectedIndex = 0;
            cbxestadousuario.SelectedIndex = 0;

            txtUsuario.Select();

        }

        private void Dgv_usuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
            { return; }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.checkicon.Width;
                var h = Properties.Resources.checkicon.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.checkicon, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void Dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Dgv_usuarios.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;
                if (indice>=0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = Dgv_usuarios.Rows[indice].Cells["id"].Value.ToString();
                    txtUsuario.Text = Dgv_usuarios.Rows[indice].Cells["Usuario"].Value.ToString();
                    txtNombrecompleto.Text = Dgv_usuarios.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = Dgv_usuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtContraseña.Text = Dgv_usuarios.Rows[indice].Cells["Contraseña"].Value.ToString();
                    txtconfirmarcontraseña.Text = Dgv_usuarios.Rows[indice].Cells["Contraseña"].Value.ToString();
                    foreach (OpcionCombo oc in cbxrolusuario.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(Dgv_usuarios.Rows[indice].Cells["IdRol"].Value)) 
                        {
                            int indice_combo = cbxrolusuario.Items.IndexOf(oc);
                            cbxrolusuario.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbxestadousuario.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(Dgv_usuarios.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbxestadousuario.Items.IndexOf(oc);
                            cbxestadousuario.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }

            }

        }

        private void btnlimpiardatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea elminar el usuario?","Mensaje", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new M_Usuario().Eliminar(objusuario, out mensaje);
                    
                    if (respuesta)
                    {
                        Dgv_usuarios.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    }

                    
                }
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbxbusquedas.SelectedItem).valor.ToString();
            
            if (Dgv_usuarios.Rows.Count>0) 
            {
                foreach (DataGridViewRow row in Dgv_usuarios.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else 
                    {

                        row.Visible = false;

                    }
                }

            }


        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in Dgv_usuarios.Rows)
            {
                row.Visible = true;
            }
        }










    }
}
