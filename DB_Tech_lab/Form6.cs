using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DB_Tech_lab
{
    public partial class Form6 : Form
    {
        private NpgsqlConnection connection;

        public Form6(string username, string password, Form2 form2)
        {
            InitializeComponent();
            connection = DataBase.GetConnection(username, password);
            form2.SendToBack();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            

            // Create a DataSet to store the result of the query
            System.Data.DataSet dataSet = new System.Data.DataSet();

            // Create a NpgsqlDataAdapter with the query
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM View_AVG_25 WHERE Назва_станції = '{stationComboBox.SelectedValue.ToString()}' AND Назва_параметру='PM2.5' ;", connection);

            // Fill the DataSet with the result of the query
            adapter.Fill(dataSet);

           
            int poorCount = 0;
            int veryPoorCount = 0;

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string cleanliness = row["Степіть_чистоти_повітря"].ToString();

                if (cleanliness.Equals("poor", StringComparison.OrdinalIgnoreCase))
                {
                    poorCount++;
                }
                else if (cleanliness.Equals("very poor", StringComparison.OrdinalIgnoreCase))
                {
                    veryPoorCount++;
                }
            }

            

            
            this.aVG25SetBindingSource.DataSource = dataSet.Tables[0];

          
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Counter", poorCount.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Very_poor", veryPoorCount.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("station", stationComboBox.SelectedValue.ToString()));
           
            this.reportViewer1.RefreshReport();

            Python_grafix(poorCount, veryPoorCount, stationComboBox.SelectedValue.ToString());
        }


        public void Python_grafix(int poorCount, int veryPoorCount, string stationName)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Users\TheFelepOwl\Documents\nubip\Tech_DataBase\DataBase_visualizer\venv\Scripts\python.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"\"C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\Avg_25.py\" \"{poorCount}\" \"{veryPoorCount}\" \"{stationName}\""
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();

                
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();

            
                Console.WriteLine(errorOutput);

               
                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"Error: {process.ExitCode}");
                }
            }

            
            pictureBox1.ImageLocation = "C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\grafix.png";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Users\TheFelepOwl\Documents\nubip\Tech_DataBase\DataBase_visualizer\venv\Scripts\python.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"\"C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\show_plot.py\" "
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();

                
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();

          
                Console.WriteLine(errorOutput);

             
                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"Error: {process.ExitCode}");
                }
            }
        }

        private void stationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
