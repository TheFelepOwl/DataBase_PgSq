using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Tech_lab
{
    public partial class Form4 : Form
    {


        private NpgsqlConnection connection;

        private DataBase MyDB;

        public Form4(string username, string password, Form2 form2)
        {
            InitializeComponent();
            connection = DataBase.GetConnection(username, password);

            


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Station", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            stationComboBox.DataSource = table;
            stationComboBox.DisplayMember = "name";
            stationComboBox.ValueMember = "name";
            stationComboBox.Text = "Виберіть станцію";


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayReport();
        }

        



        private void GenerateAndDisplayReport()
        {

           
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", dateTimePicker1.Value.ToString("dd.MM.yyyy")));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ParameterEnd", dateTimePicker2.Value.ToString("dd.MM.yyyy")));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ParameterStation", stationComboBox.SelectedValue.ToString()));




            // Retrieve data for the report
            System.Data.DataSet dataSet = new System.Data.DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM View_Results WHERE Час >= '{dateTimePicker1.Value.ToString()}' AND Час <= '{dateTimePicker2.Value.ToString()}' AND Назва_станції = '{stationComboBox.SelectedValue.ToString()}';", connection);
            adapter.Fill(dataSet);

            this.viewresultsBindingSource1.DataSource = dataSet.Tables[0];

            
            // Refresh the report
            this.reportViewer1.RefreshReport();



            


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

