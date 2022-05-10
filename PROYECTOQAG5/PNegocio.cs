using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using MODELO;
using PROYECTOQAG5;

namespace PROYECTOQAG5
{
    public partial class PNegocio : Form
    {
        public PNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes) {

            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes,0,imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;

        }


        private void PNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new M_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                piclogo.Image = ByteToImage(byteimage);

            Negocio datos = new M_Negocio().ObtenerDatos();
            txtnombre.Text = datos.Nombre;
            txtruc.Text = datos.RUC;
            txtdireccion.Text = datos.Direccion;
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog()==DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new M_Negocio().ActualizarLogo(byteimage,out mensaje);
                if (respuesta)
                    piclogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje,"Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void cbxguardarcambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {

            Nombre = txtnombre.Text,
            RUC= txtruc.Text,
            Direccion= txtdireccion.Text

            };

            bool respuesta = new M_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados exitosamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Los cambios NO fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
