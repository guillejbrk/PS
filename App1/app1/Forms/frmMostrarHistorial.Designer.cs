namespace App1.Forms
{
    partial class frmMostrarHistorial
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
            this.cboPaciente = new MetroFramework.Controls.MetroComboBox();
            this.cboFecha = new MetroFramework.Controls.MetroComboBox();
            this.txtObservacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.ItemHeight = 23;
            this.cboPaciente.Location = new System.Drawing.Point(71, 12);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(169, 29);
            this.cboPaciente.TabIndex = 0;
            this.cboPaciente.UseSelectable = true;
            this.cboPaciente.SelectedIndexChanged += new System.EventHandler(this.cboPaciente_SelectedIndexChanged);
            // 
            // cboFecha
            // 
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.ItemHeight = 23;
            this.cboFecha.Location = new System.Drawing.Point(301, 12);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(169, 29);
            this.cboFecha.TabIndex = 1;
            this.cboFecha.UseSelectable = true;
            this.cboFecha.SelectedIndexChanged += new System.EventHandler(this.cboFecha_SelectedIndexChanged);
            // 
            // txtObservacion
            // 
            this.txtObservacion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtObservacion.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtObservacion.Lines = new string[0];
            this.txtObservacion.Location = new System.Drawing.Point(23, 129);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ReadOnly = true;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.Size = new System.Drawing.Size(320, 169);
            this.txtObservacion.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtObservacion.TabIndex = 2;
            this.txtObservacion.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Paciente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(252, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.book3;
            this.pictureBox1.Location = new System.Drawing.Point(359, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(521, 285);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.cboFecha);
            this.panel1.Controls.Add(this.cboPaciente);
            this.panel1.Location = new System.Drawing.Point(13, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 58);
            this.panel1.TabIndex = 7;
            // 
            // frmMostrarHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMostrarHistorial";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Ver Historia";
            this.Load += new System.EventHandler(this.frmMostrarHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboPaciente;
        private MetroFramework.Controls.MetroComboBox cboFecha;
        private MetroFramework.Controls.MetroTextBox txtObservacion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
    }
}