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
    public partial class exitmenu : Form
    {
        public exitmenu()
        {
            InitializeComponent();
        }

        private void exitGo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
