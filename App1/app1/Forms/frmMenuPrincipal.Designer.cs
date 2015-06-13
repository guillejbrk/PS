namespace App1.Forms
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarHistoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaTelefonicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terapeutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.prodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesTerapeutaYPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomeDiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Myriad Hebrew", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.informesToolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(137, 801);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.archivoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarTurnoToolStripMenuItem,
            this.cargarHistoriaToolStripMenuItem,
            this.toolStripSeparator3,
            this.buscarPacienteToolStripMenuItem,
            this.buscarHistorialToolStripMenuItem,
            this.toolStripSeparator2,
            this.agendaTelefonicaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Myriad Hebrew", 12.75F, System.Drawing.FontStyle.Italic);
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Image = global::App1.Properties.Resources.edit;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(124, 34);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarTurnoToolStripMenuItem
            // 
            this.cargarTurnoToolStripMenuItem.Image = global::App1.Properties.Resources.blocnote;
            this.cargarTurnoToolStripMenuItem.Name = "cargarTurnoToolStripMenuItem";
            this.cargarTurnoToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.cargarTurnoToolStripMenuItem.Text = "Nuevo Turno";
            this.cargarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cargarTurnoToolStripMenuItem_Click);
            // 
            // cargarHistoriaToolStripMenuItem
            // 
            this.cargarHistoriaToolStripMenuItem.Image = global::App1.Properties.Resources.diary_128;
            this.cargarHistoriaToolStripMenuItem.Name = "cargarHistoriaToolStripMenuItem";
            this.cargarHistoriaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.cargarHistoriaToolStripMenuItem.Text = "Nueva Historia";
            this.cargarHistoriaToolStripMenuItem.Click += new System.EventHandler(this.cargarHistoriaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Image = global::App1.Properties.Resources.male_user_search;
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // buscarHistorialToolStripMenuItem
            // 
            this.buscarHistorialToolStripMenuItem.Image = global::App1.Properties.Resources.book3;
            this.buscarHistorialToolStripMenuItem.Name = "buscarHistorialToolStripMenuItem";
            this.buscarHistorialToolStripMenuItem.ShowShortcutKeys = false;
            this.buscarHistorialToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.buscarHistorialToolStripMenuItem.Text = "Buscar Historial";
            this.buscarHistorialToolStripMenuItem.Click += new System.EventHandler(this.buscarHistorialToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // agendaTelefonicaToolStripMenuItem
            // 
            this.agendaTelefonicaToolStripMenuItem.Image = global::App1.Properties.Resources.telephone_red;
            this.agendaTelefonicaToolStripMenuItem.Name = "agendaTelefonicaToolStripMenuItem";
            this.agendaTelefonicaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.agendaTelefonicaToolStripMenuItem.Text = "Agenda Telefonica";
            this.agendaTelefonicaToolStripMenuItem.Click += new System.EventHandler(this.agendaTelefonicaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::App1.Properties.Resources.deletered;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.administracionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.toolStripSeparator4,
            this.prodToolStripMenuItem,
            this.tratamientosToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.toolStripSeparator5,
            this.agendaToolStripMenuItem});
            this.administracionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.administracionToolStripMenuItem.Image = global::App1.Properties.Resources.man_grey;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(124, 34);
            this.administracionToolStripMenuItem.Text = "Administrar";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.turnoToolStripMenuItem,
            this.terapeutaToolStripMenuItem});
            this.cargarToolStripMenuItem.Image = global::App1.Properties.Resources.edit;
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::App1.Properties.Resources.male_user_edit1;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.clienteToolStripMenuItem.Text = "Paciente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::App1.Properties.Resources.shopping_cart_add;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Image = global::App1.Properties.Resources.checklist;
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.turnoToolStripMenuItem.Text = "Tratamiento";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // terapeutaToolStripMenuItem
            // 
            this.terapeutaToolStripMenuItem.Image = global::App1.Properties.Resources.ii;
            this.terapeutaToolStripMenuItem.Name = "terapeutaToolStripMenuItem";
            this.terapeutaToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.terapeutaToolStripMenuItem.Text = "Terapeuta";
            this.terapeutaToolStripMenuItem.Click += new System.EventHandler(this.terapeutaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(240, 6);
            // 
            // prodToolStripMenuItem
            // 
            this.prodToolStripMenuItem.Image = global::App1.Properties.Resources.shopping_cart_accept;
            this.prodToolStripMenuItem.Name = "prodToolStripMenuItem";
            this.prodToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.prodToolStripMenuItem.Text = "Productos Disponibles";
            this.prodToolStripMenuItem.Click += new System.EventHandler(this.prodToolStripMenuItem_Click);
            // 
            // tratamientosToolStripMenuItem
            // 
            this.tratamientosToolStripMenuItem.Image = global::App1.Properties.Resources.checklist;
            this.tratamientosToolStripMenuItem.Name = "tratamientosToolStripMenuItem";
            this.tratamientosToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.tratamientosToolStripMenuItem.Text = "Tratamientos";
            this.tratamientosToolStripMenuItem.Click += new System.EventHandler(this.tratamientosToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Image = global::App1.Properties.Resources.blocnote;
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.turnosToolStripMenuItem.Text = "Turnos";
            this.turnosToolStripMenuItem.Click += new System.EventHandler(this.turnosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(240, 6);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Image = global::App1.Properties.Resources.address_book;
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.agendaToolStripMenuItem.Text = "Agenda Terapueta";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem1
            // 
            this.informesToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOrange;
            this.informesToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesTerapeutaYPacienteToolStripMenuItem,
            this.infomeDiasToolStripMenuItem});
            this.informesToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.informesToolStripMenuItem1.Image = global::App1.Properties.Resources.Presentation_icon;
            this.informesToolStripMenuItem1.Name = "informesToolStripMenuItem1";
            this.informesToolStripMenuItem1.Size = new System.Drawing.Size(124, 34);
            this.informesToolStripMenuItem1.Text = "Informes";
            // 
            // informesTerapeutaYPacienteToolStripMenuItem
            // 
            this.informesTerapeutaYPacienteToolStripMenuItem.Name = "informesTerapeutaYPacienteToolStripMenuItem";
            this.informesTerapeutaYPacienteToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.informesTerapeutaYPacienteToolStripMenuItem.Text = "Informes Terapeuta y paciente";
            this.informesTerapeutaYPacienteToolStripMenuItem.Click += new System.EventHandler(this.informesTerapeutaYPacienteToolStripMenuItem_Click);
            // 
            // infomeDiasToolStripMenuItem
            // 
            this.infomeDiasToolStripMenuItem.Name = "infomeDiasToolStripMenuItem";
            this.infomeDiasToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.infomeDiasToolStripMenuItem.Text = "Infome Dias";
            this.infomeDiasToolStripMenuItem.Click += new System.EventHandler(this.infomeDiasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.ayudaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.Image = global::App1.Properties.Resources.help;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(124, 34);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.informacionToolStripMenuItem.Text = "Informacion";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(152, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.sa;
            this.pictureBox1.Location = new System.Drawing.Point(20, 772);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 881);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Bienvenido";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarHistoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terapeutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaTelefonicaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem prodToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamientosToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.ToolStripMenuItem informesTerapeutaYPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomeDiasToolStripMenuItem;
    }
}