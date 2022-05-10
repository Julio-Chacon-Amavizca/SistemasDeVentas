using CONTROLADOR;
using DATOS;
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
    public partial class PBuscarproducto : Form
    {

        public Producto _Producto { get; set; }

        public PBuscarproducto()
        {
            InitializeComponent();
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbxbusquedas.SelectedItem).valor.ToString();

            if (Dgv_usuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv_usuarios.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().Contains(txtbusqueda.Text.Trim().ToUpper()))
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

        private void PBuscarproducto_Load(object sender, EventArgs e)
        {


            foreach (DataGridViewColumn columna in Dgv_usuarios.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbxbusquedas.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbxbusquedas.DisplayMember = "Texto";
            cbxbusquedas.ValueMember = "Valor";
            cbxbusquedas.SelectedIndex = 0;

            List<Producto> listar = new M_Producto().Listar();
            foreach (Producto item in listar)
            {
                Dgv_usuarios.Rows.Add(new object[] {item.IdProducto,item.Codigo,item.Nombre,item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioVenta,
                    item.Estado==true ?1:0,
                    item.Estado==true ?"Activo":"No Activo"

            });
            }

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in Dgv_usuarios.Rows)
            {
                row.Visible = true;
            }
        }

        private void Dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            _Producto = new Producto()
            {

                IdProducto = Convert.ToInt32(Dgv_usuarios.Rows[iRow].Cells["Id"].Value.ToString()),
                Nombre = Dgv_usuarios.Rows[iRow].Cells["Nombre"].Value.ToString(),
                Codigo = Dgv_usuarios.Rows[iRow].Cells["Codigo"].Value.ToString(),
                Descripcion= Dgv_usuarios.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                Stock = Convert.ToInt32(Dgv_usuarios.Rows[iRow].Cells["Stock"].Value.ToString()),
                PrecioVenta = Convert.ToDecimal(Dgv_usuarios.Rows[iRow].Cells["PrecioVenta"].Value.ToString())
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    





        }
    }

