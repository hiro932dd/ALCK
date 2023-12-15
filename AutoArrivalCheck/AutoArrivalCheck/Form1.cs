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
            textBox2.PasswordChar = '��';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection("server=localhost;user=root;password=root;database=arrivalDB;"))
            {
                con.Open();
                string inputUsername = textBox1.Text;
                string inputPassword = textBox2.Text;
                // �f�[�^�x�[�X���烆�[�U�[������
                var command = new MySqlCommand("SELECT * FROM user;", con);
                command.Parameters.AddWithValue("@uName", inputUsername);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // ���[�U�[�����������ꍇ
                        string dbPassword = reader["uPassword"].ToString();

                        // �p�X���[�h�̈�v���m�F
                        if (inputPassword == dbPassword)
                        {
                            menu menuForm = new menu();
                            menuForm.Show();

                            // ���̃t�H�[�����\���ɂ���
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("�p�X���[�h����v���܂���");
                        }
                    }
                    else
                    {
                        MessageBox.Show("���[�U�[�����݂��܂���");
                    }
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //�L�����Z���ŃA�v���I��
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}