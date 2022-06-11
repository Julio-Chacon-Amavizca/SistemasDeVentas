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
    public partial class PAgregarGanado : Form
    {
        public PAgregarGanado()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            /*Ganado obj = new Ganado()
            {

        IdGanado = Convert.ToInt32(txtid.Text),
                Apodo = txtcodigo.Text,
                Sexo = txtnombre.Text,
                Proposito = txtdescripcion.Text,
                FechaNacimineto = Convert.ToDecimal(txtprecioventa.Text),
            FechaRegistro = Convert.ToDecimal(txtprecioventa.Text),
                oUPP = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbxcategoria.SelectedItem).valor) }
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

                bool resultado = new M_Ganaderia().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = Dgv_usuarios.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtcodigo.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;


                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbxcategoria.SelectedItem).valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbxcategoria.SelectedItem).Texto.ToString();
                    row.Cells["Stock"].Value = txtstock.Text;
                    row.Cells["PrecioVenta"].Value = txtprecioventa.Text;

                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbxestado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbxestado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);

                }
            }*/
        }
    }
}
