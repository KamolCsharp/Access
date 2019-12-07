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
    public partial class Analizlar : Form
    {
        public Analizlar()
        {
            InitializeComponent();
        }

        private void Analizlar_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            string an = "select Anketa.Familiyasi, Anketa.Ismi, Anketa.Sharfi, Anketa.Tugulgan_sana, " +
               "Anketa.Tel_raqam, Registratura.Shikoyati, Analizlar.Nomi, Reg_analiz.Sana, Reg_analiz.Natija " +
        "from Anketa, Registratura, Analizlar, Reg_analiz where Anketa.Id = Registratura.Id and " +
        "Registratura.Id = Reg_analiz.Reg_Id and Analizlar.Id = Reg_analiz.Analiz_Id";
            DataTable dtX = DB.db.Query(an);
            dataGridView1.DataSource = dtX;
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 170;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 130;
            dataGridView1.Columns[8].Width = 300;
            for (int i = 0; i <= dtX.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }
    }
}
