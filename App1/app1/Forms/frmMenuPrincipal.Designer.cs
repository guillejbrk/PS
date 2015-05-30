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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.nuevaHistoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.informesToolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1160, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.BackgroundImage = global::App1.Properties.Resources.Boton;
            this.archivoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarTurnoToolStripMenuItem,
            this.cargarHistoriaToolStripMenuItem,
            this.buscarPacienteToolStripMenuItem,
            this.buscarHistorialToolStripMenuItem,
            this.agendaTelefonicaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarTurnoToolStripMenuItem
            // 
            this.cargarTurnoToolStripMenuItem.Name = "cargarTurnoToolStripMenuItem";
            this.cargarTurnoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cargarTurnoToolStripMenuItem.Text = "Nuevo Turno";
            this.cargarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cargarTurnoToolStripMenuItem_Click);
            // 
            // cargarHistoriaToolStripMenuItem
            // 
            this.cargarHistoriaToolStripMenuItem.Name = "cargarHistoriaToolStripMenuItem";
            this.cargarHistoriaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cargarHistoriaToolStripMenuItem.Text = "Nueva Historia";
            this.cargarHistoriaToolStripMenuItem.Click += new System.EventHandler(this.cargarHistoriaToolStripMenuItem_Click);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // buscarHistorialToolStripMenuItem
            // 
            this.buscarHistorialToolStripMenuItem.Name = "buscarHistorialToolStripMenuItem";
            this.buscarHistorialToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buscarHistorialToolStripMenuItem.Text = "Buscar Historial";
            this.buscarHistorialToolStripMenuItem.Click += new System.EventHandler(this.buscarHistorialToolStripMenuItem_Click);
            // 
            // agendaTelefonicaToolStripMenuItem
            // 
            this.agendaTelefonicaToolStripMenuItem.Name = "agendaTelefonicaToolStripMenuItem";
            this.agendaTelefonicaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agendaTelefonicaToolStripMenuItem.Text = "Agenda Telefonica";
            this.agendaTelefonicaToolStripMenuItem.Click += new System.EventHandler(this.agendaTelefonicaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.administracionToolStripMenuItem.BackgroundImage = global::App1.Properties.Resources.Boton;
            this.administracionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.prodToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.agendaToolStripMenuItem,
            this.nuevaHistoriaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.turnoToolStripMenuItem,
            this.terapeutaToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.turnoToolStripMenuItem.Text = "Tratamiento";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // terapeutaToolStripMenuItem
            // 
            this.terapeutaToolStripMenuItem.Name = "terapeutaToolStripMenuItem";
            this.terapeutaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.terapeutaToolStripMenuItem.Text = "Terapeuta";
            this.terapeutaToolStripMenuItem.Click += new System.EventHandler(this.terapeutaToolStripMenuItem_Click);
            // 
            // prodToolStripMenuItem
            // 
            this.prodToolStripMenuItem.Name = "prodToolStripMenuItem";
            this.prodToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.prodToolStripMenuItem.Text = "Productos Disponibles";
            this.prodToolStripMenuItem.Click += new System.EventHandler(this.prodToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            this.turnosToolStripMenuItem.Click += new System.EventHandler(this.turnosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // nuevaHistoriaToolStripMenuItem
            // 
            this.nuevaHistoriaToolStripMenuItem.Name = "nuevaHistoriaToolStripMenuItem";
            this.nuevaHistoriaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nuevaHistoriaToolStripMenuItem.Text = "Nueva Historia";
            this.nuevaHistoriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaHistoriaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem1
            // 
            this.informesToolStripMenuItem1.BackgroundImage = global::App1.Properties.Resources.Boton;
            this.informesToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informesToolStripMenuItem1.Name = "informesToolStripMenuItem1";
            this.informesToolStripMenuItem1.Size = new System.Drawing.Size(63, 23);
            this.informesToolStripMenuItem1.Text = "Informes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ayudaToolStripMenuItem.BackgroundImage = global::App1.Properties.Resources.Boton;
            this.ayudaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "MENU";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terapeutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaHistoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaTelefonicaToolStripMenuItem;
    }
}