namespace App1.Forms
{
    partial class frmInformes2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDias = new App1.dtsDias();
            this.turnoTableAdapter = new App1.dtsDiasTableAdapters.TurnoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.turnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.dtsDias;
            // 
            // dtsDias
            // 
            this.dtsDias.DataSetName = "dtsDias";
            this.dtsDias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.turnoBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App1.RepoHo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(561, 299);
            this.reportViewer1.TabIndex = 0;
            // 
            // turnoBindingSource1
            // 
            this.turnoBindingSource1.DataMember = "Turno";
            this.turnoBindingSource1.DataSource = this.dtsDias;
            // 
            // frmInformes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 414);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformes2";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "frmInformes2";
            this.Load += new System.EventHandler(this.frmInformes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dtsDias dtsDias;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private dtsDiasTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource turnoBindingSource1;
    }
}