
namespace Capa_Vista_Seguridad
{
    partial class frm_empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.Gpb_datospersonalesclave = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_preguntausuario = new System.Windows.Forms.Label();
            this.Txt_respuestausuario = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.Label();
            this.txt_estadousuario = new System.Windows.Forms.TextBox();
            this.Gpb_datospersonales = new System.Windows.Forms.GroupBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_correousuario = new System.Windows.Forms.Label();
            this.Txt_dpi = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_nombreusuario = new System.Windows.Forms.Label();
            this.Txt_apellidousuario = new System.Windows.Forms.Label();
            this.Gpb_datosusuario = new System.Windows.Forms.GroupBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Txt_idusuario = new System.Windows.Forms.Label();
            this.Txt_usernameusuario = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_contraseniausuario = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Gpb_modificar = new System.Windows.Forms.GroupBox();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Txt_buscar_id = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.Txt_fechanacimiento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.Gpb_datospersonalesclave.SuspendLayout();
            this.Gpb_datospersonales.SuspendLayout();
            this.Gpb_datosusuario.SuspendLayout();
            this.Gpb_modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_titulo.Location = new System.Drawing.Point(506, 9);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(666, 76);
            this.Txt_titulo.TabIndex = 272;
            this.Txt_titulo.Text = "Mantenimiento de Empleados";
            this.Txt_titulo.Click += new System.EventHandler(this.Txt_titulo_Click);
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(58, 474);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.RowHeadersWidth = 72;
            this.Dgv_usuarios.RowTemplate.Height = 31;
            this.Dgv_usuarios.Size = new System.Drawing.Size(1436, 239);
            this.Dgv_usuarios.TabIndex = 271;
            // 
            // Gpb_datospersonalesclave
            // 
            this.Gpb_datospersonalesclave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datospersonalesclave.Controls.Add(this.Txt_fechanacimiento);
            this.Gpb_datospersonalesclave.Controls.Add(this.textBox1);
            this.Gpb_datospersonalesclave.Controls.Add(this.txt_preguntausuario);
            this.Gpb_datospersonalesclave.Controls.Add(this.Txt_respuestausuario);
            this.Gpb_datospersonalesclave.Controls.Add(this.Txt_estado);
            this.Gpb_datospersonalesclave.Controls.Add(this.txt_estadousuario);
            this.Gpb_datospersonalesclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonalesclave.Location = new System.Drawing.Point(1017, 223);
            this.Gpb_datospersonalesclave.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonalesclave.Name = "Gpb_datospersonalesclave";
            this.Gpb_datospersonalesclave.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonalesclave.Size = new System.Drawing.Size(476, 124);
            this.Gpb_datospersonalesclave.TabIndex = 270;
            this.Gpb_datospersonalesclave.TabStop = false;
            this.Gpb_datospersonalesclave.Text = "Datos Personales";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(414, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 30);
            this.textBox1.TabIndex = 261;
            this.textBox1.Tag = "3";
            // 
            // txt_preguntausuario
            // 
            this.txt_preguntausuario.AutoSize = true;
            this.txt_preguntausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preguntausuario.Location = new System.Drawing.Point(32, 137);
            this.txt_preguntausuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_preguntausuario.Name = "txt_preguntausuario";
            this.txt_preguntausuario.Size = new System.Drawing.Size(0, 25);
            this.txt_preguntausuario.TabIndex = 260;
            // 
            // Txt_respuestausuario
            // 
            this.Txt_respuestausuario.AutoSize = true;
            this.Txt_respuestausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_respuestausuario.Location = new System.Drawing.Point(32, 189);
            this.Txt_respuestausuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_respuestausuario.Name = "Txt_respuestausuario";
            this.Txt_respuestausuario.Size = new System.Drawing.Size(0, 25);
            this.Txt_respuestausuario.TabIndex = 228;
            // 
            // Txt_estado
            // 
            this.Txt_estado.AutoSize = true;
            this.Txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(10, 39);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(196, 25);
            this.Txt_estado.TabIndex = 205;
            this.Txt_estado.Text = "Fecha de Nacimiento";
            // 
            // txt_estadousuario
            // 
            this.txt_estadousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadousuario.Location = new System.Drawing.Point(436, 135);
            this.txt_estadousuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estadousuario.Name = "txt_estadousuario";
            this.txt_estadousuario.Size = new System.Drawing.Size(16, 30);
            this.txt_estadousuario.TabIndex = 227;
            this.txt_estadousuario.Tag = "3";
            // 
            // Gpb_datospersonales
            // 
            this.Gpb_datospersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datospersonales.Controls.Add(this.Txt_direccion);
            this.Gpb_datospersonales.Controls.Add(this.Txt_correousuario);
            this.Gpb_datospersonales.Controls.Add(this.Txt_dpi);
            this.Gpb_datospersonales.Controls.Add(this.Txt_telefono);
            this.Gpb_datospersonales.Controls.Add(this.Txt_nombreusuario);
            this.Gpb_datospersonales.Controls.Add(this.Txt_apellidousuario);
            this.Gpb_datospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonales.Location = new System.Drawing.Point(538, 223);
            this.Gpb_datospersonales.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Name = "Gpb_datospersonales";
            this.Gpb_datospersonales.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Size = new System.Drawing.Size(457, 231);
            this.Gpb_datospersonales.TabIndex = 269;
            this.Gpb_datospersonales.TabStop = false;
            this.Gpb_datospersonales.Text = "Datos Personales";
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(125, 149);
            this.Txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(308, 30);
            this.Txt_direccion.TabIndex = 229;
            this.Txt_direccion.Tag = "4";
            // 
            // Txt_correousuario
            // 
            this.Txt_correousuario.AutoSize = true;
            this.Txt_correousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correousuario.Location = new System.Drawing.Point(8, 149);
            this.Txt_correousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_correousuario.Name = "Txt_correousuario";
            this.Txt_correousuario.Size = new System.Drawing.Size(98, 25);
            this.Txt_correousuario.TabIndex = 228;
            this.Txt_correousuario.Text = "Dirección ";
            // 
            // Txt_dpi
            // 
            this.Txt_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dpi.Location = new System.Drawing.Point(125, 94);
            this.Txt_dpi.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_dpi.Name = "Txt_dpi";
            this.Txt_dpi.Size = new System.Drawing.Size(308, 30);
            this.Txt_dpi.TabIndex = 226;
            this.Txt_dpi.Tag = "4";
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(206, 39);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(227, 30);
            this.Txt_telefono.TabIndex = 226;
            this.Txt_telefono.Tag = "1";
            // 
            // Txt_nombreusuario
            // 
            this.Txt_nombreusuario.AutoSize = true;
            this.Txt_nombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreusuario.Location = new System.Drawing.Point(8, 43);
            this.Txt_nombreusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nombreusuario.Name = "Txt_nombreusuario";
            this.Txt_nombreusuario.Size = new System.Drawing.Size(89, 25);
            this.Txt_nombreusuario.TabIndex = 205;
            this.Txt_nombreusuario.Text = "Teléfono";
            // 
            // Txt_apellidousuario
            // 
            this.Txt_apellidousuario.AutoSize = true;
            this.Txt_apellidousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidousuario.Location = new System.Drawing.Point(8, 97);
            this.Txt_apellidousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_apellidousuario.Name = "Txt_apellidousuario";
            this.Txt_apellidousuario.Size = new System.Drawing.Size(41, 25);
            this.Txt_apellidousuario.TabIndex = 193;
            this.Txt_apellidousuario.Text = "Dpi";
            // 
            // Gpb_datosusuario
            // 
            this.Gpb_datosusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datosusuario.Controls.Add(this.Txt_apellido);
            this.Gpb_datosusuario.Controls.Add(this.Txt_id);
            this.Gpb_datosusuario.Controls.Add(this.Txt_idusuario);
            this.Gpb_datosusuario.Controls.Add(this.Txt_usernameusuario);
            this.Gpb_datosusuario.Controls.Add(this.Txt_nombre);
            this.Gpb_datosusuario.Controls.Add(this.Txt_contraseniausuario);
            this.Gpb_datosusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosusuario.Location = new System.Drawing.Point(58, 223);
            this.Gpb_datosusuario.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Name = "Gpb_datosusuario";
            this.Gpb_datosusuario.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Size = new System.Drawing.Size(455, 231);
            this.Gpb_datosusuario.TabIndex = 268;
            this.Gpb_datosusuario.TabStop = false;
            this.Gpb_datosusuario.Text = "Datos Usuario";
            // 
            // Txt_id
            // 
            this.Txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(146, 44);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(227, 30);
            this.Txt_id.TabIndex = 254;
            this.Txt_id.Tag = "1";
            // 
            // Txt_idusuario
            // 
            this.Txt_idusuario.AutoSize = true;
            this.Txt_idusuario.Location = new System.Drawing.Point(14, 42);
            this.Txt_idusuario.Name = "Txt_idusuario";
            this.Txt_idusuario.Size = new System.Drawing.Size(31, 25);
            this.Txt_idusuario.TabIndex = 228;
            this.Txt_idusuario.Text = "ID";
            // 
            // Txt_usernameusuario
            // 
            this.Txt_usernameusuario.AutoSize = true;
            this.Txt_usernameusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usernameusuario.Location = new System.Drawing.Point(14, 93);
            this.Txt_usernameusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_usernameusuario.Name = "Txt_usernameusuario";
            this.Txt_usernameusuario.Size = new System.Drawing.Size(81, 25);
            this.Txt_usernameusuario.TabIndex = 205;
            this.Txt_usernameusuario.Text = "Nombre";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(146, 93);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(283, 30);
            this.Txt_nombre.TabIndex = 227;
            this.Txt_nombre.Tag = "3";
            // 
            // Txt_contraseniausuario
            // 
            this.Txt_contraseniausuario.AutoSize = true;
            this.Txt_contraseniausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseniausuario.Location = new System.Drawing.Point(8, 141);
            this.Txt_contraseniausuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_contraseniausuario.Name = "Txt_contraseniausuario";
            this.Txt_contraseniausuario.Size = new System.Drawing.Size(82, 25);
            this.Txt_contraseniausuario.TabIndex = 193;
            this.Txt_contraseniausuario.Text = "Apellido";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Image = global::Capa_Vista_Seguridad.Properties.Resources.ayuda11;
            this.Btn_ayuda.Location = new System.Drawing.Point(1425, 43);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(69, 57);
            this.Btn_ayuda.TabIndex = 267;
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Image = global::Capa_Vista_Seguridad.Properties.Resources.agregar11;
            this.Btn_nuevo.Location = new System.Drawing.Point(1017, 128);
            this.Btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(69, 57);
            this.Btn_nuevo.TabIndex = 266;
            this.Btn_nuevo.Tag = "0";
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Image = global::Capa_Vista_Seguridad.Properties.Resources.editar11;
            this.Btn_modificar.Location = new System.Drawing.Point(1155, 128);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(69, 57);
            this.Btn_modificar.TabIndex = 265;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Gpb_modificar
            // 
            this.Gpb_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_modificar.Controls.Add(this.Txt_buscar);
            this.Gpb_modificar.Controls.Add(this.Txt_buscar_id);
            this.Gpb_modificar.Controls.Add(this.Btn_buscar);
            this.Gpb_modificar.Location = new System.Drawing.Point(58, 113);
            this.Gpb_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_modificar.Name = "Gpb_modificar";
            this.Gpb_modificar.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_modificar.Size = new System.Drawing.Size(937, 79);
            this.Gpb_modificar.TabIndex = 264;
            this.Gpb_modificar.TabStop = false;
            this.Gpb_modificar.Text = "Modificar";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(166, 29);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(686, 30);
            this.Txt_buscar.TabIndex = 240;
            // 
            // Txt_buscar_id
            // 
            this.Txt_buscar_id.AutoSize = true;
            this.Txt_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar_id.Location = new System.Drawing.Point(42, 33);
            this.Txt_buscar_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_buscar_id.Name = "Txt_buscar_id";
            this.Txt_buscar_id.Size = new System.Drawing.Size(94, 25);
            this.Txt_buscar_id.TabIndex = 238;
            this.Txt_buscar_id.Text = "Buscar Id";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Image = global::Capa_Vista_Seguridad.Properties.Resources.buscar11;
            this.Btn_buscar.Location = new System.Drawing.Point(860, 14);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(69, 57);
            this.Btn_buscar.TabIndex = 237;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Image = global::Capa_Vista_Seguridad.Properties.Resources.borrar11;
            this.Btn_eliminar.Location = new System.Drawing.Point(1224, 128);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(69, 57);
            this.Btn_eliminar.TabIndex = 263;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.salir11;
            this.Btn_salir.Location = new System.Drawing.Point(1356, 43);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(69, 57);
            this.Btn_salir.TabIndex = 262;
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_Seguridad.Properties.Resources.guardar12;
            this.Btn_guardar.Location = new System.Drawing.Point(1086, 128);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 261;
            this.Btn_guardar.Tag = "5";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.Location = new System.Drawing.Point(146, 146);
            this.Txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(283, 30);
            this.Txt_apellido.TabIndex = 230;
            this.Txt_apellido.Tag = "4";
            // 
            // Txt_fechanacimiento
            // 
            this.Txt_fechanacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fechanacimiento.Location = new System.Drawing.Point(15, 68);
            this.Txt_fechanacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_fechanacimiento.Name = "Txt_fechanacimiento";
            this.Txt_fechanacimiento.Size = new System.Drawing.Size(227, 30);
            this.Txt_fechanacimiento.TabIndex = 230;
            this.Txt_fechanacimiento.Tag = "1";
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1694, 785);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.Gpb_datospersonalesclave);
            this.Controls.Add(this.Gpb_datospersonales);
            this.Controls.Add(this.Gpb_datosusuario);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Gpb_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_guardar);
            this.Name = "frm_empleados";
            this.Text = "frm_empleados";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.Gpb_datospersonalesclave.ResumeLayout(false);
            this.Gpb_datospersonalesclave.PerformLayout();
            this.Gpb_datospersonales.ResumeLayout(false);
            this.Gpb_datospersonales.PerformLayout();
            this.Gpb_datosusuario.ResumeLayout(false);
            this.Gpb_datosusuario.PerformLayout();
            this.Gpb_modificar.ResumeLayout(false);
            this.Gpb_modificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.GroupBox Gpb_datospersonalesclave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_preguntausuario;
        private System.Windows.Forms.Label Txt_respuestausuario;
        private System.Windows.Forms.Label Txt_estado;
        private System.Windows.Forms.TextBox txt_estadousuario;
        private System.Windows.Forms.GroupBox Gpb_datospersonales;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Label Txt_correousuario;
        private System.Windows.Forms.TextBox Txt_dpi;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.Label Txt_nombreusuario;
        private System.Windows.Forms.Label Txt_apellidousuario;
        private System.Windows.Forms.GroupBox Gpb_datosusuario;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label Txt_idusuario;
        private System.Windows.Forms.Label Txt_usernameusuario;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Txt_contraseniausuario;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.GroupBox Gpb_modificar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Txt_buscar_id;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox Txt_fechanacimiento;
    }
}