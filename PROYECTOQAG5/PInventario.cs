using ClosedXML.Excel;
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
    public partial class PInventario : Form
    {
        public PInventario()
        {
            InitializeComponent();
        }

        private void PInventario_Load(object sender, EventArgs e)
        {
            txtcodigo.Select();

            cbxestado.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cbxestado.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cbxestado.DisplayMember = "Texto";
            cbxestado.ValueMember = "Valor";
            cbxestado.SelectedIndex = 0;

            List<Categoria> lista = new M_Categoria().Listar();
            foreach (Categoria item in lista)
            {
                cbxcategoria.Items.Add(new OpcionCombo() { valor = item.IdCategoria, Texto = item.Descripcion });

            }
            cbxcategoria.DisplayMember = "Texto";
            cbxcategoria.ValueMember = "Valor";
            cbxcategoria.SelectedIndex = 0;

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

            //Mostrar las categorias en datagridView
            List<Producto> listar = new M_Producto().Listar();
            foreach (Producto item in listar)
            {
                Dgv_usuarios.Rows.Add(new object[] {"",item.IdProducto,item.Codigo,item.Nombre,item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioVenta,
                    item.Estado==true ?1:0,
                    item.Estado==true ?"Activo":"No Activo"

            });

            }
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto obj = new Producto()
            {

                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Descripcion = txtdescripcion.Text,

                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbxcategoria.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbxestado.SelectedItem).valor) == 1 ? true : false
            };

            if (obj.IdProducto == 0)
            {
                int idgenereado = new M_Producto().Registrar(obj, out mensaje);

                if (idgenereado != 0)
                {
                    Dgv_usuarios.Rows.Add(new object[] {"",
                        idgenereado,
                        txtcodigo.Text,
                        txtnombre.Text,
                        txtdescripcion.Text,
                        ((OpcionCombo)cbxcategoria.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cbxcategoria.SelectedItem).Texto.ToString(),
                        "0",
                        "0.00",
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

                bool resultado = new M_Producto().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = Dgv_usuarios.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtcodigo.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;


                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbxcategoria.SelectedItem).valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbxcategoria.SelectedItem).Texto.ToString();


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

        private void btnlimpiardatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";

            cbxcategoria.SelectedIndex = 0;
            cbxestado.SelectedIndex = 0;

            txtcodigo.Select();

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
                    txtcodigo.Text = Dgv_usuarios.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = Dgv_usuarios.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = Dgv_usuarios.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cbxcategoria.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(Dgv_usuarios.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbxcategoria.Items.IndexOf(oc);
                            cbxcategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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
                if (MessageBox.Show("¿Desea elminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };


                    bool respuesta = new M_Producto().Eliminar(obj, out mensaje);

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

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in Dgv_usuarios.Rows)
            {
                row.Visible = true;
            }
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            if(Dgv_usuarios.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in Dgv_usuarios.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow  Row in Dgv_usuarios.Rows)
                {
                    if (Row.Visible)
                        dt.Rows.Add(new object[]{
                            Row.Cells[2].Value.ToString(),
                            Row.Cells[3].Value.ToString(),
                            Row.Cells[4].Value.ToString(),
                            Row.Cells[6].Value.ToString(),
                            Row.Cells[7].Value.ToString(),
                            Row.Cells[8].Value.ToString(),
                            Row.Cells[10].Value.ToString()
                    });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try 
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);

                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } 
                    catch 
                    {
                        MessageBox.Show("Error al generar el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }
    }
}
