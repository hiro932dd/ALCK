using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AutoArrivalCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '●';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection("server=localhost;user=root;password=root;database=arrivalDB;"))
            {
                con.Open();
                string inputUsername = textBox1.Text;
                string inputPassword = textBox2.Text;
                // データベースからユーザーを検索
                var command = new MySqlCommand("SELECT * FROM user;", con);
                command.Parameters.AddWithValue("@uName", inputUsername);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // ユーザーが見つかった場合
                        string dbPassword = reader["uPassword"].ToString();

                        // パスワードの一致を確認
                        if (inputPassword == dbPassword)
                        {
                            menu menuForm = new menu();
                            menuForm.Show();

                            // このフォームを非表示にする
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("パスワードが一致しません");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ユーザーが存在しません");
                    }
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //キャンセルでアプリ終了
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}