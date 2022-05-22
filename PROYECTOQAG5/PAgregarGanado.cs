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

namespace PROYECTOQAG5
{
    public partial class PAgregarGanado : Form
    {
        public Ganado _Ganado { get; set; }

        public PAgregarGanado()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            _Ganado = new Ganado()
            {
                Arete = Convert.ToInt32(txtArete.Text),
                Nombre = txtNombre.Text,
                Sexo = cbxSexo.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
