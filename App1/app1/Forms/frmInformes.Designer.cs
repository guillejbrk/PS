namespace App1.Forms
{
    partial class frmInformes
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
            this.vista3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDConsuDataSet1 = new App1.BDConsuDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDConsuDataSet = new App1.BDConsuDataSet();
            this.vista2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista2TableAdapter = new App1.BDConsuDataSetTableAdapters.Vista2TableAdapter();
            this.vista3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista3TableAdapter = new App1.BDConsuDataSet1TableAdapters.Vista3TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vista3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vista3BindingSource1
            // 
            this.vista3BindingSource1.DataMember = "Vista3";
            this.vista3BindingSource1.DataSource = this.bDConsuDataSet1;
            // 
            // bDConsuDataSet1
            // 
            this.bDConsuDataSet1.DataSetName = "BDConsuDataSet1";
            this.bDConsuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista3BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App1.Repo2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 507);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bDConsuDataSet
            // 
            this.bDConsuDataSet.DataSetName = "BDConsuDataSet";
            this.bDConsuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista2BindingSource
            // 
            this.vista2BindingSource.DataMember = "Vista2";
            this.vista2BindingSource.DataSource = this.bDConsuDataSet;
            // 
            // vista2TableAdapter
            // 
            this.vista2TableAdapter.ClearBeforeFill = true;
            // 
            // vista3BindingSource
            // 
            this.vista3BindingSource.DataMember = "Vista3";
            this.vista3BindingSource.DataSource = this.bDConsuDataSet1;
            // 
            // vista3TableAdapter
            // 
            this.vista3TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.Presentation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(696, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformes";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.frmTurnosPorPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDConsuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDConsuDataSet bDConsuDataSet;
        private System.Windows.Forms.BindingSource vista2BindingSource;
        private BDConsuDataSetTableAdapters.Vista2TableAdapter vista2TableAdapter;
        private BDConsuDataSet1 bDConsuDataSet1;
        private System.Windows.Forms.BindingSource vista3BindingSource;
        private BDConsuDataSet1TableAdapters.Vista3TableAdapter vista3TableAdapter;
        private System.Windows.Forms.BindingSource vista3BindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}