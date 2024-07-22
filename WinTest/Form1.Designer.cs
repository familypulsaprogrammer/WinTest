namespace WinTest
{
    partial class Form1
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
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ALAMAT = new System.Windows.Forms.TextBox();
            this.NAMA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JURUSAN = new System.Windows.Forms.ComboBox();
            this.btnREFRESH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUPDATE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(285, 144);
            this.btnUPDATE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(110, 34);
            this.btnUPDATE.TabIndex = 62;
            this.btnUPDATE.Text = "Update";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHAPUS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Location = new System.Drawing.Point(401, 144);
            this.btnHAPUS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(110, 34);
            this.btnHAPUS.TabIndex = 63;
            this.btnHAPUS.Text = "Hapus";
            this.btnHAPUS.UseVisualStyleBackColor = false;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTAMBAH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTAMBAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Location = new System.Drawing.Point(169, 144);
            this.btnTAMBAH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(110, 34);
            this.btnTAMBAH.TabIndex = 60;
            this.btnTAMBAH.Text = "Tambah";
            this.btnTAMBAH.UseVisualStyleBackColor = false;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Id Mahasiswa";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.Location = new System.Drawing.Point(169, 25);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID.MaxLength = 9999;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(459, 23);
            this.ID.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Jurusan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // ALAMAT
            // 
            this.ALAMAT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ALAMAT.Location = new System.Drawing.Point(169, 83);
            this.ALAMAT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ALAMAT.MaxLength = 100;
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(459, 23);
            this.ALAMAT.TabIndex = 54;
            // 
            // NAMA
            // 
            this.NAMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NAMA.Location = new System.Drawing.Point(169, 54);
            this.NAMA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NAMA.MaxLength = 100;
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(459, 23);
            this.NAMA.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 299);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(634, 321);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Mahasiswa";
            // 
            // JURUSAN
            // 
            this.JURUSAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JURUSAN.FormattingEnabled = true;
            this.JURUSAN.Items.AddRange(new object[] {
            "Teknik Mesin",
            "Teknik Listrik",
            "Teknik Elektronika",
            "Teknik Informatika",
            "Teknik Komputer dan Jaringan"});
            this.JURUSAN.Location = new System.Drawing.Point(169, 112);
            this.JURUSAN.Name = "JURUSAN";
            this.JURUSAN.Size = new System.Drawing.Size(346, 23);
            this.JURUSAN.TabIndex = 67;
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnREFRESH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnREFRESH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREFRESH.Location = new System.Drawing.Point(517, 144);
            this.btnREFRESH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(110, 34);
            this.btnREFRESH.TabIndex = 68;
            this.btnREFRESH.Text = "Refresh";
            this.btnREFRESH.UseVisualStyleBackColor = false;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 530);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.JURUSAN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.btnTAMBAH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.NAMA);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ALAMAT;
        private System.Windows.Forms.TextBox NAMA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox JURUSAN;
        private System.Windows.Forms.Button btnREFRESH;
    }
}

