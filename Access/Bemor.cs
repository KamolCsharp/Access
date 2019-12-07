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
    public partial class Bemor : Form
    {
        private int Id = 0;
        private int n = 0;
        private int re, ce;
        private string sel_id="";
        private string[,] sel_id1;
        string anketa = "select * from Anketa";
        string anketa_qoshish = "INSERT INTO from Anketa(Familiyasi," +
            "Ismi,Sharfi,Tugulgan_sana,Adress,Tel_raqam," +
            "Paspor" +
            "t_Seriyasi,Kelgan_sana,Shikoyati,Xulosa) VALUES(";
        string registratura_del = "DELETE FROM from Registratura WHERE id = ";
        public Bemor(int Id,string fam,string ismi,string sharfi)
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
            //dataGridView1.ReadOnly = true;
            this.Id = Id;
            label1.Text = fam + "  " + ismi + "  " + sharfi;
        }

        private void show_1()
        {
            string s = "SELECT Registratura.Id,Anketa.Familiyasi, Anketa.Ismi, Anketa.Sharfi," +
                 " Anketa.Tugulgan_sana, Anketa.Adress, Anketa.Tel_raqam, Anketa.Pasport_Seriyasi, " +
                 "Registratura.Sana, Registratura.Shikoyati, Registratura.Tolov, Registratura.Xulosa" +
                 " FROM Anketa inner join Registratura ON Anketa.Id = Registratura.Anketa_Id where Registratura.xodim_Id = " + Id;
            DataTable dt = DB.db.Query(s);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 170;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 130;
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[9].Width = 130;
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].Width = 300;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registratura = " UPDATE Registratura SET";
            registratura += " Xulosa = '" + dataGridView1.Rows[re].Cells[11].Value.ToString() + "' ";
            registratura += " where id = " + n;
            if ((DB.db.SetCommand(registratura)) == 1)
            {
                MessageBox.Show("Saqlandi!");
            }
            else
            {
                MessageBox.Show("Xatolik!");
            }
            this.show_qayta();
        }

        private void show_qayta()
        {
            string sb = "SELECT Registratura.Id,Anketa.Familiyasi," +
                " Anketa.Ismi, Anketa.Sharfi,Anketa.Tugulgan_sana, Anketa.Adress," +
                " Anketa.Tel_raqam, Anketa.Pasport_Seriyasi, Registratura.Sana, " +
                "Registratura.Shikoyati, Registratura.Tolov, Registratura.Xulosa FROM Anketa " +
                "inner join Registratura ON Anketa.Id = Registratura.Anketa_Id where " +
                "Registratura.xodim_Id = " + Id + " and Registratura.Xulosa is null";
            DataTable dt = DB.db.Query(sb);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 170;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 130;
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[9].Width = 130;
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].Width = 300;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            n = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            re = e.RowIndex;
        }

        private void Bemor_Load(object sender, EventArgs e)
        {
            this.show_1();
            dataGridView1.AutoResizeRows();
        }
    }
}
