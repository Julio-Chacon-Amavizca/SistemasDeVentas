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
                if (columna.Visible == true && columna.Name != "BtnInfo")
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
            /*List<Usuario> listaUsuario = new M_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                Dgv_ventas.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado==true ?1:0,
                    item.Estado==true ?"Activo":"No Activo"

            });

            }*/
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            { return; }

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.deleteicon.Width;
                var h = Properties.Resources.deleteicon.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deleteicon, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }
    }
}
