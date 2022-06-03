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
    public partial class PPesajes : Form
    {
        public PPesajes()
        {
            InitializeComponent();
        }

        private void PPesajes_Load(object sender, EventArgs e)
        {
            SqlConnection oconenexion = new SqlConnection(Conexion.cadena);
            string query = "select * FROM PESAJES";
            SqlCommand cmd = new SqlCommand(query, oconenexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Dgv_usuarios.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            Dgv_usuarios.DataSource = tabla;
        }
    }
}
