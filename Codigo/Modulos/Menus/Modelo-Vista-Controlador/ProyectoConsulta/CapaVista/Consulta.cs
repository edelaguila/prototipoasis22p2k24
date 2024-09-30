using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        string emp = "Tbl_bitacora";
        Controlador cn = new Controlador();
        public Consulta(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Codigo", "Nombre", "Puesto", "Depto", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("empleados");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento examen");

        }

        //Mostrar los datos CAPA VISTA


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            Dgv_consulta.DataSource = dt;

        }

        private void Btn_consulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();



        }
    }
}
