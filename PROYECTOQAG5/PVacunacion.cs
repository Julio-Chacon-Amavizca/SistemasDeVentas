using DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOQAG5
{
    public partial class PVacunacion : Form
    {
        public PVacunacion()
        {
            InitializeComponent();
        }

        private void PVacunacion_Load(object sender, EventArgs e)
        {
            SqlConnection oconenexion = new SqlConnection(Conexion.cadena);
            string query = "select * FROM VACUNACION";
            SqlCommand cmd = new SqlCommand(query, oconenexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Dgv_usuarios.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_usuarios.DataSource = tabla;
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
    }
}
