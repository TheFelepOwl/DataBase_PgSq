namespace DB_Tech_lab
{
    partial class Form3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.stationviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB_Tech_lab.DataSet1();
            this.stationviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new DB_Tech_lab.MyDataSet();
            this.myDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.station_viewTableAdapter = new DB_Tech_lab.MyDataSetTableAdapters.station_viewTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.station_viewTableAdapter1 = new DB_Tech_lab.DataSet1TableAdapters.station_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stationviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stationviewBindingSource1
            // 
            this.stationviewBindingSource1.DataMember = "station_view";
            this.stationviewBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationviewBindingSource
            // 
            this.stationviewBindingSource.DataMember = "station_view";
            this.stationviewBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDataSetBindingSource
            // 
            this.myDataSetBindingSource.DataSource = this.myDataSet;
            this.myDataSetBindingSource.Position = 0;
            // 
            // station_viewTableAdapter
            // 
            this.station_viewTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "StationSet1";
            reportDataSource2.Value = this.stationviewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_Tech_lab.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // station_viewTableAdapter1
            // 
            this.station_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Список підключених станцій";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stationviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource myDataSetBindingSource;
        private System.Windows.Forms.BindingSource stationviewBindingSource;
        private MyDataSetTableAdapters.station_viewTableAdapter station_viewTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource stationviewBindingSource1;
        private DataSet1TableAdapters.station_viewTableAdapter station_viewTableAdapter1;
    }
}