namespace WinTest
{
    partial class FormAddMahasiswa
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
            this.JURUSAN = new System.Windows.Forms.ComboBox();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ALAMAT = new System.Windows.Forms.TextBox();
            this.NAMA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // JURUSAN
            // 
            this.JURUSAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JURUSAN.FormattingEnabled = true;
            this.JURUSAN.Location = new System.Drawing.Point(164, 99);
            this.JURUSAN.Name = "JURUSAN";
            this.JURUSAN.Size = new System.Drawing.Size(342, 23);
            this.JURUSAN.TabIndex = 79;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUPDATE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(164, 128);
            this.btnUPDATE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(110, 34);
            this.btnUPDATE.TabIndex = 77;
            this.btnUPDATE.Text = "Simpan";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHAPUS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHAPUS.Location = new System.Drawing.Point(280, 128);
            this.btnHAPUS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(110, 34);
            this.btnHAPUS.TabIndex = 78;
            this.btnHAPUS.Text = "Hapus";
            this.btnHAPUS.UseVisualStyleBackColor = false;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "Id Mahasiswa";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(164, 12);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID.MaxLength = 9999;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(419, 23);
            this.ID.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Jurusan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // ALAMAT
            // 
            this.ALAMAT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ALAMAT.Location = new System.Drawing.Point(164, 70);
            this.ALAMAT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ALAMAT.MaxLength = 100;
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(419, 23);
            this.ALAMAT.TabIndex = 71;
            // 
            // NAMA
            // 
            this.NAMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NAMA.Location = new System.Drawing.Point(164, 41);
            this.NAMA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NAMA.MaxLength = 100;
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(419, 23);
            this.NAMA.TabIndex = 70;
            // 
            // FormAddMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 182);
            this.Controls.Add(this.JURUSAN);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.NAMA);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAddMahasiswa";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormAddMahasiswa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox JURUSAN;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ALAMAT;
        private System.Windows.Forms.TextBox NAMA;
    }
}