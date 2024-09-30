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
    public partial class Navegador : Form
    {
        public Navegador(String idusuario)
        {
            InitializeComponent();


            ///************Con tabla que tenga comboboxs foraneas **********/
            string[] alias = { "codigo", "nombre", "linea", "marca", "existencia", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("productos");

            //List<String> tablas = new List<String> { "lineas", "marcas" };

            //navegador1.AsignarTablas(tablas);

            ///********Valores foraneos en Combobox************************/

            navegador1.AsignarComboConTabla("lineas", "codigo_linea", "nombre_linea", 1);
            navegador1.AsignarComboConTabla("marcas", "codigo_marca", "nombre_marca", 1);
            /**************************************************/

            ///************Se muestre en el dgv los nombres y no los numeros*******/

            navegador1.AsignarForaneas("lineas", "nombre_linea", "codigo_linea", "codigo_linea");
            navegador1.AsignarForaneas("marcas", "nombre_marca", "codigo_marca", "codigo_marca");

            ///*************************************************/

            navegador1.AsignarNombreForm("Productos");


            /***************************************************/


        }
    }
}
