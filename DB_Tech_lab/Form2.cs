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

namespace DB_Tech_lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;



            try
            {
                // Попытка подключения к базе данных
                NpgsqlConnection connection = DataBase.GetConnection(username, password);

                ///OdbcConnection connection = DataBase_ODBC.GetConnection(username, password);



                // Если подключение успешно, открываем Form1\

                Form1 form1 = new Form1(username, password, this);
                Form4 form4 = new Form4(username, password, this);
                Form5 form5 = new Form5(username, password, this);
                Form6 form6 = new Form6(username, password, this);
                Form7 form7 = new Form7(username, password, this);
                Form8 form8 = new Form8(username, password, this);



                form1.Show();

                this.Hide();


            }
            catch (NpgsqlException ex)
            {
                // Обработка ошибки подключения
                MessageBox.Show("Невірний Логін або Пароль");

                // Очищаем поле пароля и предоставляем пользователю возможность ввести его снова
                textBoxPassword.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
