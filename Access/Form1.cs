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
    public partial class Form1 : Form
    {

        private string[] login;
        private string[] password;
        public int id;
        public Form1()
        {
            try
            {
                DB.db = new cSQL();
                DB.db.cSQL_init(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Xususiy_kilinika.accdb;Persist Security Info=False;");
                DB.db.Connect();
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                MessageBox.Show(exp.ToString());
            }

            InitializeComponent();
        }
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            string s = "select * from Xodim";
            dt = DB.db.Query(s);
            login = new string[dt.Rows.Count];
            password = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                login[i] = dt.Rows[i]["Login"].ToString();
                password[i] = dt.Rows[i]["Parol"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "reg" && textBox2.Text == "id")
                {
                    Regstratura regstratura = new Regstratura();
                    this.Hide();
                    regstratura.ShowDialog();
                    this.Show();
                }
                else if (login.Contains(textBox1.Text) && password.Contains(textBox2.Text))
                {
                    string fam = "", ism = "", shar = "";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (login[i].Equals(textBox1.Text) && password[i].Equals(textBox2.Text))
                        {
                            id = int.Parse(dt.Rows[i]["Id"].ToString());
                            fam = dt.Rows[i]["Familiyasi"].ToString();
                            ism = dt.Rows[i]["Ismi"].ToString();
                            shar = dt.Rows[i]["Sharfi"].ToString();
                            Bemor bemor = new Bemor(id, fam, ism, shar);
                            this.Hide();
                            bemor.ShowDialog();
                            this.Show();
                            break;
                        }
                    }

                }
                else if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    bolim bolim = new bolim();
                    this.Hide();
                    bolim.ShowDialog();
                    this.Show();
                }
                else if (textBox1.Text=="abs" && textBox2.Text=="abs")
                {
                    Analizlar analizlar = new Analizlar();
                    this.Hide();
                    analizlar.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bunday foydalanuvchi mavjud emas !!! ", "Ädmin");
                    textBox1.Text = textBox2.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xatolik yuz berdi "+ex.Message.ToString(), "Admin");
            }
        }
        private void royxatdanOtishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Form1 form1 = new Form1();
            form1.Hide();
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
