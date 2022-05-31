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
            SqlConnection oconenexion = new SqlConnection(Conexion.cadena);
            string query = "select Idganado, Apodo, Proposito, FechaAretado, UPP from GANADO";
            SqlCommand cmd = new SqlCommand(query, oconenexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Dgv_ganado.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_ganado.DataSource = tabla;
        }
    }
}
