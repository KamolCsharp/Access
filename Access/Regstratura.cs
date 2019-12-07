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
    public partial class Regstratura : Form
    {
        private string sel_id;
        private int a = 0;
        string s = "SELECT Anketa.Id, Anketa.Familiyasi, Anketa.Ismi, Anketa.Sharfi," +
             " Anketa.Tugulgan_sana, Anketa.Adress, Anketa.Tel_raqam, Anketa.Pasport_Seriyasi, " +
             "Registratura.Sana, Registratura.Shikoyati, Registratura.Tolov" +
             " FROM Anketa inner join Registratura ON Anketa.Id = Registratura.Anketa_Id";
        DataTable dt;

        public Regstratura()
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
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
        }
        public void ShowAll()
        {
            dataGridView1.Columns.Clear();
            dt = DB.db.Query(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[9].Width = 300;
            dataGridView1.Columns[10].Width = 130;
            dataGridView1.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns.Add("Xulosa", "Xulosa");
            dataGridView1.Columns[11].Width = 300;
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            //dataGridView1.Columns["Tugulgan_sana"].Width = 80;
            //dataGridView1.Columns["Tugulgan_sana"].HeaderText = "Sana";
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();

        }
        private void Regstratura_Load(object sender, EventArgs e)
        {
            string sX = "select * from Xodim order by Id";
            DataTable dtX = DB.db.Query(sX);
            for (int i = 0; i < dtX.Rows.Count; i++)
            {
                xodimID.Items.Add(dtX.Rows[i]["Familiyasi"].ToString() + "  " + dtX.Rows[i]["Ismi"].ToString() + "  " + dtX.Rows[i]["Sharfi"].ToString());
            }
            this.ShowAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlAnketa = " INSERT INTO Anketa(Familiyasi,Ismi, Sharfi," +
                    "Tugulgan_sana ,Adress,Tel_raqam, Pasport_Seriyasi)" +
                    " VALUES(";
            sqlAnketa += "'" + Familiyasi.Text + "', ";
            sqlAnketa += "'" + Ismi.Text + "', ";
            sqlAnketa += "'" + Sharfi.Text + "', ";
            sqlAnketa += "'" + Tugulgan.Text.ToString() + "', ";
            sqlAnketa += "'" + Adress.Text + "', ";
            sqlAnketa += "'" + Tel_raqam.Text.ToString() + "', ";
            sqlAnketa += "'" + Pasport.Text.ToString() + "') ";
            if ((DB.db.SetCommand(sqlAnketa)) == 1)
            {
                MessageBox.Show("Anketa saqlandi !!! ", "Admin");
            }
            else
            {
                MessageBox.Show("Anketa saqlashda xatolik !!! ", "Admin");
            }
            string anketa = "select top 1 id from Anketa order by id desc";
            DataTable anketa_dt = DB.db.Query(anketa);
            string aid = anketa_dt.Rows[0][0].ToString();
            string sqlRegistratura = " INSERT INTO Registratura(Anketa_Id,Xodim_Id," +
                "Sana,Shikoyati,Tolov) VALUES(";
            sqlRegistratura += Convert.ToInt32(aid) + ",";

            sqlRegistratura += +xodimID.SelectedIndex + 1 + ",";
            sqlRegistratura += "'" + kelgan_sana.Text.ToString() + "',";
            sqlRegistratura += "'" + shikoyati.Text + "',";
            sqlRegistratura += Convert.ToInt32(tolov.Text) + ")";


            if (DB.db.SetCommand(sqlRegistratura) == 1)
            {
                MessageBox.Show("Saqlandi!", "Admin");
                Familiyasi.Text = Ismi.Text = Sharfi.Text = Tugulgan.Text = Adress.Text = Tel_raqam.Text = Pasport.Text = "";
                xodimID.Text = kelgan_sana.Text = shikoyati.Text = tolov.Text = "";
            }
            else
            {
                MessageBox.Show("Xatolik !!!", "Admin");
            }
            this.ShowAll();
        }

        private void ShowAll_1()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[9].Width = 300;
            dataGridView1.Columns[10].Width = 130;
            dataGridView1.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[11].Width = 300;

            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
         
            dataGridView1.Font = new Font("Calibri", 16);
        }

        private void Ozgartirish_Click(object sender, EventArgs e)
        {
           
            string sqlAnketa = " UPDATE Anketa SET ";
            sqlAnketa += " Familiyasi = '" + Familiyasi.Text + "', ";
            sqlAnketa += " Ismi = '" + Ismi.Text + "', ";
            sqlAnketa += " Sharfi = '" + Sharfi.Text + "', ";
            sqlAnketa += " Tugulgan_sana = '" + Tugulgan.Text + "', ";
            sqlAnketa += " Adress = '" + Adress.Text + "', ";
            sqlAnketa += " Tel_raqam = '" + Tel_raqam.Text + "', ";
            sqlAnketa += " Pasport_Seriyasi = '" + Pasport.Text + "' ";
            sqlAnketa += " where id = " + sel_id;
            if ((DB.db.SetCommand(sqlAnketa)) == 1)
            {
                MessageBox.Show("Saqlandi!");
                Familiyasi.Text = Ismi.Text = Sharfi.Text = Tugulgan.Text = Adress.Text = Tel_raqam.Text = Pasport.Text = "";
            }
            else
            {
                MessageBox.Show("Xatolik!");
            }

            this.ShowAll();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            sel_id = a;
            Familiyasi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Ismi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Sharfi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Tugulgan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Adress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Tel_raqam.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Pasport.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Qidirish_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Pasport.Text);
            string zapros = "select * from Anketa where 1 = 1 ";
            if (!String.IsNullOrWhiteSpace(Familiyasi.Text))
                zapros += " and Familiyasi = '" + Familiyasi.Text + "'";
            if (!String.IsNullOrWhiteSpace(Ismi.Text))
                zapros += " and Ismi = '" + Ismi.Text + "'";
            if (!String.IsNullOrWhiteSpace(Sharfi.Text))
                zapros += " and Sharfi = '" + Sharfi.Text + "'";
            //if (!String.IsNullOrWhiteSpace(Tugulgan.Text))
            //    zapros += " Tugulgan_sana = '" + Tugulgan.Text + "'";
            //if (!String.IsNullOrWhiteSpace(Pasport.Text))
            //    zapros += " Pasport_Seriyasi = '" + Pasport.Text + "'";
            DataTable dt_zapros = DB.db.Query(zapros);

            ShowAll_zapros(dt_zapros);
        }

        private void ShowAll_zapros(DataTable dt_zapros)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt_zapros;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            for (int i = 0; i <= dt_zapros.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            //dataGridView1.Columns["Tugulgan_sana"].Width = 80;
            //dataGridView1.Columns["Tugulgan_sana"].HeaderText = "Sana";
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowAll();
        }
    }
}
