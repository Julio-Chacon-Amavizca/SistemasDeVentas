using CONTROLADOR;
using MODELO;
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
    public partial class PDetalleVentas : Form
    {
        public PDetalleVentas()
        {
            InitializeComponent();
        }

        private void PDetalleVentas_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new M_Ventas().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {

                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;


                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.Subtotal });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");


            }
        }
    }
}
