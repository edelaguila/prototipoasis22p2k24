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
    public partial class Mantanimiento : Form
    {
        public Mantanimiento(string IdUsuario)
        {
           
            InitializeComponent();
            string[] alias = { "pk.idEmpleado", "Nombre", "Apellido", "Telefono" ,"Dpi", "Direccion", "FechasNacimiento", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_empleados");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(IdUsuario);
            navegador1.AsignarAyuda("2");
            navegador1.AsignarNombreForm("admin");
        }
    }
}
