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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarHistoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaTelefonicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terapeutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(137, 620);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.ayudaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.sa;
            this.pictureBox1.Location = new System.Drawing.Point(20, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.archivoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarHistoriaToolStripMenuItem,
            this.cargarTurnoToolStripMenuItem,
            this.buscarPacienteToolStripMenuItem,
            this.buscarHistorialToolStripMenuItem,
            this.agendaTelefonicaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Myriad Hebrew", 12.75F, System.Drawing.FontStyle.Italic);
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.archivoToolStripMenuItem.Image = global::App1.Properties.Resources.edit;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(124, 34);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarTurnoToolStripMenuItem
            // 
            this.cargarTurnoToolStripMenuItem.Image = global::App1.Properties.Resources.blocnote;
            this.cargarTurnoToolStripMenuItem.Name = "cargarTurnoToolStripMenuItem";
            this.cargarTurnoToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.cargarTurnoToolStripMenuItem.Text = "Nuevo Turno";
            this.cargarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cargarTurnoToolStripMenuItem_Click);
            // 
            // cargarHistoriaToolStripMenuItem
            // 
            this.cargarHistoriaToolStripMenuItem.Image = global::App1.Properties.Resources.book3;
            this.cargarHistoriaToolStripMenuItem.Name = "cargarHistoriaToolStripMenuItem";
            this.cargarHistoriaToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.cargarHistoriaToolStripMenuItem.Text = "Nueva Historia";
            this.cargarHistoriaToolStripMenuItem.Click += new System.EventHandler(this.cargarHistoriaToolStripMenuItem_Click);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Image = global::App1.Properties.Resources.user_man1;
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // buscarHistorialToolStripMenuItem
            // 
            this.buscarHistorialToolStripMenuItem.Image = global::App1.Properties.Resources.diary_128;
            this.buscarHistorialToolStripMenuItem.Name = "buscarHistorialToolStripMenuItem";
            this.buscarHistorialToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.buscarHistorialToolStripMenuItem.Text = "Buscar Historial";
            this.buscarHistorialToolStripMenuItem.Click += new System.EventHandler(this.buscarHistorialToolStripMenuItem_Click);
            // 
            // agendaTelefonicaToolStripMenuItem
            // 
            this.agendaTelefonicaToolStripMenuItem.Image = global::App1.Properties.Resources.telephone_red;
            this.agendaTelefonicaToolStripMenuItem.Name = "agendaTelefonicaToolStripMenuItem";
            this.agendaTelefonicaToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.agendaTelefonicaToolStripMenuItem.Text = "Agenda Telefonica";
            this.agendaTelefonicaToolStripMenuItem.Click += new System.EventHandler(this.agendaTelefonicaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::App1.Properties.Resources.deletered;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.administracionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.prodToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.agendaToolStripMenuItem});
            this.administracionToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
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
            this.clienteToolStripMenuItem.Image = global::App1.Properties.Resources.user_man1;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.clienteToolStripMenuItem.Text = "Paciente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.turnoToolStripMenuItem.Text = "Tratamiento";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // terapeutaToolStripMenuItem
            // 
            this.terapeutaToolStripMenuItem.Name = "terapeutaToolStripMenuItem";
            this.terapeutaToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.terapeutaToolStripMenuItem.Text = "Terapeuta";
            this.terapeutaToolStripMenuItem.Click += new System.EventHandler(this.terapeutaToolStripMenuItem_Click);
            // 
            // prodToolStripMenuItem
            // 
            this.prodToolStripMenuItem.Name = "prodToolStripMenuItem";
            this.prodToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.prodToolStripMenuItem.Text = "Productos Disponibles";
            this.prodToolStripMenuItem.Click += new System.EventHandler(this.prodToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.turnosToolStripMenuItem.Text = "Turnos";
            this.turnosToolStripMenuItem.Click += new System.EventHandler(this.turnosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(243, 36);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(243, 36);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem1
            // 
            this.informesToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOrange;
            this.informesToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informesToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.informesToolStripMenuItem1.Image = global::App1.Properties.Resources.Presentation_icon;
            this.informesToolStripMenuItem1.Name = "informesToolStripMenuItem1";
            this.informesToolStripMenuItem1.Size = new System.Drawing.Size(124, 34);
            this.informesToolStripMenuItem1.Text = "Informes";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
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
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaTelefonicaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}