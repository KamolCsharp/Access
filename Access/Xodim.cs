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
    public partial class Xodim : Form
    {
        private string sel_id;

        public Xodim()
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowsDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;

        }

        private void Bemor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            DataTable dt;
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
