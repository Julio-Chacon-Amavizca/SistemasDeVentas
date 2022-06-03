using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CONTROLADOR;
using DATOS;
using MODELO;
using PROYECTOQAG5.Utilidad;

namespace PROYECTOQAG5
{
    public partial class PGanado : Form
    {
        public PGanado()
        {
            InitializeComponent();
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            PAgregarGanado Form = new PAgregarGanado();

            Form.ShowDialog();
        }

        private void Btn_DetalleBovino_Click(object sender, EventArgs e)
        {
            PDetalleGanado Form = new PDetalleGanado();

            Form.ShowDialog();
        }

        private void PGanado_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in Dgv_Ganado.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbxbusquedas.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbxbusquedas.DisplayMember = "Texto";
            cbxbusquedas.ValueMember = "Valor";
            cbxbusquedas.SelectedIndex = 0;

            //Mostrar las ganado en datagridView
            List<Ganado> listar = new M_Ganaderia().Listar();

            foreach (Ganado item in listar)
            {
                Dgv_Ganado.Rows.Add(new object[] {"",item.IdGanado,item.Apodo,item.Proposito,item.FechaAretado

            });
            }



                /*SqlConnection oconenexion = new SqlConnection(Conexion.cadena);
            string query = "select Idganado, Apodo, Proposito, FechaAretado, UPP from GANADO";
            SqlCommand cmd = new SqlCommand(query, oconenexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Dgv_Ganado.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_Ganado.DataSource = tabla;*/
        }

        private void Dgv_Ganado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if (Dgv_Ganado.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    Ganado objganado = new Ganado();
                    /* Usuario objusuario = new Usuario()
                     {
                         IdUsuario = Convert.ToInt32(txtid.Text),
                         Documento = txtUsuario.Text,
                         NombreCompleto = txtNombrecompleto.Text,
                         Correo = txtcorreo.Text,
                         Clave = txtContraseña.Text,
                         oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbxrolusuario.SelectedItem).valor) },
                         Estado = Convert.ToInt32(((OpcionCombo)cbxestadousuario.SelectedItem).valor) == 1 ? true : false
                     };

                    objganado.IdGanado = int.Parse(Dgv_Ganado.Rows[indice].Cells["IdGanado"].Value.ToString());
                    objganado.Apodo = Dgv_Ganado.Rows[indice].Cells["Apodo"].Value.ToString();
                    objganado.Proposito = Dgv_Ganado.Rows[indice].Cells["Proposito"].Value.ToString();
                    objganado.FechaAretado = Dgv_Ganado.Rows[indice].Cells["FechaAretado"].Value.ToString();


                    using (var form = new pModificarUsuario(objganado))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            //Aqui se tiene que recargar el DataGrid
                            Dgv_usuarios.Rows.Clear();
                            List<Usuario> listaUsuario = new M_Usuario().Listar();
                            foreach (Usuario item in listaUsuario)
                            {
                                Dgv_usuarios.Rows.Add(new object[] {
                                    "",
                                    item.IdUsuario,
                                    item.Documento,
                                    item.NombreCompleto,
                                    item.Correo,
                                    item.Clave,
                                    item.oRol.IdRol,
                                    item.oRol.Descripcion,
                                    item.Estado==true ?1:0,
                                    item.Estado==true ?"Activo":"No Activo"

                                });
                            }
                        }
                    }

                }

            }*/
        }

        private void Dgv_Ganado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbxbusquedas.SelectedItem).valor.ToString();

            if (Dgv_Ganado.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv_Ganado.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
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
    }
}
