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
    public partial class PGanado : Form
    {
        public PGanado()
        {
            InitializeComponent();
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            using (var form = new PAgregarGanado())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Dgv_ganado.Rows.Add(new object[]
                    {
                        form._Ganado.Arete,
                        form._Ganado.Nombre,
                        form._Ganado.Sexo
                    });
                }
            }


            /*
            PAgregarGanado Form = new PAgregarGanado();

            Form.ShowDialog();*/
        }

        private void Btn_DetalleBovino_Click(object sender, EventArgs e)
        {
            PDetalleGanado Form = new PDetalleGanado();

            Form.ShowDialog();
        }
    }
}
