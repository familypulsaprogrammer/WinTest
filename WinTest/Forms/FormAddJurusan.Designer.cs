namespace WinTest
{
    partial class FormAddJurusan
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
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NAMA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUPDATE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(164, 70);
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
            this.btnHAPUS.Location = new System.Drawing.Point(280, 70);
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
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "Id Jurusan";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nama Jurusan";
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
            // FormAddJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 119);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAMA);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddJurusan";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NAMA;
    }
}