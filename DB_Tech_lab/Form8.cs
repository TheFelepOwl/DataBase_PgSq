﻿using Npgsql;
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
    public partial class Form8 : Form
    {
        private NpgsqlConnection connection;

        public Form8(string username, string password, Form2 form2)
        {
            InitializeComponent();
            connection = DataBase.GetConnection(username, password);
            form2.SendToBack();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Station", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            stationComboBox.DataSource = table;
            stationComboBox.DisplayMember = "name";
            stationComboBox.ValueMember = "name";
            stationComboBox.Text = "Виберіть станцію";



        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            var loadingScreen = new Loadscreen();
            loadingScreen.Show();
            await Task.Delay(100); 

            try
            {
                System.Data.DataSet dataSet = new System.Data.DataSet();

                

                // Create a NpgsqlDataAdapter with the query
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM View_AVG_25 WHERE Назва_станції = '{stationComboBox.SelectedValue.ToString()}' AND Назва_параметру = 'Carbon monoxide(CO)' ;", connection);

                // Fill the DataSet with the result of the query
                adapter.Fill(dataSet);

                int Excellent = 0;
                int Fine = 0;
                int Moderate = 0;

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

                    

                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Excellent", Excellent.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Fine", Fine.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Moderate", Moderate.ToString()));
                    this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("station", stationComboBox.SelectedValue.ToString()));

                    await Task.Delay(100); 

                    }
                this.viewavg25BindingSource.DataSource = dataSet.Tables[0];
                Python_grafix(Excellent, Fine, Moderate, stationComboBox.SelectedValue.ToString());
                this.reportViewer1.RefreshReport();
            }
            finally
            {
               
                loadingScreen.Close();
            }
        }


        public void Python_grafix(int Excellent,int Fine, int Moderate, string stationName)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Users\TheFelepOwl\Documents\nubip\Tech_DataBase\DataBase_visualizer\venv\Scripts\python.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"\"C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\CO.py\" \"{Excellent}\" \"{Fine}\" \"{Moderate}\" \"{stationName}\""
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

            // Отображение сохраненного изображения в PictureBox
            pictureBox1.ImageLocation = "C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\grafix.png";
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void stationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
