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
    public partial class bolim : Form
    {
        private string combox_select = "";
        string sA,sR, sX,sL,sB;
        string sA_I,sL_I,sB_I;
        string sA_D,sL_D,sR_D,sX_D,sB_D;
        string sA_U,sL_U,sB_U,sX_U;
        int D_Id;
        public bolim()
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
            this.Boshlash();
        //  dataGridView1.ReadOnly = true;
        }

        private void bolim_Load(object sender, EventArgs e)
        {
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (google.Checked)
            {
                if (tanlash == 3)
                {
                    string select = " select Nomi, MAX(Narxi) as Nomi from Analizlar ";
                    DataTable dtX = DB.db.Query(select);
                    dataGridView1.DataSource = dtX;
                }
                else if (tanlash==2)
                {
                    this.Boshlash();

                    string  select1 = " SELECT Xodim.Id, Xodim.Familiyasi, Xodim.Ismi, Xodim.Sharfi," +
                    " Xodim.Pasport_seryasi, Xodim.Tel_raqami, Lavozim.Nomi," +
                    " Xodim.Xona_raqami, Xodim.Maoshi, Xodim.Login, Xodim.Parol "
                    + "FROM Xodim, Lavozim where Xodim.Lavozim_Id= ";
                    select1 += Lavozim.SelectedIndex+1+" and Lavozim.Id = "+ Convert.ToInt32(Lavozim.SelectedIndex + 1);
                    if (!String.IsNullOrWhiteSpace(textBox2.Text))
                        select1 += " and Familiyasi = '" + textBox2.Text + "'";
                    if (!String.IsNullOrWhiteSpace(textBox4.Text))
                        select1 += " and Ismi = '" + textBox4.Text + "'";

                    DataTable dtX = DB.db.Query(select1);
                    //MessageBox.Show(select1);

                    //this.select(select1);

                    dataGridView1.DataSource = dtX;
                }
            }
        }

        private void Boshlash()
        {
            google.Checked = false;
            textBox1.Visible = textBox2.Visible = textBox3.Visible = textBox4.Visible = textBox5.Visible = textBox6.Visible = textBox7.Visible = textBox8.Visible = false;
            label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = label9.Visible = false;
            sR = " SELECT Anketa.Id, Anketa.Familiyasi, Anketa.Ismi, " +
               "Anketa.Sharfi, Anketa.Tugulgan_sana, Anketa.Adress," +
               " Anketa.Tel_raqam, Anketa.Pasport_Seriyasi, Registratura.Id, " +
               "Registratura.Sana, Registratura.Shikoyati," +
                " Registratura.Tolov, Registratura.Xulosa" +
               " FROM Anketa inner join Registratura ON Anketa.Id = Registratura.Anketa_Id";
            ///////////////////////////////////////////////////////////////////////////////////
            sX = " SELECT Xodim.Id, Xodim.Familiyasi, Xodim.Ismi, Xodim.Sharfi," +
                    " Xodim.Pasport_seryasi, Xodim.Tel_raqami, Lavozim.Nomi, Bolim.Nomi," +
                    " Xodim.Xona_raqami, Xodim.Maoshi, Xodim.Login, Xodim.Parol "
                + "FROM Xodim, Lavozim, Bolim where Xodim.Lavozim_Id=Lavozim.Id and Xodim.Bolim_Id=Bolim.Id";
            /////////////////////////////////////////////////////////////////////////////////////////
            sA = "select * from Analizlar order by Id";
            sL = "select * from Lavozim order by Id";
            sB = "select * from Bolim order by Id";

            /////////////////////////////////////////////////////////////////////////////////

            sA_U = "UPDATE Analizlar SET ";
            sL_U = "UPDATE Lavozim SET ";
            sB_U = "UPDATE Bolim SET ";
            sX_U = "UPDATE Xodim SET ";

            ////////////////////////////////////////////////////////////
            sA_I = "INSERT INTO Analizlar(Nomi,Narxi) values(";
            sL_I = "INSERT INTO Lavozim(Nomi) values(";
            sB_I = "INSERT INTO Bolim(Nomi) values(";
            ////////////////////////////////////////////////////////////
            sA_D = "DELETE FROM Analizlar  WHERE Id = ";
            sL_D = "DELETE FROM Lavozim  WHERE Id = ";
            sB_D = "DELETE FROM Bolim  WHERE Id = ";
            sR_D = "DELETE FROM Registratura where Id = ";
            sX_D = "delete from Xodim where Id = ";
            dataGridView1.RowHeadersVisible = false;
        }

        private void A_L_Qoshish_Click(object sender, EventArgs e)
        {
            
            if (tanlash==3)
            {
                sA_I += "'" + textBox1.Text + "', ";
                sA_I += Convert.ToInt32(textBox2.Text) + ")";
                this.saqlash(sA_I,"Analizlar");
            }
            else if (tanlash==4)
            {
                sL_I += "'" + textBox1.Text + "')";
                this.saqlash(sL_I, "Lavozimlar");
            }
            else if (tanlash == 5)
            {
                sB_I += "'" + textBox1.Text + "')";
                this.saqlash(sB_I, "Bo'lim");
            }
        }

        private void saqlash(string save, string v)
        {
            if ((DB.db.SetCommand(save)) == 1)
            {
                MessageBox.Show(v+" saqlandi !!! ", "Admin");
                button1.PerformClick();
                textBox1.Text = textBox2.Text = "";
            }
            else
            {
                MessageBox.Show(v+" saqlashda xatolik !!! ", "Admin");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            D_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (ochirish.Checked)
            {
                if (tanlash==1)
                {
                    sR_D += D_Id;
                    this.Tozalash(sR_D);
                }
                else if (tanlash==2)
                {
                    sX_D += D_Id;
                    this.Tozalash(sX_D);
                }
                else if (tanlash==3)
                {
                    sA_D += D_Id;
                    this.Tozalash(sA_D);
                }
                else if (tanlash==4)
                {
                    sL_D += D_Id;
                    this.Tozalash(sL_D);
                }
                else if (tanlash == 5)
                {
                    sB_D += D_Id;
                    this.Tozalash(sB_D);
                }
                ochirish.Checked = false;
            }
            if (ozgartirish.Checked)
            {
                if (tanlash==2)
                {
                    sX_U += " Familiyasi = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "', ";
                    sX_U += " Ismi = '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', ";
                    sX_U += " Sharfi = '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "', ";
                    sX_U += " Xona_raqami = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value) + ", ";
                    sX_U += " Pasport_seryasi = '" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "', ";
                    sX_U += " Tel_raqami = '" + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() + "', ";
                    sX_U += " Maoshi = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value) + ", ";
                    sX_U += " Login = '" + dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString() + "', ";
                    sX_U += " Parol = '" + dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString() + "'  ";
                    sX_U += " where Id = " + D_Id;
                    MessageBox.Show(sX_U);
                    this.Uzgartirish(sX_U);
                }
                else if (tanlash==3)
                {
                    sA_U += " Nomi = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
                    sA_U += " Narxi = " + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value)+" ";
                    sA_U += " where Id = " + D_Id;
                    this.Uzgartirish(sA_U);
                   
                }
                else if (tanlash==4)
                {
                    sL_U += "Nomi = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ";
                    sL_U += " where Id = " + D_Id;
                    this.Uzgartirish(sL_U);
                }
                else if (tanlash == 5)
                {
                    sB_U += "Nomi = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ";
                    sB_U += " where Id = " + D_Id;
                    this.Uzgartirish(sB_U);
                }
                ozgartirish.Checked = false;
            }
        }

        private void Uzgartirish(string upd)
        {
            if ((DB.db.SetCommand(upd)) == 1)
            {
                MessageBox.Show("O'zgartirildi !!! ");
                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("Xatolik!");
            }
        }
        private void Tozalash(string del)
        {
            if ((DB.db.SetCommand(del)) == 1)
            {
                MessageBox.Show("O'chirib tashlandi !!!");
                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("O'chirishda Xatolik!");
            }
        }
        private int tanlash = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Boshlash();
            combox_select = Bolim_id.Text;
            if (combox_select == "Registratura")
            {
           
                label3.Visible=true;
                //textBox2.Visible = false;
                tanlash = 1;
                this.select(sR);
            }
            else if (combox_select == "Xodimlar")
            {
                string sL = "select * from Lavozim order by Id";
                DataTable dt = DB.db.Query(sL);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Lavozim.Items.Add(dt.Rows[i]["Nomi"].ToString());
                }
               textBox1.Visible = textBox2.Visible = false;
                label3.Visible = true;label3.Text = "Lavozim";
                label2.Visible=label5.Visible = true;label2.Text = "Fam ";
                textBox2.Visible =textBox4.Visible =true;label5.Text = "Ismi ";
                tanlash = 2;    
                this.select(sX);
            }
            else if (combox_select == "Analizlar")
            {
                label2.Visible = label3.Visible = true;
                label3.Text = "Nomi";
                label2.Text = "Narxi";
                textBox1.Visible = textBox2.Visible = true;
                tanlash = 3;
                this.select(sA);
            }
            else if (combox_select== "Lavozim")
            {
                label3.Visible = textBox1.Visible = true;
                label3.Text = "Nomi";
                label2.Visible = false;textBox2.Visible = false;
                tanlash = 4;
                this.select(sL);
            }
            else if (combox_select== "Bo'limlar")
            {
                label3.Visible = textBox1.Visible = true;
                label3.Text = "Nomi";
                label2.Visible = false; textBox2.Visible = false;
                tanlash = 5;
                this.select(sB);
            }
        }

        private void select(string sel)
        {
                DataTable dtX = DB.db.Query(sel);
                dataGridView1.DataSource = dtX;
            if (tanlash==1) { this.show_reg(dtX);}
            if (tanlash==2) { this.show_xodim(dtX);}
            if (tanlash==3) { this.show_Ana(dtX);}
            if (tanlash==4) { this.show_L(dtX);}
            if (tanlash==5) { this.show_L(dtX);}
        }

        private void show_L(DataTable dtL)
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 500;
            for (int i = 0; i <= dtL.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }

        private void show_Ana(DataTable dtA)
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 500;
            dataGridView1.Columns[2].Width = 180;
            for (int i = 0; i <= dtA.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }

        private void show_xodim(DataTable dtX)
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 180;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[9].Width = 150;
            dataGridView1.Columns[10].Width = 150;
            dataGridView1.Columns[11].Width = 150;
            for (int i = 0; i <= dtX.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }

        private void show_reg(DataTable a)
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Width = 170;
            dataGridView1.Columns[7].Width = 170;
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[9].Width = 130;
            dataGridView1.Columns[10].Width = 300;
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].Width = 300;
            dataGridView1.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            for (int i = 0; i <= a.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 30;
            }
            dataGridView1.Font = new Font("Calibri", 16);
            dataGridView1.AutoResizeRows();
        }
    } 
}
