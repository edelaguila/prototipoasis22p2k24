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
    public partial class Mantenimiento_Concepto : Form
    {
        public Mantenimiento_Concepto(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "ID", "Nombre", "Efecto", "EstadoC", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.AsignarTabla("Concepto");
            //  List<string> tablas = new List<string> { "detallefactura", "pagos" };
            //  navegador1.AsignarTablas(tablas);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("CONCEPTO");
        }
    }
}
