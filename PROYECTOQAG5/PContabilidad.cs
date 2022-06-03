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
using PROYECTOQAG5;
using PROYECTOQAG5.Utilidad;

namespace PROYECTOQAG5
{
    public partial class PContabilidad : Form
    {
        public PContabilidad()
        {
            InitializeComponent();

        }

        private void Dgv_ventas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void PContabilidad_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Select();
            

            foreach (DataGridViewColumn columna in Dgv_ventas.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbxbusquedas.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbxbusquedas.DisplayMember = "Texto";
            cbxbusquedas.ValueMember = "Valor";
            cbxbusquedas.SelectedIndex = 0;

             List<Venta> listaVenta = new M_Ventas().Listar();
             foreach (Venta item in listaVenta)
             {
                 Dgv_ventas.Rows.Add(new object[] {"",item.NumeroDocumento,item.oUsuario.NombreCompleto,item.MontoPago,item.FechaRegistro

                 });

             }

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbxbusquedas.SelectedItem).valor.ToString();

            if (Dgv_ventas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv_ventas.Rows)
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

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnbuscarproducto_Click(sender, e);
            }
        }
    }
}
