﻿using System;
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
        public Navegador(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "Codigo", "Nombre", "apellido", "telefono", "Dpi", "direccion", "fechanac"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("empleados");
            navegador1.ObtenerIdAplicacion("2000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento Examen");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
