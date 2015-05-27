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
            this.sdf = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboJornada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
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
            this.btnCargarNL = new MetroFramework.Controls.MetroButton();
            this.dtDiasNoLaborables = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.rbtAño = new MetroFramework.Controls.MetroRadioButton();
            this.rbtMes = new MetroFramework.Controls.MetroRadioButton();
            this.rbtSemana = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnEliminarDiaNoLaboral = new System.Windows.Forms.Button();
            this.lstNoLaboralesSemana = new System.Windows.Forms.ListBox();
            this.cboTerapeuta = new MetroFramework.Controls.MetroComboBox();
            this.sdf.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdf
            // 
            this.sdf.Controls.Add(this.metroTabPage1);
            this.sdf.Controls.Add(this.metroTabPage2);
            this.sdf.Location = new System.Drawing.Point(141, 52);
            this.sdf.Name = "sdf";
            this.sdf.SelectedIndex = 1;
            this.sdf.Size = new System.Drawing.Size(994, 560);
            this.sdf.Style = MetroFramework.MetroColorStyle.Green;
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
            this.metroTabPage1.Size = new System.Drawing.Size(986, 518);
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
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.Controls.Add(this.button5);
            this.metroPanel2.Controls.Add(this.label9);
            this.metroPanel2.Controls.Add(this.cboEspecialidad);
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.Controls.Add(this.cboJornada);
            this.metroPanel2.Controls.Add(this.label10);
            this.metroPanel2.Controls.Add(this.txtContra);
            this.metroPanel2.Controls.Add(this.label11);
            this.metroPanel2.Controls.Add(this.txtUsu);
            this.metroPanel2.Controls.Add(this.label12);
            this.metroPanel2.Controls.Add(this.txtNom);
            this.metroPanel2.Controls.Add(this.label13);
            this.metroPanel2.Controls.Add(this.txtApe);
            this.metroPanel2.Controls.Add(this.label14);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(384, 322);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Terapeuta";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Especialidad";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(122, 168);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(100, 21);
            this.cboEspecialidad.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cargar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboJornada
            // 
            this.cboJornada.FormattingEnabled = true;
            this.cboJornada.Location = new System.Drawing.Point(122, 138);
            this.cboJornada.Name = "cboJornada";
            this.cboJornada.Size = new System.Drawing.Size(100, 21);
            this.cboJornada.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Jornada";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(122, 113);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Contraseña";
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(122, 87);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(100, 20);
            this.txtUsu.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Usuario";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(122, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Nombre";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(122, 31);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Apellido";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel8);
            this.metroTabPage2.Controls.Add(this.metroPanel7);
            this.metroTabPage2.Controls.Add(this.cboTerapeuta);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(986, 518);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Administracion Agenda";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel8
            // 
            this.metroPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel8.Controls.Add(this.metroPanel4);
            this.metroPanel8.Controls.Add(this.metroPanel3);
            this.metroPanel8.Controls.Add(this.label8);
            this.metroPanel8.Controls.Add(this.label1);
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
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // btnModLab
            // 
            this.btnModLab.Location = new System.Drawing.Point(286, 77);
            this.btnModLab.Name = "btnModLab";
            this.btnModLab.Size = new System.Drawing.Size(75, 23);
            this.btnModLab.TabIndex = 33;
            this.btnModLab.Text = "Editar";
            this.btnModLab.UseSelectable = true;
            this.btnModLab.Click += new System.EventHandler(this.btnModLab_Click);
            // 
            // btnCargarL
            // 
            this.btnCargarL.Location = new System.Drawing.Point(286, 38);
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
            this.metroLabel2.Location = new System.Drawing.Point(159, -1);
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
            this.metroPanel3.Controls.Add(this.btnCargarNL);
            this.metroPanel3.Controls.Add(this.dtDiasNoLaborables);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(389, 35);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(341, 53);
            this.metroPanel3.TabIndex = 35;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnCargarNL
            // 
            this.btnCargarNL.Location = new System.Drawing.Point(258, 11);
            this.btnCargarNL.Name = "btnCargarNL";
            this.btnCargarNL.Size = new System.Drawing.Size(75, 23);
            this.btnCargarNL.TabIndex = 33;
            this.btnCargarNL.Text = "Cargar";
            this.btnCargarNL.UseSelectable = true;
            this.btnCargarNL.Click += new System.EventHandler(this.btnCargarNL_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cargar  los  Dias No laborales ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dias laborales Semana";
            // 
            // metroPanel7
            // 
            this.metroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel7.Controls.Add(this.metroLabel1);
            this.metroPanel7.Controls.Add(this.metroPanel6);
            this.metroPanel7.Controls.Add(this.metroPanel5);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(177, 207);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(519, 269);
            this.metroPanel7.TabIndex = 43;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(123, 14);
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
            this.metroPanel6.Location = new System.Drawing.Point(16, 36);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(416, 39);
            this.metroPanel6.TabIndex = 41;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // rbtAño
            // 
            this.rbtAño.AutoSize = true;
            this.rbtAño.Location = new System.Drawing.Point(347, 15);
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
            this.rbtMes.Location = new System.Drawing.Point(174, 14);
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
            this.rbtSemana.Location = new System.Drawing.Point(20, 14);
            this.rbtSemana.Name = "rbtSemana";
            this.rbtSemana.Size = new System.Drawing.Size(65, 15);
            this.rbtSemana.TabIndex = 3;
            this.rbtSemana.Text = "Semana";
            this.rbtSemana.UseSelectable = true;
            this.rbtSemana.CheckedChanged += new System.EventHandler(this.rbtSemana_CheckedChanged);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.btnEliminarDiaNoLaboral);
            this.metroPanel5.Controls.Add(this.lstNoLaboralesSemana);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(38, 81);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(372, 164);
            this.metroPanel5.TabIndex = 36;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // btnEliminarDiaNoLaboral
            // 
            this.btnEliminarDiaNoLaboral.Location = new System.Drawing.Point(281, 138);
            this.btnEliminarDiaNoLaboral.Name = "btnEliminarDiaNoLaboral";
            this.btnEliminarDiaNoLaboral.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDiaNoLaboral.TabIndex = 43;
            this.btnEliminarDiaNoLaboral.Text = "Quitar";
            this.btnEliminarDiaNoLaboral.UseVisualStyleBackColor = true;
            this.btnEliminarDiaNoLaboral.Click += new System.EventHandler(this.btnEliminarDiaNoLaboral_Click);
            // 
            // lstNoLaboralesSemana
            // 
            this.lstNoLaboralesSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstNoLaboralesSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNoLaboralesSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNoLaboralesSemana.FormattingEnabled = true;
            this.lstNoLaboralesSemana.ItemHeight = 16;
            this.lstNoLaboralesSemana.Location = new System.Drawing.Point(105, 20);
            this.lstNoLaboralesSemana.Name = "lstNoLaboralesSemana";
            this.lstNoLaboralesSemana.Size = new System.Drawing.Size(147, 114);
            this.lstNoLaboralesSemana.TabIndex = 35;
            // 
            // cboTerapeuta
            // 
            this.cboTerapeuta.FormattingEnabled = true;
            this.cboTerapeuta.ItemHeight = 23;
            this.cboTerapeuta.Location = new System.Drawing.Point(3, 7);
            this.cboTerapeuta.Name = "cboTerapeuta";
            this.cboTerapeuta.Size = new System.Drawing.Size(163, 29);
            this.cboTerapeuta.TabIndex = 31;
            this.cboTerapeuta.UseSelectable = true;
            this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.cboTerapeuta_SelectedIndexChanged);
            // 
            // frmTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 581);
            this.Controls.Add(this.sdf);
            this.Name = "frmTerapeuta";
            this.Text = "Administrar Terapeuta";
            this.Load += new System.EventHandler(this.frmTerapeuta_Load);
            this.sdf.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl sdf;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroDateTime dtDiasNoLaborables;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton btnCargarNL;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboJornada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.Label label1;
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
    }
}