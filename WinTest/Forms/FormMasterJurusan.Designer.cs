namespace WinTest
{
    partial class FormMasterJurusan
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
            this.label6 = new System.Windows.Forms.Label();
            this.CARI = new System.Windows.Forms.TextBox();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 254);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "Pencarian";
            // 
            // CARI
            // 
            this.CARI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CARI.Location = new System.Drawing.Point(80, 12);
            this.CARI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CARI.MaxLength = 9999;
            this.CARI.Name = "CARI";
            this.CARI.Size = new System.Drawing.Size(179, 23);
            this.CARI.TabIndex = 67;
            this.CARI.TextChanged += new System.EventHandler(this.CARI_TextChanged);
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTAMBAH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTAMBAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Location = new System.Drawing.Point(267, 12);
            this.btnTAMBAH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(110, 23);
            this.btnTAMBAH.TabIndex = 69;
            this.btnTAMBAH.Text = "Tambah";
            this.btnTAMBAH.UseVisualStyleBackColor = false;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // FormMasterJurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 307);
            this.Controls.Add(this.btnTAMBAH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CARI);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMasterJurusan";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CARI;
        private System.Windows.Forms.Button btnTAMBAH;
    }
}