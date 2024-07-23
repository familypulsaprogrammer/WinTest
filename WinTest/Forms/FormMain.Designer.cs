namespace WinTest
{
    partial class FormMain
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
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurusanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 403);
            this.dataGridView1.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 37);
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
            this.CARI.Location = new System.Drawing.Point(80, 34);
            this.CARI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CARI.MaxLength = 9999;
            this.CARI.Name = "CARI";
            this.CARI.Size = new System.Drawing.Size(512, 23);
            this.CARI.TabIndex = 67;
            this.CARI.TextChanged += new System.EventHandler(this.CARI_TextChanged);
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnREFRESH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnREFRESH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREFRESH.Location = new System.Drawing.Point(482, 63);
            this.btnREFRESH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(110, 23);
            this.btnREFRESH.TabIndex = 70;
            this.btnREFRESH.Text = "Refresh";
            this.btnREFRESH.UseVisualStyleBackColor = false;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTAMBAH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTAMBAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAMBAH.Location = new System.Drawing.Point(799, 34);
            this.btnTAMBAH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(110, 54);
            this.btnTAMBAH.TabIndex = 69;
            this.btnTAMBAH.Text = "Tambah";
            this.btnTAMBAH.UseVisualStyleBackColor = false;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jurusanToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // jurusanToolStripMenuItem
            // 
            this.jurusanToolStripMenuItem.Name = "jurusanToolStripMenuItem";
            this.jurusanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jurusanToolStripMenuItem.Text = "Jurusan";
            this.jurusanToolStripMenuItem.Click += new System.EventHandler(this.jurusanToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker1.TabIndex = 72;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(281, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Periode";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.btnTAMBAH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CARI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CARI;
        private System.Windows.Forms.Button btnREFRESH;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurusanToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
    }
}