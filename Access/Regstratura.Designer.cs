namespace Access
{
    partial class Regstratura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kelgan_sana = new System.Windows.Forms.DateTimePicker();
            this.Pasport = new System.Windows.Forms.MaskedTextBox();
            this.Tel_raqam = new System.Windows.Forms.MaskedTextBox();
            this.Tugulgan = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tolov = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.xodimID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.shikoyati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Familiyasi = new System.Windows.Forms.TextBox();
            this.Ismi = new System.Windows.Forms.TextBox();
            this.Sharfi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Ozgartirish = new System.Windows.Forms.Button();
            this.Qidirish = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.kelgan_sana);
            this.groupBox1.Controls.Add(this.Pasport);
            this.groupBox1.Controls.Add(this.Tel_raqam);
            this.groupBox1.Controls.Add(this.Tugulgan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tolov);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.xodimID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.shikoyati);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Adress);
            this.groupBox1.Controls.Add(this.Familiyasi);
            this.groupBox1.Controls.Add(this.Ismi);
            this.groupBox1.Controls.Add(this.Sharfi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registiratura";
            // 
            // kelgan_sana
            // 
            this.kelgan_sana.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kelgan_sana.Location = new System.Drawing.Point(140, 282);
            this.kelgan_sana.Name = "kelgan_sana";
            this.kelgan_sana.Size = new System.Drawing.Size(221, 29);
            this.kelgan_sana.TabIndex = 60;
            // 
            // Pasport
            // 
            this.Pasport.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pasport.Location = new System.Drawing.Point(140, 207);
            this.Pasport.Mask = "AA ― 0000000";
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(221, 29);
            this.Pasport.TabIndex = 59;
            // 
            // Tel_raqam
            // 
            this.Tel_raqam.Location = new System.Drawing.Point(141, 172);
            this.Tel_raqam.Mask = "( 99 ) 000 0000";
            this.Tel_raqam.Name = "Tel_raqam";
            this.Tel_raqam.Size = new System.Drawing.Size(220, 29);
            this.Tel_raqam.TabIndex = 24;
            // 
            // Tugulgan
            // 
            this.Tugulgan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tugulgan.Location = new System.Drawing.Point(140, 137);
            this.Tugulgan.Name = "Tugulgan";
            this.Tugulgan.Size = new System.Drawing.Size(221, 29);
            this.Tugulgan.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "To\'lov";
            // 
            // tolov
            // 
            this.tolov.Location = new System.Drawing.Point(140, 319);
            this.tolov.MaxLength = 10;
            this.tolov.Name = "tolov";
            this.tolov.Size = new System.Drawing.Size(221, 29);
            this.tolov.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kelgan sana";
            // 
            // xodimID
            // 
            this.xodimID.FormattingEnabled = true;
            this.xodimID.Location = new System.Drawing.Point(141, 245);
            this.xodimID.Name = "xodimID";
            this.xodimID.Size = new System.Drawing.Size(220, 31);
            this.xodimID.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Xodim";
            // 
            // shikoyati
            // 
            this.shikoyati.Location = new System.Drawing.Point(141, 471);
            this.shikoyati.Multiline = true;
            this.shikoyati.Name = "shikoyati";
            this.shikoyati.Size = new System.Drawing.Size(220, 106);
            this.shikoyati.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Shikoyati";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(141, 357);
            this.Adress.Multiline = true;
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(220, 106);
            this.Adress.TabIndex = 14;
            // 
            // Familiyasi
            // 
            this.Familiyasi.Location = new System.Drawing.Point(140, 32);
            this.Familiyasi.Name = "Familiyasi";
            this.Familiyasi.Size = new System.Drawing.Size(221, 29);
            this.Familiyasi.TabIndex = 13;
            // 
            // Ismi
            // 
            this.Ismi.Location = new System.Drawing.Point(141, 70);
            this.Ismi.Name = "Ismi";
            this.Ismi.Size = new System.Drawing.Size(220, 29);
            this.Ismi.TabIndex = 12;
            // 
            // Sharfi
            // 
            this.Sharfi.Location = new System.Drawing.Point(141, 105);
            this.Sharfi.Name = "Sharfi";
            this.Sharfi.Size = new System.Drawing.Size(220, 29);
            this.Sharfi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pasport seryasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tug\'ulgan Sana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sharfi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tel raqami";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ismi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Familiyasi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(928, 583);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 604);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kiritish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ozgartirish
            // 
            this.Ozgartirish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ozgartirish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ozgartirish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ozgartirish.Location = new System.Drawing.Point(170, 603);
            this.Ozgartirish.Name = "Ozgartirish";
            this.Ozgartirish.Size = new System.Drawing.Size(134, 38);
            this.Ozgartirish.TabIndex = 3;
            this.Ozgartirish.Text = "O\'zgartirish";
            this.Ozgartirish.UseVisualStyleBackColor = false;
            this.Ozgartirish.Click += new System.EventHandler(this.Ozgartirish_Click);
            // 
            // Qidirish
            // 
            this.Qidirish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Qidirish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Qidirish.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qidirish.Location = new System.Drawing.Point(334, 603);
            this.Qidirish.Name = "Qidirish";
            this.Qidirish.Size = new System.Drawing.Size(134, 38);
            this.Qidirish.TabIndex = 4;
            this.Qidirish.Text = "Qidirish";
            this.Qidirish.UseVisualStyleBackColor = false;
            this.Qidirish.Click += new System.EventHandler(this.Qidirish_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(499, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Orqaga";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Regstratura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1340, 723);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Qidirish);
            this.Controls.Add(this.Ozgartirish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Regstratura";
            this.Text = "Regstratura";
            this.Load += new System.EventHandler(this.Regstratura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox Familiyasi;
        private System.Windows.Forms.TextBox Ismi;
        private System.Windows.Forms.TextBox Sharfi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Ozgartirish;
        private System.Windows.Forms.TextBox shikoyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Qidirish;
        private System.Windows.Forms.ComboBox xodimID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tolov;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker kelgan_sana;
        private System.Windows.Forms.MaskedTextBox Pasport;
        private System.Windows.Forms.MaskedTextBox Tel_raqam;
        private System.Windows.Forms.DateTimePicker Tugulgan;
    }
}