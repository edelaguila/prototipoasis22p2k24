using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento1
{
    public partial class Mantenimiento1 : Form
    {
        public Mantenimiento1(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Codigo", "Nombre", "Dirección", "NIT", "Teléfono", "estatus_cliente" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("clientes");
            navegador1.AsignarForaneas("vendedores", "Código de vendedor", "codigo_vendedor", "codigo_vendedor");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("CLIENTES");
        }
    }
}
