﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using CapaLogica;
using System.Data.Odbc;


/*---------------------------Creador: Allan Letona------------------------------*/

namespace CapaDiseno
{
    public partial class frm_asignacion_aplicaciones : Form
    {
        logica logic;

        //########## INICIA ALYSON RODRIGUEZ 9959-21-829
        public frm_asignacion_aplicaciones(string idUsuario)
        {
            InitializeComponent();
            Btn_guardar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_limpiar.Enabled = false;
            Cbo_usuarios.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_aplicaciones.Enabled = false;
            Dgv_asignaciones.Enabled = false;
            Dgv_aplicaciones_asignados.Enabled = false;
            logic = new logica(idUsuario);
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Crear Asignación");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_buscar, "Buscar Asignación");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_limpiar, "Limpiar Datos");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_guardar, "Guardar Asignación");
            ToolTip tsalir = new ToolTip();
            tsalir.SetToolTip(Btn_salir, "Salir Módulo de Asignación");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "Ayuda");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_eliminar, "Cancelar Asignación");
        }
        //####  FINALIZA ALYSON RODRIGUEZ 9959-21-829

        public frm_asignacion_aplicaciones()
        {
        }


        //María José Véliz 
        // Método para cargar los usuarios
        private void CargarUsuarios()
        {
            try
            {
                DataTable dtPerfiles = logic.funconsultaLogicaUsuarios();
                Cbo_usuarios.Items.Clear();
                foreach (DataRow row in dtPerfiles.Rows)
                {
                    Cbo_usuarios.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar usuarios: " + ex.Message);
            }
        }
        //termina

        //Trabajado María José Véliz
        private void Frm_asignacion_aplicaciones_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarModulos();
        }           
        //termina

        void limpieza()
        {
            Cbo_usuarios.Text = " ";
            Cbo_modulos.Text = " ";
            Cbo_aplicaciones.Text = " ";
        }

        void limpieza2()
        {
            Cbo_usuarios.Text = " ";
            Cbo_modulos.Text = " ";
            Cbo_aplicaciones.Text = " ";

            Dgv_aplicaciones_asignados.Columns.Clear();


            if (iContadorFila > 0)
            {
                Dgv_asignaciones.Rows.RemoveAt(Dgv_asignaciones.CurrentRow.Index);
                iContadorFila--;
            }
            else
            {
            }
        }

        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        // Método para cargar los módulos 
        private void CargarModulos()
        {
            try
            {
                DataTable dtModulos = logic.funconsultalogicamodulos();
                Cbo_modulos.Items.Clear();
                foreach (DataRow row in dtModulos.Rows)
                {
                    Cbo_modulos.Items.Add(row[0].ToString());
                }
                Cbo_modulos.SelectedIndexChanged += new EventHandler(Cbo_modulos_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar módulos: " + ex.Message);
            }
        }
        //FIN ALYSON RODRIGUEZ 9959-21-829

        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        // Método para cargar aplicaciones según el módulo seleccionado
        private void CargarAplicaciones(string nombreModulo)
        {
            try
            {
                DataTable dtAplicaciones = logic.funConsultaLogicaAplicaciones(nombreModulo);
                Cbo_aplicaciones.Items.Clear();
                foreach (DataRow row in dtAplicaciones.Rows)
                {
                    Cbo_aplicaciones.Items.Add(row["nombre_aplicacion"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar aplicaciones: " + ex.Message);
            }
        }
        //FIN ALYSON RODRIGURZ 9959-21-829


        // TRABAJADO POR ALYSON RODRIGURZ 9959-21-829
        private void Cbo_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Limpiar las aplicaciones antes de agregar nuevas

            if (Cbo_modulos.SelectedIndex != -1)
            {
                string moduloSeleccionado = Cbo_modulos.SelectedItem.ToString();
                CargarAplicaciones(moduloSeleccionado);
            }

        }
        //FIN ALYSON RODRIGURZ 9959-21-829



        //Trabajado María José Véliz
        private void Cbo_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbo_aplicaciones.SelectedItem != null)
            {
                string nombreAplicacion = Cbo_aplicaciones.SelectedItem.ToString();
                Console.WriteLine("Aplicación seleccionada: " + nombreAplicacion);
            }

        }
        //Termina


        public static int iContadorFila = 0;

        //Trabajado María José Véliz   //Cambios Trabajados por Alyson Rodriguez 9959-21-829
        // Método para configurar CheckBoxColumns en el DataGridView
        private void ConfigurarColumnasCheckBox()
        {

            // Asegurarte de que el DataGridView esté vacío antes de configurar columnas
            Dgv_asignaciones.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fk_id_usuario", HeaderText = "Usuario" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "nombre_aplicacion", HeaderText = "Aplicación" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "guardar_permiso", HeaderText = "Ingresar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "buscar_permiso", HeaderText = "Consultar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "modificar_permiso", HeaderText = "Modificar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "eliminar_permiso", HeaderText = "Eliminar" });
            Dgv_asignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "imprimir_permiso", HeaderText = "Imprimir" });


            // Lista de las columnas que son CheckBox y necesitan configuración
            string[] sPermisosColumnas = { "Ingresar", "Consultar", "Modificar", "Eliminar", "Imprimir" };

            foreach (string columna in sPermisosColumnas)
            {
                // Verificar si la columna existe en el DataGridView
                if (Dgv_asignaciones.Columns.Contains(columna))
                {
                    if (Dgv_asignaciones.Columns[columna] is DataGridViewCheckBoxColumn checkBoxColumn)
                    {
                        // Configurar permisos habilitados o deshabilitados para cada columna CheckBox
                        checkBoxColumn.TrueValue = 1;
                        checkBoxColumn.FalseValue = 0;
                    }
                }
            }
        }
        //Termina


        //Trabajado por Alyson Rodriguez 9959-21-829
        public void actualizardatagriew()
        {


            try
            {
                // Obtener los datos desde la base de datos
                DataTable dt = logic.funConsultaLogicaUsuarios("Tbl_permisos_aplicaciones_usuario");

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    Dgv_aplicaciones_asignados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los datos: {ex.Message}");
            }
        }
        //##################Finaliza##################


        private void Dgv_asignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
           
        }


        //Trabajado María José Véliz
        private bool isInitialized = false;
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            if (!isInitialized)
            {
                Btn_guardar.Enabled = true;
                Cbo_usuarios.Enabled = true;
                Cbo_modulos.Enabled = true;
                Cbo_aplicaciones.Enabled = true;
                Dgv_asignaciones.Enabled = true;
                Btn_eliminar.Enabled = false;



                MessageBox.Show("Empieza la asignación.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isInitialized = true; // Cambiar el estado a inicializado
                return; // Salir del método después de la habilitación
            }

            // Verificar si los tres ComboBox tienen una selección
            if (Cbo_usuarios.SelectedItem != null && Cbo_modulos.SelectedItem != null && Cbo_aplicaciones.SelectedItem != null)
            {
                Btn_eliminar.Enabled = true; // Activar botón Eliminar solo si los tres están seleccionados
            }
            else
            {
                Btn_eliminar.Enabled = false; // Desactivar si no se seleccionaron los tres
            }


            // Validar si hay campos vacíos
            if (Cbo_aplicaciones.SelectedItem == null || Cbo_usuarios.SelectedItem == null)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método si hay campos vacíos
            }
            else
            {
                bool bUsuario_aplicacion_existente = false;

                string sUsuario = Cbo_usuarios.SelectedItem.ToString();
                string sAplicacion = Cbo_aplicaciones.SelectedItem.ToString();



                if (iContadorFila > 0)
                {
                    Dgv_asignaciones.Rows.Add(sUsuario, sAplicacion);

                    iContadorFila++;


                }
                else
                {
                    foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == Cbo_usuarios.SelectedItem.ToString() && Fila.Cells[1].Value.ToString() == Cbo_aplicaciones.SelectedItem.ToString())

                        {
                            bUsuario_aplicacion_existente = true;
                        }
                    }

                    if (bUsuario_aplicacion_existente == true)
                    {
                        MessageBox.Show("Ya existe una relacion del usuario con la aplicacion");
                    }
                    else
                    {
                        Dgv_asignaciones.Rows.Add(sUsuario, sAplicacion);
                        iContadorFila++;
                    }
                }

                limpieza();
            }
        }
        //Tremina


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            Btn_eliminar.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_agregar.Enabled = false;
            Btn_limpiar.Enabled = true;
            Btn_eliminar.Enabled = false;
            Dgv_aplicaciones_asignados.Enabled = true;
            actualizardatagriew();
        }

        private void btn_remover_Click_1(object sender, EventArgs e)
        {
            Btn_agregar.Enabled = true;
            Cbo_usuarios.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_aplicaciones.Enabled = false;
            Dgv_asignaciones.Enabled = false;
            Btn_limpiar.Enabled = false;
            Dgv_aplicaciones_asignados.Enabled = false;
            limpieza2();
        }

        // FINALIZA ALYSON RODRIGUEZ 9959-21-829 
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string sIngresar;
            string sConsulta;
            string sModificar;
            string sEliminar;
            string sImprimir;

            try
            {
                bool hayCheckboxMarcado = false; // Variable para verificar checkboxes

                foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                {
                    // Verificar si hay algún checkbox marcado
                    if ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Modificar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Eliminar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Consultar"].EditedFormattedValue) ||
                        (bool)(Fila.Cells["Imprimir"].EditedFormattedValue))
                    {
                        hayCheckboxMarcado = true; // Al menos un checkbox está marcado
                        break; // Salir del bucle si encontramos al menos un checkbox marcado
                    }
                }

                // Si no hay checkboxes marcados, mostrar mensaje y salir
                if (!hayCheckboxMarcado)
                {
                    MessageBox.Show("Debe seleccionar al menos una opción antes de guardar.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método
                }
           

                foreach (DataGridViewRow Fila in Dgv_asignaciones.Rows)
                {
                    string sUsuario = Fila.Cells[0].Value.ToString();
                    string sAplicacion = Fila.Cells[1].Value.ToString();


                    bool cheked = ((bool)(Fila.Cells["Ingresar"].EditedFormattedValue));
                    if (cheked)
                        sIngresar = "1";
                    else
                        sIngresar = "0";

                    bool chekedM = ((bool)(Fila.Cells["Modificar"].EditedFormattedValue));
                    if (chekedM)
                        sModificar = "1";
                    else
                        sModificar = "0";

                    bool chekedE = ((bool)(Fila.Cells["Eliminar"].EditedFormattedValue));
                    if (chekedE)
                        sEliminar = "1";
                    else
                        sEliminar = "0";

                    bool chekedC = ((bool)(Fila.Cells["Consultar"].EditedFormattedValue));
                    if (chekedC)
                        sConsulta = "1";
                    else
                        sConsulta = "0";

                    bool chekedI = ((bool)(Fila.Cells["Imprimir"].EditedFormattedValue));
                    if (chekedI)
                        sImprimir = "1";
                    else
                        sImprimir = "0";

                    // Mostrar mensaje con los datos de cada fila antes de insertar
                    MessageBox.Show(
                        $"Datos de la fila:\n" +
                        $"Usuario: {sUsuario}\n" +
                        $"Aplicación: {sAplicacion}\n" +
                        $"Ingresar: {sIngresar}\n" +
                        $"Consultar: {sConsulta}\n" +
                        $"Modificar: {sModificar}\n" +
                        $"Eliminar: {sEliminar}\n" +
                        $"Imprimir: {sImprimir}",
                        "Datos de la Fila",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DataTable dtAplicaciones = logic.funConsultaLogicaPermisosUsuarioAplicacion(sUsuario, sAplicacion, sIngresar, sConsulta, sModificar, sEliminar, sImprimir);

                }

                MessageBox.Show("Datos ingresados exitosamente");
                Btn_guardar.Enabled = false;
                Btn_eliminar.Enabled = false;
                Btn_limpiar.Enabled = false;
                Cbo_usuarios.Enabled = false;
                Cbo_modulos.Enabled = false;
                Cbo_aplicaciones.Enabled = false;
                Dgv_asignaciones.Enabled = false;
                Dgv_aplicaciones_asignados.Enabled = false;
                limpieza();
                Dgv_asignaciones.Rows.Clear();
                iContadorFila = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        // FINALIZA ALYSON RODRIGUEZ 9959-21-829 

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ayuda_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda_Seguridad\\" + "AyudaAsignacionAplicacionesUsuarios.chm", "Asignacion_Aplicaciones_Usuarios.html");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Btn_agregar.Enabled = true;
            Btn_guardar.Enabled = false;
            Btn_limpiar.Enabled = false;
            Cbo_usuarios.Enabled = false;
            Cbo_modulos.Enabled = false;
            Cbo_aplicaciones.Enabled = false;
            Dgv_asignaciones.Enabled = false;

            if (iContadorFila > 0 && Dgv_asignaciones.CurrentRow != null)
            {
                // Eliminar la fila seleccionada
                Dgv_asignaciones.Rows.RemoveAt(Dgv_asignaciones.CurrentRow.Index);
                iContadorFila--;

                // Limpiar los ComboBox para evitar agregar la misma relación
                Cbo_usuarios.SelectedItem = null;
                Cbo_aplicaciones.SelectedItem = null;

                // Restablecer el estado de isInitialized
                isInitialized = false; // Permitir que se muestre el mensaje la próxima vez que se agregue
            }
            else
            {
                MessageBox.Show("No hay relaciones que eliminar");
            }

        }
    }
}
