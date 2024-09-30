using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class Mantenimiento1 : Form
    {
        public Mantenimiento1(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "codigo", "nombre", "puesto", "depto.", "sueldo", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("empleado");
            navegador1.AsignarComboConTabla("puesto", "codigo_puesto", "nombre_puesto", 1);
            navegador1.AsignarComboConTabla("departamento", "codigo_departamento", "nombre_departamento", 1);
            
            navegador1.AsignarForaneas("puesto", "nombre_puesto", "codigo_puesto", "codigo_puesto");
            navegador1.AsignarForaneas("departamento", "nombre_departamento", "codigo_departamento", "codigo_departamento");
            
            navegador1.AsignarNombreForm("mantenimiento empleados");


        }
    }
}
