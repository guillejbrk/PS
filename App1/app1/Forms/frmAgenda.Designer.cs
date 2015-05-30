namespace App1.Forms
{
    partial class frmAgenda
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnModLab = new MetroFramework.Controls.MetroButton();
            this.btnCargarL = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chbMartes2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chbJueves4 = new MetroFramework.Controls.MetroCheckBox();
            this.chbDomingo7 = new MetroFramework.Controls.MetroCheckBox();
            this.chbMiercoles3 = new MetroFramework.Controls.MetroCheckBox();
            this.chbSabado6 = new MetroFramework.Controls.MetroCheckBox();
            this.chbViernes5 = new MetroFramework.Controls.MetroCheckBox();
            this.chbLunes1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnCargarNL = new MetroFramework.Controls.MetroButton();
            this.dtDiasNoLaborables = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.rbtAño = new MetroFramework.Controls.MetroRadioButton();
            this.rbtMes = new MetroFramework.Controls.MetroRadioButton();
            this.rbtSemana = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnEliminarDiaNoLaboral = new System.Windows.Forms.Button();
            this.lstNoLaboralesSemana = new System.Windows.Forms.ListBox();
            this.cboTerapeuta = new MetroFramework.Controls.MetroComboBox();
            this.cbmTera = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel8.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 0;
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
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
            this.metroPanel8.Location = new System.Drawing.Point(35, 63);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(751, 159);
            this.metroPanel8.TabIndex = 47;
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
            this.metroPanel4.Location = new System.Drawing.Point(3, 35);
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
            this.btnCargarL.Click += new System.EventHandler(this.btnCargarL_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.chbMartes2);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.chbJueves4);
            this.metroPanel1.Controls.Add(this.chbDomingo7);
            this.metroPanel1.Controls.Add(this.chbMiercoles3);
            this.metroPanel1.Controls.Add(this.chbSabado6);
            this.metroPanel1.Controls.Add(this.chbViernes5);
            this.metroPanel1.Controls.Add(this.chbLunes1);
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
            // chbMartes2
            // 
            this.chbMartes2.AutoSize = true;
            this.chbMartes2.Location = new System.Drawing.Point(3, 25);
            this.chbMartes2.Name = "chbMartes2";
            this.chbMartes2.Size = new System.Drawing.Size(59, 15);
            this.chbMartes2.TabIndex = 25;
            this.chbMartes2.Text = "Martes";
            this.chbMartes2.UseSelectable = true;
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
            // chbJueves4
            // 
            this.chbJueves4.AutoSize = true;
            this.chbJueves4.Location = new System.Drawing.Point(3, 68);
            this.chbJueves4.Name = "chbJueves4";
            this.chbJueves4.Size = new System.Drawing.Size(57, 15);
            this.chbJueves4.TabIndex = 23;
            this.chbJueves4.Text = "Jueves";
            this.chbJueves4.UseSelectable = true;
            // 
            // chbDomingo7
            // 
            this.chbDomingo7.AutoSize = true;
            this.chbDomingo7.Location = new System.Drawing.Point(93, 48);
            this.chbDomingo7.Name = "chbDomingo7";
            this.chbDomingo7.Size = new System.Drawing.Size(73, 15);
            this.chbDomingo7.TabIndex = 22;
            this.chbDomingo7.Text = "Domingo";
            this.chbDomingo7.UseSelectable = true;
            // 
            // chbMiercoles3
            // 
            this.chbMiercoles3.AutoSize = true;
            this.chbMiercoles3.Location = new System.Drawing.Point(3, 46);
            this.chbMiercoles3.Name = "chbMiercoles3";
            this.chbMiercoles3.Size = new System.Drawing.Size(74, 15);
            this.chbMiercoles3.TabIndex = 21;
            this.chbMiercoles3.Text = "Miercoles";
            this.chbMiercoles3.UseSelectable = true;
            // 
            // chbSabado6
            // 
            this.chbSabado6.AutoSize = true;
            this.chbSabado6.Location = new System.Drawing.Point(93, 26);
            this.chbSabado6.Name = "chbSabado6";
            this.chbSabado6.Size = new System.Drawing.Size(62, 15);
            this.chbSabado6.TabIndex = 20;
            this.chbSabado6.Text = "Sabado";
            this.chbSabado6.UseSelectable = true;
            // 
            // chbViernes5
            // 
            this.chbViernes5.AutoSize = true;
            this.chbViernes5.Location = new System.Drawing.Point(93, 5);
            this.chbViernes5.Name = "chbViernes5";
            this.chbViernes5.Size = new System.Drawing.Size(64, 15);
            this.chbViernes5.TabIndex = 18;
            this.chbViernes5.Text = "Viernes ";
            this.chbViernes5.UseSelectable = true;
            // 
            // chbLunes1
            // 
            this.chbLunes1.AutoSize = true;
            this.chbLunes1.Location = new System.Drawing.Point(3, 5);
            this.chbLunes1.Name = "chbLunes1";
            this.chbLunes1.Size = new System.Drawing.Size(57, 15);
            this.chbLunes1.TabIndex = 17;
            this.chbLunes1.Text = "Lunes ";
            this.chbLunes1.UseSelectable = true;
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
            this.metroPanel7.Controls.Add(this.metroLabel3);
            this.metroPanel7.Controls.Add(this.metroPanel6);
            this.metroPanel7.Controls.Add(this.metroPanel5);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(35, 239);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(519, 269);
            this.metroPanel7.TabIndex = 46;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(123, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(195, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Dias No laborales del Terapeuta";
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
            this.rbtAño.CheckedChanged += new System.EventHandler(this.rbtAño_CheckedChanged_1);
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
            this.rbtMes.CheckedChanged += new System.EventHandler(this.rbtMes_CheckedChanged_1);
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
            this.rbtSemana.CheckedChanged += new System.EventHandler(this.rbtSemana_CheckedChanged_1);
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
            this.btnEliminarDiaNoLaboral.Click += new System.EventHandler(this.btnEliminarDiaNoLaboral_Click_1);
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
            this.cboTerapeuta.Location = new System.Drawing.Point(109, -50);
            this.cboTerapeuta.Name = "cboTerapeuta";
            this.cboTerapeuta.Size = new System.Drawing.Size(163, 29);
            this.cboTerapeuta.TabIndex = 45;
            this.cboTerapeuta.UseSelectable = true;
            // 
            // cbmTera
            // 
            this.cbmTera.FormattingEnabled = true;
            this.cbmTera.ItemHeight = 23;
            this.cbmTera.Location = new System.Drawing.Point(123, 28);
            this.cbmTera.Name = "cbmTera";
            this.cbmTera.Size = new System.Drawing.Size(163, 29);
            this.cbmTera.TabIndex = 48;
            this.cbmTera.UseSelectable = true;
            this.cbmTera.SelectedIndexChanged += new System.EventHandler(this.cbmTera_SelectedIndexChanged);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 634);
            this.Controls.Add(this.cbmTera);
            this.Controls.Add(this.metroPanel8);
            this.Controls.Add(this.metroPanel7);
            this.Controls.Add(this.cboTerapeuta);
            this.Name = "frmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
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

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnModLab;
        private MetroFramework.Controls.MetroButton btnCargarL;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox chbMartes2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox chbJueves4;
        private MetroFramework.Controls.MetroCheckBox chbDomingo7;
        private MetroFramework.Controls.MetroCheckBox chbMiercoles3;
        private MetroFramework.Controls.MetroCheckBox chbSabado6;
        private MetroFramework.Controls.MetroCheckBox chbViernes5;
        private MetroFramework.Controls.MetroCheckBox chbLunes1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnCargarNL;
        private MetroFramework.Controls.MetroDateTime dtDiasNoLaborables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroRadioButton rbtAño;
        private MetroFramework.Controls.MetroRadioButton rbtMes;
        private MetroFramework.Controls.MetroRadioButton rbtSemana;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.Button btnEliminarDiaNoLaboral;
        private System.Windows.Forms.ListBox lstNoLaboralesSemana;
        private MetroFramework.Controls.MetroComboBox cboTerapeuta;
        private MetroFramework.Controls.MetroComboBox cbmTera;
    }
}