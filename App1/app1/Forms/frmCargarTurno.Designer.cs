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
            this.label2 = new System.Windows.Forms.Label();
            this.cboTratamiento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cboPaciente = new MetroFramework.Controls.MetroComboBox();
            this.panelCanelado = new MetroFramework.Controls.MetroPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.rbnCancelado = new System.Windows.Forms.RadioButton();
            this.rbnAlta = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTerapeuta = new System.Windows.Forms.ComboBox();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelCanelado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia de terapeuta";
            // 
            // cboTratamiento
            // 
            this.cboTratamiento.FormattingEnabled = true;
            this.cboTratamiento.Location = new System.Drawing.Point(112, 34);
            this.cboTratamiento.Name = "cboTratamiento";
            this.cboTratamiento.Size = new System.Drawing.Size(121, 21);
            this.cboTratamiento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paciente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tratamiento";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(255, 240);
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
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.cboPaciente);
            this.panel1.Controls.Add(this.panelCanelado);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.cboDia);
            this.panel1.Controls.Add(this.rbnCancelado);
            this.panel1.Controls.Add(this.rbnAlta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.cboTerapeuta);
            this.panel1.Controls.Add(this.btnCrearPaciente);
            this.panel1.Controls.Add(this.cboTratamiento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 457);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(239, 33);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Cargar";
            this.metroButton1.UseSelectable = true;
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.ItemHeight = 23;
            this.cboPaciente.Location = new System.Drawing.Point(112, 2);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(121, 29);
            this.cboPaciente.TabIndex = 21;
            this.cboPaciente.UseSelectable = true;
            this.cboPaciente.SelectedIndexChanged += new System.EventHandler(this.cboPaciente_SelectedIndexChanged);
            this.cboPaciente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboPaciente_MouseClick);
            // 
            // panelCanelado
            // 
            this.panelCanelado.Controls.Add(this.label8);
            this.panelCanelado.Controls.Add(this.txtMotivo);
            this.panelCanelado.HorizontalScrollbarBarColor = true;
            this.panelCanelado.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCanelado.HorizontalScrollbarSize = 10;
            this.panelCanelado.Location = new System.Drawing.Point(3, 281);
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
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(137, 127);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(120, 94);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "LIsta de Dias y Horarios Disponibles";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(16, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(101, 97);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(112, 83);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(121, 21);
            this.cboDia.TabIndex = 12;
            this.cboDia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbnCancelado
            // 
            this.rbnCancelado.AutoSize = true;
            this.rbnCancelado.Location = new System.Drawing.Point(112, 240);
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
            this.rbnAlta.Location = new System.Drawing.Point(56, 240);
            this.rbnAlta.Name = "rbnAlta";
            this.rbnAlta.Size = new System.Drawing.Size(43, 17);
            this.rbnAlta.TabIndex = 14;
            this.rbnAlta.TabStop = true;
            this.rbnAlta.Text = "Alta";
            this.rbnAlta.UseVisualStyleBackColor = true;
            this.rbnAlta.CheckedChanged += new System.EventHandler(this.rbnAlta_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Terapeuta";
            // 
            // cboTerapeuta
            // 
            this.cboTerapeuta.FormattingEnabled = true;
            this.cboTerapeuta.Location = new System.Drawing.Point(112, 56);
            this.cboTerapeuta.Name = "cboTerapeuta";
            this.cboTerapeuta.Size = new System.Drawing.Size(121, 21);
            this.cboTerapeuta.TabIndex = 11;
            this.cboTerapeuta.SelectedIndexChanged += new System.EventHandler(this.cboTerapeuta_SelectedIndexChanged);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(239, 4);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(91, 23);
            this.btnCrearPaciente.TabIndex = 10;
            this.btnCrearPaciente.Text = "Crear";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(424, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 219);
            this.panel2.TabIndex = 11;
            // 
            // frmCargarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCargarTurno";
            this.Text = "Nuevo Turno";
            this.Load += new System.EventHandler(this.frmCargarTurno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCanelado.ResumeLayout(false);
            this.panelCanelado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTratamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.RadioButton rbnAlta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTerapeuta;
        private System.Windows.Forms.RadioButton rbnCancelado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel panelCanelado;
        private MetroFramework.Controls.MetroComboBox cboPaciente;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}