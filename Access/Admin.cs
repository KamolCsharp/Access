using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access
{
    public partial class Admin : Form
    {
        private string login="1";
        private string password="2";
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==login && textBox2.Text==password)
            {
                RegUser regUser = new RegUser();
                regUser.Show();
                Admin admin = new Admin();
                admin.Hide();
            }
            else
            {
                MessageBox.Show("Login yoki Parol noto'g'ri !!!", "Admin");
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
