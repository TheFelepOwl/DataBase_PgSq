using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DB_Tech_lab
{
    public partial class Form1 : Form
    {

        NpgsqlConnection connection;

        /// OdbcConnection connection;

        Form2 form2;
        string password; // Declare the password variable
        string username; // Declare the username variable

        bool condition = false;


        public Form1(string username, string password, Form2 form2)
        {
            InitializeComponent();
            connection = DataBase.GetConnection(username, password);

            ///connection = DataBase_ODBC.GetConnection(username, password);


            this.form2 = form2;
            this.username = username; 
            this.password = password;

        }


        


        private async Task Connect_dbAsync(string query)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);

            System.Data.DataTable table = new System.Data.DataTable();
            await Task.Run(() => adapter.Fill(table));
            dataGridView1.DataSource = table;

            connection.Close();
        }


        private void Station_view()
        {
            dataGridView1.Columns["city"].HeaderText = "Місто";
            dataGridView1.Columns["station_name"].HeaderText = "Назва станції";
            dataGridView1.Columns["station_status"].HeaderText = "Статус станції";
            dataGridView1.Columns["URL"].HeaderText = "URL";
        }

        private void Category_view()
        {
            dataGridView1.Columns["designation"].HeaderText = "Найменування";

        }

        private void mQTTServer_view()
        {
            dataGridView1.Columns["status"].HeaderText = "Статус";
        }

        private void Coordinates_view()
        {
            dataGridView1.Columns["station_name"].HeaderText = "Назву станції";
            dataGridView1.Columns["longitude"].HeaderText = "Довгота і Широта";

        }

        private void Measurment_view()
        {
            dataGridView1.Columns["measurement_unit_Title"].HeaderText = "Назва";
            dataGridView1.Columns["measurement_time"].HeaderText = "Час вимірювання";
            dataGridView1.Columns["value_"].HeaderText = "Значення";
            dataGridView1.Columns["station_name"].HeaderText = "Назва станції";

        }

        private void Optimal_view()
        {
            dataGridView1.Columns["Designation"].HeaderText = "Позначення";
            dataGridView1.Columns["measurement_unit_Title"].HeaderText = "Назва одиниці вимірювання";
            dataGridView1.Columns["lower_limit"].HeaderText = "Нижній ліміт";
            dataGridView1.Columns["upper_limit"].HeaderText = "Верхній ліміт";

        }

        private void FavoriteStation_view()
        {
            dataGridView1.Columns["username"].HeaderText = "Ім'я користувача";
            dataGridView1.Columns["station_name"].HeaderText = "Назва станції";
        }

        private void MQTTMessageUnit_view()
        {
            dataGridView1.Columns["station_name"].HeaderText = "Назва станції";
            dataGridView1.Columns["Title"].HeaderText = "Назва одиниці вимірювання";
            dataGridView1.Columns["Message_"].HeaderText = "Повідомлення";
            dataGridView1.Columns["Oreder"].HeaderText = "Порядок";
        }
         


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private async void станціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT city, s.name AS station_name, s.status AS station_status, ms.URL " +
                   "FROM Station s " +
                   "INNER JOIN MQTT_Server ms ON s.Server_ID = ms.ID_MQTT_Server";
            await Connect_dbAsync(query);
            Station_view();

            

        }

        private async void категоріїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT Designation FROM Category";
            await Connect_dbAsync(query);
            Category_view();
            
        }

        private async void mQTTServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT URL, Status FROM MQTT_Server";
            await Connect_dbAsync(query);
            mQTTServer_view();
            
        }

        private async void кординатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT s.name AS station_name, longitude FROM Coordinates c " +
                          "INNER JOIN Station s ON c.station_ID = s.ID_station";

            await Connect_dbAsync(query);

            Coordinates_view();
            
        }

        private async void вимірюванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loadscreen loadscreen = new Loadscreen();
            loadscreen.Show();

            string query = "SELECT mu.Title AS measurement_unit_Title, measurement_time, value_, s.name AS station_name " +
                           "FROM Measurment m " +
                           "INNER JOIN Station s ON m.station_ID = s.ID_station " +
                           "INNER JOIN Measurment_Unit mu ON m.measurement_unit_ID = mu.ID_Measurment_Unit";

            await Connect_dbAsync(query);

            Measurment_view();

            loadscreen.Close();

            
        }


        private async void оптималніЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT c.Designation, mu.Title AS measurement_unit_Title, o.lower_limit, o.upper_limit " +
                 "FROM Optimal_Value o " +
                 "INNER JOIN Category c ON o.category_ID = c.ID_Category " +
                 "INNER JOIN Measurment_Unit mu ON o.measurement_unit_ID = mu.ID_Measurment_Unit";
            await Connect_dbAsync(query);
            Optimal_view();
            
        }

        private async void улюбленнаСтанціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            string query = "SELECT username, s.name AS station_name FROM Favorite_Station fs " +
                          "INNER JOIN Station s ON fs.station_ID = s.ID_station";
            await Connect_dbAsync(query);
            FavoriteStation_view();
            
        }

        private async void mQTTMessegeUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            string query = "SELECT s.name AS station_name, mu.Title, mmu.Message_, mmu.Oreder " +
                   "FROM MQTT_Message_Unit mmu " +
                   "INNER JOIN Station s ON mmu.station_ID = s.ID_station " +
                   "INNER JOIN Measurment_Unit mu ON mmu.measurement_unit_ID = mu.ID_Measurment_Unit";
            await Connect_dbAsync(query);
            MQTTMessageUnit_view();
            
        }

        private void списокПідключенихСтанційToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void вийтиЗАкаунтуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void вийтиЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void результатиВимірюваньСтанціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(username, password, form2);
            form4.Show();
        }

        private void powerBIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerBi power_bi = new PowerBi();

            power_bi.Show();
        }

        private void репортToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void максимальніЗначеняШкідливихЧастинокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(username, password, form2);
            form5.Show();
        }

        private void кількостіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(username, password, form2);
            form6.Show();
        }

        private void оптимальніЗначеняДляSO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(username, password, form2);
            form7.Show();
        }

        private void оптимальніЗначеняДляCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(username, password, form2);
            form8.Show();
        }
    }
}
