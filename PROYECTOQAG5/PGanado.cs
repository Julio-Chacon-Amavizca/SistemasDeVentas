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
using ClosedXML.Excel;

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
        }

        private void Dgv_Ganado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (Dgv_Ganado.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in Dgv_Ganado.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow Row in Dgv_Ganado.Rows)
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
