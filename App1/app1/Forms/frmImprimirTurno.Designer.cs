namespace App1.Forms
{
    partial class frmImprimirTurno
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDConsuDataSet = new App1.BDConsuDataSet();
            this.bDConsuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bDConsuDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App1.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(66, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDConsuDataSet
            // 
            this.bDConsuDataSet.DataSetName = "BDConsuDataSet";
            this.bDConsuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDConsuDataSetBindingSource
            // 
            this.bDConsuDataSetBindingSource.DataSource = this.bDConsuDataSet;
            this.bDConsuDataSetBindingSource.Position = 0;
            // 
            // frmImprimirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 315);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmImprimirTurno";
            this.Text = "frmImprimirTurno";
            this.Load += new System.EventHandler(this.frmImprimirTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDConsuDataSetBindingSource;
        private BDConsuDataSet bDConsuDataSet;



    }
}