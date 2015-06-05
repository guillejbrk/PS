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
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.cboDia = new MetroFramework.Controls.MetroComboBox();
            this.cboTerapeuta = new MetroFramework.Controls.MetroComboBox();
            this.cboTratamiento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lstDias = new System.Windows.Forms.ListBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cboPaciente = new MetroFramework.Controls.MetroComboBox();
            this.panelCanelado = new MetroFramework.Controls.MetroPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.rbnCancelado = new System.Windows.Forms.RadioButton();
            this.rbnAlta = new System.Windows.Forms.RadioButton();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgTurnosAlta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelCanelado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnosAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(288, 285);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbtInactivo);
            this.panel1.Controls.Add(this.cboDia);
            this.panel1.Controls.Add(this.cboTerapeuta);
            this.panel1.Controls.Add(this.cboTratamiento);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.cboPaciente);
            this.panel1.Controls.Add(this.panelCanelado);
            this.panel1.Controls.Add(this.rbnCancelado);
            this.panel1.Controls.Add(this.rbnAlta);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.btnCrearPaciente);
            this.panel1.Location = new System.Drawing.Point(10, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 480);
            this.panel1.TabIndex = 9;
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(194, 289);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 33;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.ItemHeight = 23;
            this.cboDia.Location = new System.Drawing.Point(112, 100);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(121, 29);
            this.cboDia.TabIndex = 32;
            this.cboDia.UseSelectable = true;
            this.cboDia.SelectedIndexChanged += new System.EventHandler(this.cboDia_SelectedIndexChanged);
            // 
            // cboTerapeuta
            // 
            this.cboTerapeuta.FormattingEnabled = true;
            this.cboTerapeuta.ItemHeight = 23;
            this.cboTerapeuta.Location = new System.Drawing.Point(112, 66);
            this.cboTerapeuta.Name = "cboTerapeuta";
            this.cboTerapeuta.Size = new System.Drawing.Size(144, 29);
            this.cboTerapeuta.TabIndex = 31;
            this.cboTerapeuta.UseSelectable = true;
            this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.cboTerapeuta_SelectedIndexChanged_1);
            // 
            // cboTratamiento
            // 
            this.cboTratamiento.FormattingEnabled = true;
            this.cboTratamiento.ItemHeight = 23;
            this.cboTratamiento.Location = new System.Drawing.Point(112, 33);
            this.cboTratamiento.Name = "cboTratamiento";
            this.cboTratamiento.Size = new System.Drawing.Size(144, 29);
            this.cboTratamiento.TabIndex = 30;
            this.cboTratamiento.UseSelectable = true;
            this.cboTratamiento.SelectedIndexChanged += new System.EventHandler(this.cboTratamiento_SelectedIndexChanged);
            this.cboTratamiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboTratamiento_MouseClick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 289);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Estado";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lstDias);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 135);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(337, 130);
            this.metroPanel1.TabIndex = 28;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lstDias
            // 
            this.lstDias.FormattingEnabled = true;
            this.lstDias.Location = new System.Drawing.Point(63, 24);
            this.lstDias.Name = "lstDias";
            this.lstDias.Size = new System.Drawing.Size(201, 95);
            this.lstDias.TabIndex = 29;
            this.lstDias.SelectedIndexChanged += new System.EventHandler(this.lstDias_SelectedIndexChanged_1);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(83, 2);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(145, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Lista de Dias y Horarios";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Dia:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Terapeuta:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Tratamiento:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Paciente:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(262, 33);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Cargar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.ItemHeight = 23;
            this.cboPaciente.Location = new System.Drawing.Point(112, 2);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(144, 29);
            this.cboPaciente.TabIndex = 21;
            this.cboPaciente.UseSelectable = true;
            this.cboPaciente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboPaciente_MouseClick);
            // 
            // panelCanelado
            // 
            this.panelCanelado.Controls.Add(this.label8);
            this.panelCanelado.Controls.Add(this.txtMotivo);
            this.panelCanelado.HorizontalScrollbarBarColor = true;
            this.panelCanelado.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCanelado.HorizontalScrollbarSize = 10;
            this.panelCanelado.Location = new System.Drawing.Point(3, 311);
            this.panelCanelado.Name = "panelCanelado";
            this.panelCanelado.Size = new System.Drawing.Size(360, 132);
            this.panelCanelado.TabIndex = 20;
            this.panelCanelado.VerticalScrollbarBarColor = true;
            this.panelCanelado.VerticalScrollbarHighlightOnWheel = false;
            this.panelCanelado.VerticalScrollbarSize = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Motivo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(77, 18);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(221, 80);
            this.txtMotivo.TabIndex = 16;
            // 
            // rbnCancelado
            // 
            this.rbnCancelado.AutoSize = true;
            this.rbnCancelado.Location = new System.Drawing.Point(112, 288);
            this.rbnCancelado.Name = "rbnCancelado";
            this.rbnCancelado.Size = new System.Drawing.Size(76, 17);
            this.rbnCancelado.TabIndex = 15;
            this.rbnCancelado.TabStop = true;
            this.rbnCancelado.Text = "Cancelado";
            this.rbnCancelado.UseVisualStyleBackColor = true;
            this.rbnCancelado.CheckedChanged += new System.EventHandler(this.rbnCancelado_CheckedChanged);
            // 
            // rbnAlta
            // 
            this.rbnAlta.AutoSize = true;
            this.rbnAlta.Location = new System.Drawing.Point(63, 289);
            this.rbnAlta.Name = "rbnAlta";
            this.rbnAlta.Size = new System.Drawing.Size(43, 17);
            this.rbnAlta.TabIndex = 14;
            this.rbnAlta.TabStop = true;
            this.rbnAlta.Text = "Alta";
            this.rbnAlta.UseVisualStyleBackColor = true;
            this.rbnAlta.CheckedChanged += new System.EventHandler(this.rbnAlta_CheckedChanged);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(262, 4);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(91, 23);
            this.btnCrearPaciente.TabIndex = 10;
            this.btnCrearPaciente.Text = "Crear";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgTurnosAlta);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(424, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 219);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::App1.Properties.Resources.blocnote;
            this.pictureBox1.Image = global::App1.Properties.Resources.blocnote;
            this.pictureBox1.Location = new System.Drawing.Point(445, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dtgTurnosAlta
            // 
            this.dtgTurnosAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTurnosAlta.Location = new System.Drawing.Point(30, 23);
            this.dtgTurnosAlta.Name = "dtgTurnosAlta";
            this.dtgTurnosAlta.Size = new System.Drawing.Size(431, 150);
            this.dtgTurnosAlta.TabIndex = 13;
            // 
            // frmCargarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnosAlta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.RadioButton rbnAlta;
        private System.Windows.Forms.RadioButton rbnCancelado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel panelCanelado;
        private MetroFramework.Controls.MetroComboBox cboPaciente;
        private MetroFramework.Controls.MetroButton metroButton1;
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
        private System.Windows.Forms.DataGridView dtgTurnosAlta;
    }
}