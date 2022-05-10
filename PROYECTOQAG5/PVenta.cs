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
using PROYECTOQAG5;
using PROYECTOQAG5.Utilidad;

namespace PROYECTOQAG5
{
    public partial class PVenta : Form
    {
        private Usuario _usuario;
        public PVenta(Usuario oUsuario=null)
        {
            _usuario = oUsuario;
            InitializeComponent();
        }

        private void PVenta_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(_usuario.NombreCompleto);
            cbxtipodocumento.Items.Add(new OpcionCombo() {valor="Boleta", Texto="Boleta"});
            cbxtipodocumento.Items.Add(new OpcionCombo() { valor = "Factura", Texto = "Factura" });
            cbxtipodocumento.DisplayMember = "Texto";
            cbxtipodocumento.ValueMember = "Valor";
            cbxtipodocumento.SelectedIndex = 0;


            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproducto.Text = "0";
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var form = new PBuscarproducto())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = form._Producto.IdProducto.ToString();
                    txtProductoCodigo.Text = form._Producto.Codigo;
                    txtProductoNombre.Text = form._Producto.Nombre;
                    txtProductoDescripcion.Text = form._Producto.Descripcion;
                    txtStock.Text = form._Producto.Stock.ToString();
                    txtPrecioUnidad.Text = form._Producto.PrecioVenta.ToString();
                    txtCantidad.Select();
                }
                else {
                    txtProductoCodigo.Select();
                
                }
            }
        }

        private void txtProductoCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new M_Producto().Listar().Where(p =>p.Codigo==txtProductoCodigo.Text &&p.Estado==true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtProductoCodigo.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtProductoNombre.Text = oProducto.Nombre;
                    txtProductoDescripcion.Text = oProducto.Descripcion;
                    txtStock.Text = oProducto.Stock.ToString();
                    txtPrecioUnidad.Text = oProducto.PrecioVenta.ToString();

                }
                else
                {
                    txtProductoCodigo.BackColor = Color.Honeydew;
                    txtidproducto.Text = "0";
                    txtProductoNombre.Text = "";
                    txtProductoDescripcion.Text = "";
                    txtStock.Text = "";
                    txtPrecioUnidad.Text = "";

                }
            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            bool productoexiste = false;

            if (int.Parse(txtidproducto.Text)==0)
            {
                MessageBox.Show("Debe sellecionar un producto");
                return;
            }

            if (!decimal.TryParse(txtPrecioUnidad.Text,out precioventa))
            {
                MessageBox.Show("Precio Venta - formato moneda incorrecto", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtPrecioUnidad.Select();
                return;
            }

            foreach (DataGridViewRow fila in Dgv_usuarios.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString()==txtidproducto.Text)
                {
                    productoexiste = true;
                    break;
                }
            }

            if (!productoexiste)
            {
                string mensaje = string.Empty;
                bool respuesta = new M_Ventas().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtCantidad.Value.ToString())
                    
                    
                    );

                if (respuesta) {
                    Dgv_usuarios.Rows.Add(new object[] {
                txtidproducto.Text,
                txtProductoNombre.Text,
                txtPrecioUnidad.Text,
                txtCantidad.Value.ToString(),
                (txtCantidad.Value*precioventa).ToString("0.00")
                });
                }

                

                calcularTotal();
                LimpiarProducto();
            }
        }

        private void Dgv_usuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void LimpiarProducto()
        {
            txtProductoCodigo.Text = "";
            txtidproducto.Text = "0";
            txtProductoCodigo.BackColor = Color.White;
            txtProductoNombre.Text = "";
            txtProductoDescripcion.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCantidad.Value = 1;
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (Dgv_usuarios.Rows.Count>0)
            {
                foreach (DataGridViewRow row in Dgv_usuarios.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                
            }
            txttotalapagar.Text = total.ToString("0.00");
        }

        private void Dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_usuarios.Columns[e.ColumnIndex].Name == "btneliminar")
            {

                int indice = e.RowIndex;
                if (indice >=0)
                {
                    bool respuesta = new M_Ventas().SumarStock(
                        Convert.ToInt32(Dgv_usuarios.Rows[indice].Cells["IdProducto"].Value.ToString()),
                         Convert.ToInt32(Dgv_usuarios.Rows[indice].Cells["Cantidad"].Value.ToString())
                        );

                    if (respuesta) {
                        Dgv_usuarios.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                    
                }
               
            }
        }

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else {


                if (txtpagocon.Text.Trim().Length==0 && e.KeyChar.ToString()==".") {

                    e.Handled = true;
                
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString()==".") {

                        e.Handled = false;

                    }
                    else
                    {
                        e.Handled = true;
                    }
                    
                }
            
            
            }

        }

        private void calcularCamnbio()
        {
            decimal pagocon;
            decimal total = Convert.ToDecimal(txttotalapagar.Text);
            if (txttotalapagar.Text.Trim()=="")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (decimal.TryParse(txtpagocon.Text.Trim(),out pagocon))
            {
                if (pagocon<total) {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagocon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
            
        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                calcularCamnbio();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {


            if (Dgv_usuarios.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in Dgv_usuarios.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new M_Ventas().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularCamnbio();

            Venta oVenta = new Venta()
            {

                oUsuario = new Usuario() { IdUsuario = _usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbxtipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,

                MontoPago = Convert.ToDecimal(txtpagocon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalapagar.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new M_Ventas().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);


                Dgv_usuarios.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }




    }
}
