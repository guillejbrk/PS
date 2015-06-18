namespace App1.Forms
{
    partial class frmTerapeuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sdf = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cboEspecialidad = new MetroFramework.Controls.MetroComboBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.cboJornada = new MetroFramework.Controls.MetroComboBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPass2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevosTurnos = new System.Windows.Forms.Button();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModLab = new MetroFramework.Controls.MetroButton();
            this.btnCargarL = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chbMartes1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chbJueves = new MetroFramework.Controls.MetroCheckBox();
            this.chbDomingo = new MetroFramework.Controls.MetroCheckBox();
            this.chbMiercoles = new MetroFramework.Controls.MetroCheckBox();
            this.chbSabado = new MetroFramework.Controls.MetroCheckBox();
            this.chbViernes = new MetroFramework.Controls.MetroCheckBox();
            this.chbLunes = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnCargarNoLab = new System.Windows.Forms.Button();
            this.dtDiasNoLaborables = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.btnEliminarDiaNoLaboral = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.rbtAño = new MetroFramework.Controls.MetroRadioButton();
            this.rbtMes = new MetroFramework.Controls.MetroRadioButton();
            this.rbtSemana = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.lstNoLaboralesSemana = new System.Windows.Forms.ListBox();
            this.cboTerapeuta = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtgvTerapeuta = new MetroFramework.Controls.MetroGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.sdf.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel8.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTerapeuta)).BeginInit();
            this.SuspendLayout();
            // 
            // sdf
            // 
            this.sdf.Controls.Add(this.metroTabPage1);
            this.sdf.Controls.Add(this.metroTabPage2);
            this.sdf.Controls.Add(this.metroTabPage3);
            this.sdf.Location = new System.Drawing.Point(141, 52);
            this.sdf.Name = "sdf";
            this.sdf.SelectedIndex = 1;
            this.sdf.Size = new System.Drawing.Size(770, 507);
            this.sdf.Style = MetroFramework.MetroColorStyle.Orange;
            this.sdf.TabIndex = 16;
            this.sdf.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(762, 465);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cargar Terapeuta";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Visible = false;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.cboEspecialidad);
            this.metroPanel2.Controls.Add(this.txtUsuario);
            this.metroPanel2.Controls.Add(this.cboJornada);
            this.metroPanel2.Controls.Add(this.txtNombre);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.txtApellido);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.txtPass2);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.txtPass);
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(16, 31);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(312, 326);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::App1.Properties.Resources._1434259696_ic_refresh_48px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(122, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(66, 19);
            this.metroLabel10.TabIndex = 4;
            this.metroLabel10.Text = "Terapeuta";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.ItemHeight = 23;
            this.cboEspecialidad.Location = new System.Drawing.Point(153, 223);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(118, 29);
            this.cboEspecialidad.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboEspecialidad.TabIndex = 6;
            this.cboEspecialidad.UseSelectable = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(153, 94);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(118, 23);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.UseSelectable = true;
            // 
            // cboJornada
            // 
            this.cboJornada.FormattingEnabled = true;
            this.cboJornada.ItemHeight = 23;
            this.cboJornada.Location = new System.Drawing.Point(153, 188);
            this.cboJornada.Name = "cboJornada";
            this.cboJornada.Size = new System.Drawing.Size(118, 29);
            this.cboJornada.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboJornada.TabIndex = 5;
            this.cboJornada.UseSelectable = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(153, 60);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(118, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(66, 233);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(81, 19);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "Especialidad";
            // 
            // txtApellido
            // 
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(153, 28);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(118, 23);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(88, 198);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Jornada:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 159);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(124, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Repetir Contraseña:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(69, 126);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Contraseña:";
            // 
            // txtPass2
            // 
            this.txtPass2.Lines = new string[0];
            this.txtPass2.Location = new System.Drawing.Point(153, 159);
            this.txtPass2.MaxLength = 32767;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '●';
            this.txtPass2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass2.SelectedText = "";
            this.txtPass2.Size = new System.Drawing.Size(118, 23);
            this.txtPass2.TabIndex = 4;
            this.txtPass2.UseSelectable = true;
            this.txtPass2.UseSystemPasswordChar = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(91, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Usuario:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(85, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Nombre:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(86, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Apellido:";
            // 
            // txtPass
            // 
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(153, 126);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(118, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::App1.Properties.Resources._1433804248_ic_add_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(213, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cargar ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.Controls.Add(this.btnNuevosTurnos);
            this.metroTabPage2.Controls.Add(this.metroPanel8);
            this.metroTabPage2.Controls.Add(this.metroPanel7);
            this.metroTabPage2.Controls.Add(this.cboTerapeuta);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(762, 465);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Administracion Agenda";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::App1.Properties.Resources.address_book;
            this.pictureBox1.Location = new System.Drawing.Point(429, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnNuevosTurnos
            // 
            this.btnNuevosTurnos.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevosTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevosTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevosTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevosTurnos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevosTurnos.Image = global::App1.Properties.Resources._1433804360_ic_expand_more_48px;
            this.btnNuevosTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevosTurnos.Location = new System.Drawing.Point(598, 207);
            this.btnNuevosTurnos.Name = "btnNuevosTurnos";
            this.btnNuevosTurnos.Size = new System.Drawing.Size(143, 35);
            this.btnNuevosTurnos.TabIndex = 45;
            this.btnNuevosTurnos.Text = "Generar Turnos ";
            this.btnNuevosTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevosTurnos.UseVisualStyleBackColor = false;
            this.btnNuevosTurnos.Click += new System.EventHandler(this.btnNuevosTurnos_Click);
            // 
            // metroPanel8
            // 
            this.metroPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel8.Controls.Add(this.metroLabel12);
            this.metroPanel8.Controls.Add(this.metroLabel11);
            this.metroPanel8.Controls.Add(this.metroPanel4);
            this.metroPanel8.Controls.Add(this.metroPanel3);
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(3, 42);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(751, 159);
            this.metroPanel8.TabIndex = 44;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(384, 35);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(119, 19);
            this.metroLabel12.TabIndex = 39;
            this.metroLabel12.Text = "Dias No Laborales ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 14);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(177, 19);
            this.metroLabel11.TabIndex = 38;
            this.metroLabel11.Text = "Dias Laborales de la Semana";
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.btnEliminar);
            this.metroPanel4.Controls.Add(this.btnModLab);
            this.metroPanel4.Controls.Add(this.btnCargarL);
            this.metroPanel4.Controls.Add(this.metroPanel1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(6, 35);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(372, 111);
            this.metroPanel4.TabIndex = 37;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::App1.Properties.Resources._1433804497_ic_close_48px;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(286, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModLab
            // 
            this.btnModLab.Location = new System.Drawing.Point(286, 39);
            this.btnModLab.Name = "btnModLab";
            this.btnModLab.Size = new System.Drawing.Size(75, 23);
            this.btnModLab.TabIndex = 33;
            this.btnModLab.Text = "Editar";
            this.btnModLab.UseSelectable = true;
            this.btnModLab.Click += new System.EventHandler(this.btnModLab_Click);
            // 
            // btnCargarL
            // 
            this.btnCargarL.Location = new System.Drawing.Point(286, 10);
            this.btnCargarL.Name = "btnCargarL";
            this.btnCargarL.Size = new System.Drawing.Size(75, 23);
            this.btnCargarL.TabIndex = 32;
            this.btnCargarL.Text = "Cargar";
            this.btnCargarL.UseSelectable = true;
            this.btnCargarL.Click += new System.EventHandler(this.btnCargarL_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.chbMartes1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.chbJueves);
            this.metroPanel1.Controls.Add(this.chbDomingo);
            this.metroPanel1.Controls.Add(this.chbMiercoles);
            this.metroPanel1.Controls.Add(this.chbSabado);
            this.metroPanel1.Controls.Add(this.chbViernes);
            this.metroPanel1.Controls.Add(this.chbLunes);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 8);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(274, 92);
            this.metroPanel1.TabIndex = 27;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chbMartes1
            // 
            this.chbMartes1.AutoSize = true;
            this.chbMartes1.Location = new System.Drawing.Point(3, 25);
            this.chbMartes1.Name = "chbMartes1";
            this.chbMartes1.Size = new System.Drawing.Size(59, 15);
            this.chbMartes1.TabIndex = 25;
            this.chbMartes1.Text = "Martes";
            this.chbMartes1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(173, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Dias A trabajar";
            // 
            // chbJueves
            // 
            this.chbJueves.AutoSize = true;
            this.chbJueves.Location = new System.Drawing.Point(3, 68);
            this.chbJueves.Name = "chbJueves";
            this.chbJueves.Size = new System.Drawing.Size(57, 15);
            this.chbJueves.TabIndex = 23;
            this.chbJueves.Text = "Jueves";
            this.chbJueves.UseSelectable = true;
            // 
            // chbDomingo
            // 
            this.chbDomingo.AutoSize = true;
            this.chbDomingo.Location = new System.Drawing.Point(93, 48);
            this.chbDomingo.Name = "chbDomingo";
            this.chbDomingo.Size = new System.Drawing.Size(73, 15);
            this.chbDomingo.TabIndex = 22;
            this.chbDomingo.Text = "Domingo";
            this.chbDomingo.UseSelectable = true;
            // 
            // chbMiercoles
            // 
            this.chbMiercoles.AutoSize = true;
            this.chbMiercoles.Location = new System.Drawing.Point(3, 46);
            this.chbMiercoles.Name = "chbMiercoles";
            this.chbMiercoles.Size = new System.Drawing.Size(74, 15);
            this.chbMiercoles.TabIndex = 21;
            this.chbMiercoles.Text = "Miercoles";
            this.chbMiercoles.UseSelectable = true;
            // 
            // chbSabado
            // 
            this.chbSabado.AutoSize = true;
            this.chbSabado.Location = new System.Drawing.Point(93, 26);
            this.chbSabado.Name = "chbSabado";
            this.chbSabado.Size = new System.Drawing.Size(62, 15);
            this.chbSabado.TabIndex = 20;
            this.chbSabado.Text = "Sabado";
            this.chbSabado.UseSelectable = true;
            // 
            // chbViernes
            // 
            this.chbViernes.AutoSize = true;
            this.chbViernes.Location = new System.Drawing.Point(93, 5);
            this.chbViernes.Name = "chbViernes";
            this.chbViernes.Size = new System.Drawing.Size(64, 15);
            this.chbViernes.TabIndex = 18;
            this.chbViernes.Text = "Viernes ";
            this.chbViernes.UseSelectable = true;
            // 
            // chbLunes
            // 
            this.chbLunes.AutoSize = true;
            this.chbLunes.Location = new System.Drawing.Point(3, 5);
            this.chbLunes.Name = "chbLunes";
            this.chbLunes.Size = new System.Drawing.Size(57, 15);
            this.chbLunes.TabIndex = 17;
            this.chbLunes.Text = "Lunes ";
            this.chbLunes.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.btnCargarNoLab);
            this.metroPanel3.Controls.Add(this.dtDiasNoLaborables);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(384, 57);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(341, 53);
            this.metroPanel3.TabIndex = 35;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnCargarNoLab
            // 
            this.btnCargarNoLab.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCargarNoLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarNoLab.ForeColor = System.Drawing.Color.White;
            this.btnCargarNoLab.Image = global::App1.Properties.Resources._1433804248_ic_add_48px;
            this.btnCargarNoLab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarNoLab.Location = new System.Drawing.Point(261, 13);
            this.btnCargarNoLab.Name = "btnCargarNoLab";
            this.btnCargarNoLab.Size = new System.Drawing.Size(75, 23);
            this.btnCargarNoLab.TabIndex = 40;
            this.btnCargarNoLab.Text = "Cargar";
            this.btnCargarNoLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarNoLab.UseVisualStyleBackColor = false;
            this.btnCargarNoLab.Click += new System.EventHandler(this.btnCargarNoLab_Click);
            // 
            // dtDiasNoLaborables
            // 
            this.dtDiasNoLaborables.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiasNoLaborables.Location = new System.Drawing.Point(17, 10);
            this.dtDiasNoLaborables.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtDiasNoLaborables.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtDiasNoLaborables.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDiasNoLaborables.Name = "dtDiasNoLaborables";
            this.dtDiasNoLaborables.Size = new System.Drawing.Size(235, 29);
            this.dtDiasNoLaborables.TabIndex = 30;
            // 
            // metroPanel7
            // 
            this.metroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel7.Controls.Add(this.btnEliminarDiaNoLaboral);
            this.metroPanel7.Controls.Add(this.metroLabel1);
            this.metroPanel7.Controls.Add(this.metroPanel6);
            this.metroPanel7.Controls.Add(this.metroPanel5);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(3, 207);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(379, 234);
            this.metroPanel7.TabIndex = 43;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // btnEliminarDiaNoLaboral
            // 
            this.btnEliminarDiaNoLaboral.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarDiaNoLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDiaNoLaboral.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarDiaNoLaboral.Image = global::App1.Properties.Resources._1433804667_ic_delete_48px;
            this.btnEliminarDiaNoLaboral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDiaNoLaboral.Location = new System.Drawing.Point(292, 199);
            this.btnEliminarDiaNoLaboral.Name = "btnEliminarDiaNoLaboral";
            this.btnEliminarDiaNoLaboral.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarDiaNoLaboral.TabIndex = 43;
            this.btnEliminarDiaNoLaboral.Text = "Quitar";
            this.btnEliminarDiaNoLaboral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDiaNoLaboral.UseVisualStyleBackColor = false;
            this.btnEliminarDiaNoLaboral.Click += new System.EventHandler(this.btnEliminarDiaNoLaboral_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(195, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Dias No laborales del Terapeuta";
            // 
            // metroPanel6
            // 
            this.metroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel6.Controls.Add(this.rbtAño);
            this.metroPanel6.Controls.Add(this.rbtMes);
            this.metroPanel6.Controls.Add(this.rbtSemana);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(38, 36);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(244, 39);
            this.metroPanel6.TabIndex = 41;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // rbtAño
            // 
            this.rbtAño.AutoSize = true;
            this.rbtAño.Location = new System.Drawing.Point(192, 10);
            this.rbtAño.Name = "rbtAño";
            this.rbtAño.Size = new System.Drawing.Size(45, 15);
            this.rbtAño.TabIndex = 5;
            this.rbtAño.Text = "Año";
            this.rbtAño.UseSelectable = true;
            this.rbtAño.CheckedChanged += new System.EventHandler(this.rbtAño_CheckedChanged);
            // 
            // rbtMes
            // 
            this.rbtMes.AutoSize = true;
            this.rbtMes.Location = new System.Drawing.Point(98, 10);
            this.rbtMes.Name = "rbtMes";
            this.rbtMes.Size = new System.Drawing.Size(45, 15);
            this.rbtMes.TabIndex = 4;
            this.rbtMes.Text = "Mes";
            this.rbtMes.UseSelectable = true;
            this.rbtMes.CheckedChanged += new System.EventHandler(this.rbtMes_CheckedChanged);
            // 
            // rbtSemana
            // 
            this.rbtSemana.AutoSize = true;
            this.rbtSemana.Location = new System.Drawing.Point(3, 10);
            this.rbtSemana.Name = "rbtSemana";
            this.rbtSemana.Size = new System.Drawing.Size(65, 15);
            this.rbtSemana.TabIndex = 3;
            this.rbtSemana.Text = "Semana";
            this.rbtSemana.UseSelectable = true;
            this.rbtSemana.CheckedChanged += new System.EventHandler(this.rbtSemana_CheckedChanged);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.lstNoLaboralesSemana);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(38, 81);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(248, 140);
            this.metroPanel5.TabIndex = 36;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // lstNoLaboralesSemana
            // 
            this.lstNoLaboralesSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstNoLaboralesSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNoLaboralesSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNoLaboralesSemana.FormattingEnabled = true;
            this.lstNoLaboralesSemana.ItemHeight = 16;
            this.lstNoLaboralesSemana.Location = new System.Drawing.Point(43, 20);
            this.lstNoLaboralesSemana.Name = "lstNoLaboralesSemana";
            this.lstNoLaboralesSemana.Size = new System.Drawing.Size(147, 82);
            this.lstNoLaboralesSemana.TabIndex = 35;
            // 
            // cboTerapeuta
            // 
            this.cboTerapeuta.FormattingEnabled = true;
            this.cboTerapeuta.ItemHeight = 23;
            this.cboTerapeuta.Location = new System.Drawing.Point(3, 7);
            this.cboTerapeuta.Name = "cboTerapeuta";
            this.cboTerapeuta.Size = new System.Drawing.Size(163, 29);
            this.cboTerapeuta.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboTerapeuta.TabIndex = 31;
            this.cboTerapeuta.UseSelectable = true;
            this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.cboTerapeuta_SelectedIndexChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.panel1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(762, 465);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Administar Terapeuta";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.dtgvTerapeuta);
            this.panel1.Location = new System.Drawing.Point(35, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 207);
            this.panel1.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Image = global::App1.Properties.Resources._1433804663_ic_mode_edit_48px;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(366, 175);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtgvTerapeuta
            // 
            this.dtgvTerapeuta.AllowUserToResizeRows = false;
            this.dtgvTerapeuta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvTerapeuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTerapeuta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvTerapeuta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTerapeuta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTerapeuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTerapeuta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTerapeuta.EnableHeadersVisualStyles = false;
            this.dtgvTerapeuta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvTerapeuta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvTerapeuta.Location = new System.Drawing.Point(28, 19);
            this.dtgvTerapeuta.Name = "dtgvTerapeuta";
            this.dtgvTerapeuta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTerapeuta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTerapeuta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvTerapeuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTerapeuta.Size = new System.Drawing.Size(425, 150);
            this.dtgvTerapeuta.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(914, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 554);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.button2);
            this.Name = "frmTerapeuta";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Administrar Terapeuta";
            this.Load += new System.EventHandler(this.frmTerapeuta_Load);
            this.sdf.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTerapeuta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl sdf;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroDateTime dtDiasNoLaborables;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnCargarL;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox chbJueves;
        private MetroFramework.Controls.MetroCheckBox chbDomingo;
        private MetroFramework.Controls.MetroCheckBox chbMiercoles;
        private MetroFramework.Controls.MetroCheckBox chbSabado;
        private MetroFramework.Controls.MetroCheckBox chbViernes;
        private MetroFramework.Controls.MetroCheckBox chbLunes;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox cboTerapeuta;
        private MetroFramework.Controls.MetroButton btnModLab;
        private MetroFramework.Controls.MetroCheckBox chbMartes1;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.ListBox lstNoLaboralesSemana;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroRadioButton rbtAño;
        private MetroFramework.Controls.MetroRadioButton rbtMes;
        private MetroFramework.Controls.MetroRadioButton rbtSemana;
        private System.Windows.Forms.Button btnEliminarDiaNoLaboral;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private System.Windows.Forms.Button btnNuevosTurnos;
        private MetroFramework.Controls.MetroTextBox txtPass2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroComboBox cboEspecialidad;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroComboBox cboJornada;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroGrid dtgvTerapeuta;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.Button btnCargarNoLab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}