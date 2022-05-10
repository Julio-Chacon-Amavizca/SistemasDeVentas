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
    public partial class PVentas : Form
    {

        public PVentas()
        {
            InitializeComponent();

        
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            PReporteVentas frm = new PReporteVentas();
            frm.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            PBusquedaProducto frm = new PBusquedaProducto();
            frm.ShowDialog();
        }
    }
}
