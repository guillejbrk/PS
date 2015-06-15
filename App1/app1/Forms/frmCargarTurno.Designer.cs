namespace App1.Forms
{
    partial class frmCargarTurno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboDia = new MetroFramework.Controls.MetroComboBox();
            this.cboTerapeuta = new MetroFramework.Controls.MetroComboBox();
            this.cboTratamiento = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.rbnAlta = new System.Windows.Forms.RadioButton();
            this.rbnCancelado = new System.Windows.Forms.RadioButton();
            this.lstDias = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboPaciente = new MetroFramework.Controls.MetroComboBox();
            this.panelCanelado = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvTurnos = new MetroFramework.Controls.MetroGrid();
            this.btnImprimirTurno = new System.Windows.Forms.Button();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelCanelado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.cboDia);
            this.panel1.Controls.Add(this.cboTerapeuta);
            this.panel1.Controls.Add(this.cboTratamiento);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.cboPaciente);
            this.panel1.Controls.Add(this.panelCanelado);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.btnCrearPaciente);
            this.panel1.Location = new System.Drawing.Point(10, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 431);
            this.panel1.TabIndex = 9;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::App1.Properties.Resources._1433804360_ic_expand_more_48px;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(303, 46);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 23);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.ItemHeight = 23;
            this.cboDia.Location = new System.Drawing.Point(94, 104);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(156, 29);
            this.cboDia.TabIndex = 32;
            this.cboDia.UseSelectable = true;
            this.cboDia.SelectedIndexChanged += new System.EventHandler(this.cboDia_SelectedIndexChanged);
            // 
            // cboTerapeuta
            // 
            this.cboTerapeuta.FormattingEnabled = true;
            this.cboTerapeuta.ItemHeight = 23;
            this.cboTerapeuta.Location = new System.Drawing.Point(94, 71);
            this.cboTerapeuta.Name = "cboTerapeuta";
            this.cboTerapeuta.Size = new System.Drawing.Size(169, 29);
            this.cboTerapeuta.TabIndex = 31;
            this.cboTerapeuta.UseSelectable = true;
            this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.cboTerapeuta_SelectedIndexChanged_1);
            // 
            // cboTratamiento
            // 
            this.cboTratamiento.FormattingEnabled = true;
            this.cboTratamiento.ItemHeight = 23;
            this.cboTratamiento.Location = new System.Drawing.Point(94, 40);
            this.cboTratamiento.Name = "cboTratamiento";
            this.cboTratamiento.Size = new System.Drawing.Size(198, 29);
            this.cboTratamiento.TabIndex = 30;
            this.cboTratamiento.UseSelectable = true;
            this.cboTratamiento.SelectedIndexChanged += new System.EventHandler(this.cboTratamiento_SelectedIndexChanged);
            this.cboTratamiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboTratamiento_MouseClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.rbtInactivo);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.rbnAlta);
            this.metroPanel1.Controls.Add(this.rbnCancelado);
            this.metroPanel1.Controls.Add(this.lstDias);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 137);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(385, 145);
            this.metroPanel1.TabIndex = 28;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(229, 123);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 33;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(48, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Estado";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(105, 2);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(145, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Lista de Dias y Horarios";
            // 
            // rbnAlta
            // 
            this.rbnAlta.AutoSize = true;
            this.rbnAlta.Location = new System.Drawing.Point(98, 123);
            this.rbnAlta.Name = "rbnAlta";
            this.rbnAlta.Size = new System.Drawing.Size(43, 17);
            this.rbnAlta.TabIndex = 14;
            this.rbnAlta.TabStop = true;
            this.rbnAlta.Text = "Alta";
            this.rbnAlta.UseVisualStyleBackColor = true;
            this.rbnAlta.CheckedChanged += new System.EventHandler(this.rbnAlta_CheckedChanged);
            // 
            // rbnCancelado
            // 
            this.rbnCancelado.AutoSize = true;
            this.rbnCancelado.Location = new System.Drawing.Point(147, 123);
            this.rbnCancelado.Name = "rbnCancelado";
            this.rbnCancelado.Size = new System.Drawing.Size(76, 17);
            this.rbnCancelado.TabIndex = 15;
            this.rbnCancelado.TabStop = true;
            this.rbnCancelado.Text = "Cancelado";
            this.rbnCancelado.UseVisualStyleBackColor = true;
            this.rbnCancelado.CheckedChanged += new System.EventHandler(this.rbnCancelado_CheckedChanged);
            // 
            // lstDias
            // 
            this.lstDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstDias.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDias.ForeColor = System.Drawing.Color.Black;
            this.lstDias.FormattingEnabled = true;
            this.lstDias.ItemHeight = 18;
            this.lstDias.Location = new System.Drawing.Point(81, 21);
            this.lstDias.Name = "lstDias";
            this.lstDias.Size = new System.Drawing.Size(201, 94);
            this.lstDias.TabIndex = 29;
            this.lstDias.SelectedIndexChanged += new System.EventHandler(this.lstDias_SelectedIndexChanged_1);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(55, 113);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Dia:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Terapeuta:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Tratamiento:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Paciente:";
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.ItemHeight = 23;
            this.cboPaciente.Location = new System.Drawing.Point(94, 9);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(197, 29);
            this.cboPaciente.TabIndex = 21;
            this.cboPaciente.UseSelectable = true;
            this.cboPaciente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboPaciente_MouseClick);
            // 
            // panelCanelado
            // 
            this.panelCanelado.Controls.Add(this.metroLabel8);
            this.panelCanelado.Controls.Add(this.txtMotivo);
            this.panelCanelado.HorizontalScrollbarBarColor = true;
            this.panelCanelado.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCanelado.HorizontalScrollbarSize = 10;
            this.panelCanelado.Location = new System.Drawing.Point(3, 319);
            this.panelCanelado.Name = "panelCanelado";
            this.panelCanelado.Size = new System.Drawing.Size(360, 96);
            this.panelCanelado.TabIndex = 20;
            this.panelCanelado.VerticalScrollbarBarColor = true;
            this.panelCanelado.VerticalScrollbarHighlightOnWheel = false;
            this.panelCanelado.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(155, 2);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Motivo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(77, 24);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(221, 52);
            this.txtMotivo.TabIndex = 16;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Image = global::App1.Properties.Resources._1433804248_ic_add_48px;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(303, 288);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(83, 25);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Alta";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPaciente.Image = global::App1.Properties.Resources._1433804360_ic_expand_more_48px;
            this.btnCrearPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPaciente.Location = new System.Drawing.Point(303, 12);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(73, 23);
            this.btnCrearPaciente.TabIndex = 10;
            this.btnCrearPaciente.Text = "Nuevo";
            this.btnCrearPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtgvTurnos);
            this.panel2.Controls.Add(this.btnImprimirTurno);
            this.panel2.Controls.Add(this.metroLabel7);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(404, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 210);
            this.panel2.TabIndex = 11;
            // 
            // dtgvTurnos
            // 
            this.dtgvTurnos.AllowUserToResizeRows = false;
            this.dtgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvTurnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvTurnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTurnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTurnos.EnableHeadersVisualStyles = false;
            this.dtgvTurnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvTurnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvTurnos.Location = new System.Drawing.Point(20, 43);
            this.dtgvTurnos.Name = "dtgvTurnos";
            this.dtgvTurnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTurnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTurnos.Size = new System.Drawing.Size(407, 131);
            this.dtgvTurnos.Style = MetroFramework.MetroColorStyle.Orange;
            this.dtgvTurnos.TabIndex = 15;
            // 
            // btnImprimirTurno
            // 
            this.btnImprimirTurno.Image = global::App1.Properties.Resources._1433804429_ic_local_print_shop_48px;
            this.btnImprimirTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirTurno.Location = new System.Drawing.Point(343, 184);
            this.btnImprimirTurno.Name = "btnImprimirTurno";
            this.btnImprimirTurno.Size = new System.Drawing.Size(116, 23);
            this.btnImprimirTurno.TabIndex = 16;
            this.btnImprimirTurno.Text = "Imprimir Turno";
            this.btnImprimirTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirTurno.UseVisualStyleBackColor = true;
            this.btnImprimirTurno.Click += new System.EventHandler(this.btnImprimirTurno_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(136, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Turnos Por Terapeutas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Image = global::App1.Properties.Resources._1433804360_ic_expand_more_48px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(3, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::App1.Properties.Resources._1433804497_ic_close_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(787, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::App1.Properties.Resources.blocnote;
            this.pictureBox1.Image = global::App1.Properties.Resources.blocnote;
            this.pictureBox1.Location = new System.Drawing.Point(537, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmCargarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCargarTurno";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Nuevo Turno";
            this.Load += new System.EventHandler(this.frmCargarTurno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panelCanelado.ResumeLayout(false);
            this.panelCanelado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.RadioButton rbnAlta;
        private System.Windows.Forms.RadioButton rbnCancelado;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel panelCanelado;
        private MetroFramework.Controls.MetroComboBox cboPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboDia;
        private MetroFramework.Controls.MetroComboBox cboTerapeuta;
        private MetroFramework.Controls.MetroComboBox cboTratamiento;
        private System.Windows.Forms.ListBox lstDias;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dtgvTurnos;
        private System.Windows.Forms.Button btnImprimirTurno;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Button btnNuevo;
    }
}