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
    public partial class prueba2 : Form
    {
        public prueba2(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Pedido", "Fecha", "Monto", "Cliente", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("pedidos");
            navegador1.ObtenerIdAplicacion("61");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");


            //(Tabla, LlavePrimaria, Campo, 1)
            navegador1.AsignarComboConTabla("clientes", "cliente_id", "nombre", 1);

            //(Tabla, Campo, LlaveForanea, LlavePrimaria)
            navegador1.AsignarForaneas("clientes", "nombre", "cliente_id", "cliente_id");
            navegador1.AsignarNombreForm("Mantenimiento examen");
        }
    }
}
