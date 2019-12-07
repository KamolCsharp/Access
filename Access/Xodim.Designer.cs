namespace Access
{
    partial class Xodim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Familiyasi = new System.Windows.Forms.TextBox();
            this.Ismi = new System.Windows.Forms.TextBox();
            this.Sharfi = new System.Windows.Forms.TextBox();
            this.Pasport = new System.Windows.Forms.TextBox();
            this.Tel_raqam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tugulgan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ma\'lumotlarni o\'qish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Adress);
            this.groupBox1.Controls.Add(this.Familiyasi);
            this.groupBox1.Controls.Add(this.Ismi);
            this.groupBox1.Controls.Add(this.Sharfi);
            this.groupBox1.Controls.Add(this.Pasport);
            this.groupBox1.Controls.Add(this.Tel_raqam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tugulgan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xodimlar";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(141, 245);
            this.Adress.Multiline = true;
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(309, 106);
            this.Adress.TabIndex = 14;
            // 
            // Familiyasi
            // 
            this.Familiyasi.Location = new System.Drawing.Point(141, 35);
            this.Familiyasi.Name = "Familiyasi";
            this.Familiyasi.Size = new System.Drawing.Size(309, 29);
            this.Familiyasi.TabIndex = 13;
            // 
            // Ismi
            // 
            this.Ismi.Location = new System.Drawing.Point(141, 70);
            this.Ismi.Name = "Ismi";
            this.Ismi.Size = new System.Drawing.Size(309, 29);
            this.Ismi.TabIndex = 12;
            // 
            // Sharfi
            // 
            this.Sharfi.Location = new System.Drawing.Point(141, 105);
            this.Sharfi.Name = "Sharfi";
            this.Sharfi.Size = new System.Drawing.Size(309, 29);
            this.Sharfi.TabIndex = 11;
            // 
            // Pasport
            // 
            this.Pasport.Location = new System.Drawing.Point(140, 210);
            this.Pasport.MaxLength = 10;
            this.Pasport.Name = "Pasport";
            this.Pasport.Size = new System.Drawing.Size(309, 29);
            this.Pasport.TabIndex = 10;
            // 
            // Tel_raqam
            // 
            this.Tel_raqam.Location = new System.Drawing.Point(141, 175);
            this.Tel_raqam.MaxLength = 14;
            this.Tel_raqam.Name = "Tel_raqam";
            this.Tel_raqam.Size = new System.Drawing.Size(309, 29);
            this.Tel_raqam.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 245);
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
            // Tugulgan
            // 
            this.Tugulgan.Location = new System.Drawing.Point(141, 140);
            this.Tugulgan.Name = "Tugulgan";
            this.Tugulgan.Size = new System.Drawing.Size(309, 29);
            this.Tugulgan.TabIndex = 1;
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
            // Bemor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1228, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Bemor";
            this.Text = "Bemor";
            this.Load += new System.EventHandler(this.Bemor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox Familiyasi;
        private System.Windows.Forms.TextBox Ismi;
        private System.Windows.Forms.TextBox Sharfi;
        private System.Windows.Forms.TextBox Pasport;
        private System.Windows.Forms.TextBox Tel_raqam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tugulgan;
        private System.Windows.Forms.Label label1;
    }
}