namespace DB_Tech_lab
{
    partial class Form6
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
            this.viewavg25BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVG25SetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVG_25_Set = new DB_Tech_lab.AVG_25_Set();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_avg_25TableAdapter = new DB_Tech_lab.AVG_25_SetTableAdapters.view_avg_25TableAdapter();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewavg25BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVG25SetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVG_25_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewavg25BindingSource
            // 
            this.viewavg25BindingSource.DataMember = "view_avg_25";
            this.viewavg25BindingSource.DataSource = this.aVG25SetBindingSource;
            // 
            // aVG25SetBindingSource
            // 
            this.aVG25SetBindingSource.DataSource = this.aVG_25_Set;
            this.aVG25SetBindingSource.Position = 0;
            // 
            // aVG_25_Set
            // 
            this.aVG_25_Set.DataSetName = "AVG_25_Set";
            this.aVG_25_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewavg25BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_Tech_lab.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(595, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_avg_25TableAdapter
            // 
            this.view_avg_25TableAdapter.ClearBeforeFill = true;
            // 
            // stationComboBox
            // 
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(634, 256);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(153, 21);
            this.stationComboBox.TabIndex = 1;
            this.stationComboBox.SelectedIndexChanged += new System.EventHandler(this.stationComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(629, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Станція";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 932);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stationComboBox);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form6";
            this.Text = "Avg_PM2.5";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewavg25BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVG25SetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVG_25_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource aVG25SetBindingSource;
        private AVG_25_Set aVG_25_Set;
        private System.Windows.Forms.BindingSource viewavg25BindingSource;
        private AVG_25_SetTableAdapters.view_avg_25TableAdapter view_avg_25TableAdapter;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.Label label1;
    }
}