using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Diagnostics;

namespace DB_Tech_lab
{
    public partial class Form7 : Form
    {
        private NpgsqlConnection connection;

        public Form7(string username, string password, Form2 form2)
        {
            InitializeComponent();
            connection = DataBase.GetConnection(username, password);
            form2.SendToBack();
        }

        private void Form7_Load(object sender, EventArgs e)
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
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM View_AVG_25 WHERE Назва_станції = '{stationComboBox.SelectedValue.ToString()}' AND Назва_параметру = 'Sulfur dioxide(SO2)' ;", connection);

            // Fill the DataSet with the result of the query
            adapter.Fill(dataSet);

            int Excellent = 0;
            int Fine = 0;
            int Moderate = 0;
            int poorCount = 0;
            int veryPoorCount = 0;
            int Severe = 0;

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string cleanliness = row["Степіть_чистоти_повітря"].ToString();


                if (cleanliness.Equals("Excellent", StringComparison.OrdinalIgnoreCase))
                {
                    Excellent++;
                }
                else if (cleanliness.Equals("Fine", StringComparison.OrdinalIgnoreCase))
                {
                    Fine++;
                }
                else if (cleanliness.Equals("Moderate", StringComparison.OrdinalIgnoreCase))
                {
                    Moderate++;
                }
                else if (cleanliness.Equals("poor", StringComparison.OrdinalIgnoreCase))
                {
                    poorCount++;
                }
                else if (cleanliness.Equals("very poor", StringComparison.OrdinalIgnoreCase))
                {
                    veryPoorCount++;
                }
                else if (cleanliness.Equals("Severe", StringComparison.OrdinalIgnoreCase))
                {
                    Severe++;
                }
            }   


            this.viewavg25BindingSource.DataSource = dataSet.Tables[0];

            // Set the report parameter
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Excellent", Excellent.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Fine", Fine.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Moderate", Moderate.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Poor", poorCount.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Very_Poor", veryPoorCount.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Severe", Severe.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("station", stationComboBox.SelectedValue.ToString()));
            

            Python_grafix(Excellent, Fine , Moderate, poorCount, veryPoorCount, Severe,stationComboBox.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }


        public void Python_grafix(int Excellent,int Fine, int Moderate,int poorCount, int veryPoorCount, int Severe ,string stationName)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Users\TheFelepOwl\Documents\nubip\Tech_DataBase\DataBase_visualizer\venv\Scripts\python.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"\"C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\SO2.py\" \"{Excellent}\" \"{Fine}\" \"{Moderate}\" \"{poorCount}\" \"{veryPoorCount}\" \"{Severe}\" \"{stationName}\""
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();

                // Получение вывода стандартного потока ошибок
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();

                // Вывод в консоль C#
                Console.WriteLine(errorOutput);

                // Проверка кода завершения процесса
                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"Error: {process.ExitCode}");
                }
            }

            // Отображение сохраненного изображения в PictureBox
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

                // Получение вывода стандартного потока ошибок
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();

                // Вывод в консоль C#
                Console.WriteLine(errorOutput);

                // Проверка кода завершения процесса
                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"Error: {process.ExitCode}");
                }
            }
        }
    }
}
