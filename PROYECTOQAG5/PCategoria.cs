using CONTROLADOR;
using MODELO;
using PROYECTOQAG5.Utilidad;
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
    public partial class PCategoria : Form
    {
        public PCategoria()
        {
            InitializeComponent();
        }

        private void PCategoria_Load(object sender, EventArgs e)
        {
            txtDescripcion.Select();

            cbxestado.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cbxestado.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cbxestado.DisplayMember = "Texto";
            cbxestado.ValueMember = "Valor";
            cbxestado.SelectedIndex = 0;



            foreach (DataGridViewColumn columna in Dgv_usuarios.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbxbusquedas.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbxbusquedas.DisplayMember = "Texto";
            cbxbusquedas.ValueMember = "Valor";
            cbxbusquedas.SelectedIndex = 0;

            //Mostrar los datos en datagridView
            List<Categoria> lista = new M_Categoria().Listar();
            foreach (Categoria item in lista)
            {
                Dgv_usuarios.Rows.Add(new object[] {"",item.IdCategoria,item.Descripcion,
                    item.Estado==true ?1:0,
                    item.Estado==true ?"Activo":"No Activo"

            });

            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbxbusquedas.SelectedItem).valor.ToString();

            if (Dgv_usuarios.Rows.Count > 0)
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Categoria obj = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                Descripcion = txtDescripcion.Text,

                Estado = Convert.ToInt32(((OpcionCombo)cbxestado.SelectedItem).valor) == 1 ? true : false
            };

            if (obj.IdCategoria == 0)
            {
                int idgenereado = new M_Categoria().Registrar(obj, out mensaje);

                if (idgenereado != 0)
                {
                    Dgv_usuarios.Rows.Add(new object[] {"",idgenereado,txtDescripcion.Text,
                ((OpcionCombo)cbxestado.SelectedItem).valor.ToString(),
                ((OpcionCombo)cbxestado.SelectedItem).Texto.ToString()
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

                bool resultado = new M_Categoria().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = Dgv_usuarios.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbxestado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbxestado.SelectedItem).Texto.ToString();

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
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtDescripcion.Text = "";
            //txtbusqueda.Text = "";
            cbxestado.SelectedIndex = 0;

            txtDescripcion.Select();

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
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = Dgv_usuarios.Rows[indice].Cells["id"].Value.ToString();
                    txtDescripcion.Text = Dgv_usuarios.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in cbxestado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(Dgv_usuarios.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbxestado.Items.IndexOf(oc);
                            cbxestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea elminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new M_Categoria().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        Dgv_usuarios.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    
                }
            }
        }

        private void btnlimpiardatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
