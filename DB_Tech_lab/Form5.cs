using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace DB_Tech_lab
{
    public partial class Form5 : Form
    {
        private NpgsqlConnection connection;

        public Form5(string username, string password, Form2 form2)
        {
            InitializeComponent();
            connection = DataBase.GetConnection(username, password);
            form2.SendToBack();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "visualizatorSet.visualizor". При необходимости она может быть перемещена или удалена.
            this.visualizorTableAdapter.Fill(this.visualizatorSet.visualizor);




        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Loadscreen loadscreen = new Loadscreen();
            loadscreen.Show();

            GenerateAndDisplayReport();
            Python_grafix();

            loadscreen.Close();
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

        public void GenerateAndDisplayReport()
        {


            System.Data.DataSet dataSet = new System.Data.DataSet();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($@"SELECT 
            s.city AS Місто,
            mu.Title AS Назва_параметру,
            MAX(mv.value_) AS Результат_вимірювання
        FROM
            Station s
        JOIN
            Measurment mv ON s.ID_station = mv.station_ID
        JOIN
            Measurment_Unit mu ON mv.measurement_unit_ID = mu.ID_Measurment_Unit
        WHERE
            mu.Title IN ('PM2.5', 'PM10')
            AND mv.measurement_time >= '{dateTimePicker1.Value.ToString()}'
            AND mv.measurement_time <= '{dateTimePicker2.Value.ToString()}'
        GROUP BY
            s.city, mu.Title;", connection);
            adapter.Fill(dataSet);

            visualizorBindingSource.DataSource = dataSet.Tables[0];

            

            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", dateTimePicker1.Value.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameterEnd1", dateTimePicker1.Value.ToString()));
            this.reportViewer1.RefreshReport();
        }

        public void Python_grafix()
        {
            string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Users\TheFelepOwl\Documents\nubip\Tech_DataBase\DataBase_visualizer\venv\Scripts\python.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"\"C:\\Users\\TheFelepOwl\\Documents\\nubip\\Tech_DataBase\\DataBase_visualizer\\main.py\" \"{startDate}\" \"{endDate}\""
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

    }
}