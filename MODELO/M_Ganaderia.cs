using CONTROLADOR;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MODELO
{
    public class M_Ganaderia
    {
        private C_Ganaderia objecd_Ganaderia = new C_Ganaderia();

        public List<Ganado> Listar()
        {
            return objecd_Ganaderia.Listar();
        }



    }
}
