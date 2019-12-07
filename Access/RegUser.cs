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
    public partial class RegUser : Form
    {
        public RegUser()
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
        List<string> password = new List<string>(1);
        List<string> login = new List<string>(1);
        private void button1_Click(object sender, EventArgs e)
        {
            if (Ismi.Text!="" && Familiyasi.Text!="" && Sharfi.Text!="" 
                && Pasport.Text!="" && Tel_raqami.Text!=""
                && Parol.Text!="" && Login.Text!="" )
            {
                if (!password.Contains(Parol.Text) && !login.Contains(Login.Text))
                {
                    string sql = " INSERT INTO Xodim(Ismi,Familiyasi, Sharfi," +
                    "Lavozim_Id, Xona_raqami,Pasport_Seryasi,Mutaxasisligi," +
                    "Tel_raqami,Ish_staji,Bolim_id,Maoshi,Login,Parol)" +
                " VALUES(";
                    sql += "'" + Ismi.Text + "', ";
                    sql += "'" + Familiyasi.Text + "', ";
                    sql += "'" + Sharfi.Text + "', ";
                    sql += Lavozim.SelectedIndex + 1 + ",";
                    sql += Xona_raqam.Text + ", ";
                    sql += "'" + Pasport.Text + "', ";
                    sql += "'" + Mutaxasisligi.Text + "', ";
                    sql += "'" + Tel_raqami.Text + "', ";
                    sql += "'" + Ish_staji.Text + "', ";

                    sql += Bolim_id.SelectedIndex + 1 + ", ";

                    sql += Maoshi.Text + ", ";
                    sql += "'" + Login.Text + "', ";
                    sql += "'" + Parol.Text + "') ";
                    if ((DB.db.SetCommand(sql)) == 1)
                    {
                        MessageBox.Show("Saqlandi!", "Admin");
                        Ismi.Text = Familiyasi.Text = Sharfi.Text = Pasport.Text =
                            Tel_raqami.Text = Login.Text = Parol.Text = Lavozim.Text =
                            Xona_raqam.Text = Mutaxasisligi.Text = Bolim_id.Text = Maoshi.Text = Ish_staji.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xatolik !!!", "Admin");
                    }
                }
                else {
                    MessageBox.Show("Boshqa login yoki parol kiriting avval ro'yxatdan o'tgan !!!", "Admin");
                    Parol.Text = "";
                    Login.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ma'lumotlarni kiriting !!!", "Admin");
            }
        }

        private void Parol_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void RegUser_Load(object sender, EventArgs e)
        {
            string sL = "select * from Lavozim order by Id";
            DataTable dt = DB.db.Query(sL);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Lavozim.Items.Add(dt.Rows[i]["Nomi"].ToString());
            }
            string sB = "select * from Bolim order by Id";
            DataTable dtB = DB.db.Query(sB);
            for (int i = 0; i < dtB.Rows.Count; i++)
            {
                Bolim_id.Items.Add(dtB.Rows[i]["Nomi"].ToString());
            }
            string sX = "select * from Xodim order by Id";
            DataTable dtX = DB.db.Query(sX);
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                login.Add(dtX.Rows[i]["Login"].ToString());
                password.Add(dtX.Rows[i]["Parol"].ToString());
            }
        }

        private void Lavozim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
