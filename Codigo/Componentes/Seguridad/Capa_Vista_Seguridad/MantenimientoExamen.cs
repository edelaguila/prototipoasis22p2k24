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
    public partial class MantenimientoExamen : Form
    {
        public MantenimientoExamen(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Sucursal", "Empresa", "Nombre", "Direccion", "Telefono", "CodigoPostal","Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("sucursal");
            navegador1.AsignarComboConTabla("empresa", "idEmpresa", "nombre", 1);
            
            navegador1.AsignarForaneas("empresa", "nombre", "idEmpresa", "idEmpresa");
            
            navegador1.AsignarNombreForm("Sucursal");
        }
    }
   }

