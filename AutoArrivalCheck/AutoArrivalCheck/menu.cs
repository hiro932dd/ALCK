using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoArrivalCheck
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            exitmenu exitMenu = new exitmenu();
            exitMenu.Show();
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.Show();
        }
        private string GetLoginUser()
        {
            using (var con = new MySqlConnection("server=localhost;user=root;password=root;database=arrivalDB;"))
            {
                con.Open();
                var command = new MySqlCommand("SELECT * from user;", con);
            }
            return null;
        }
    }
}
