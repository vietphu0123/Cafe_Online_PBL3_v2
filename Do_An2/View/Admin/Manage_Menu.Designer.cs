namespace Do_An2
{
    partial class QuanLyMenu
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
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnDelC = new System.Windows.Forms.Button();
            this.btnAddD = new System.Windows.Forms.Button();
            this.btnDelD = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 185);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddC
            // 
            this.btnAddC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddC.Location = new System.Drawing.Point(49, 247);
            this.btnAddC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(112, 58);
            this.btnAddC.TabIndex = 2;
            this.btnAddC.Text = "Thêm loại đồ uống";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnDelC
            // 
            this.btnDelC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelC.Location = new System.Drawing.Point(232, 247);
            this.btnDelC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelC.Name = "btnDelC";
            this.btnDelC.Size = new System.Drawing.Size(100, 58);
            this.btnDelC.TabIndex = 3;
            this.btnDelC.Text = "Xóa loại đồ uống";
            this.btnDelC.UseVisualStyleBackColor = true;
            this.btnDelC.Click += new System.EventHandler(this.btnDelC_Click);
            // 
            // btnAddD
            // 
            this.btnAddD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddD.Location = new System.Drawing.Point(19, 247);
            this.btnAddD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddD.Name = "btnAddD";
            this.btnAddD.Size = new System.Drawing.Size(131, 58);
            this.btnAddD.TabIndex = 4;
            this.btnAddD.Text = "Thêm đồ uống";
            this.btnAddD.UseVisualStyleBackColor = true;
            this.btnAddD.Click += new System.EventHandler(this.btnAddD_Click);
            // 
            // btnDelD
            // 
            this.btnDelD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelD.Location = new System.Drawing.Point(209, 247);
            this.btnDelD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelD.Name = "btnDelD";
            this.btnDelD.Size = new System.Drawing.Size(127, 58);
            this.btnDelD.TabIndex = 5;
            this.btnDelD.Text = "Xóa đồ uống";
            this.btnDelD.UseVisualStyleBackColor = true;
            this.btnDelD.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 31);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(481, 185);
            this.dataGridView2.TabIndex = 6;
            // 
            // btnUpD
            // 
            this.btnUpD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpD.Location = new System.Drawing.Point(384, 247);
            this.btnUpD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpD.Name = "btnUpD";
            this.btnUpD.Size = new System.Drawing.Size(116, 58);
            this.btnUpD.TabIndex = 7;
            this.btnUpD.Text = "Cập nhật";
            this.btnUpD.UseVisualStyleBackColor = true;
            this.btnUpD.Click += new System.EventHandler(this.btnUpD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(212)))), ((int)(((byte)(29)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAddC);
            this.groupBox1.Controls.Add(this.btnDelC);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(54, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 336);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(212)))), ((int)(((byte)(29)))));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnAddD);
            this.groupBox2.Controls.Add(this.btnUpD);
            this.groupBox2.Controls.Add(this.btnDelD);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(430, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 336);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(212)))), ((int)(((byte)(29)))));
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(178, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 431);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản Lý Menu";
            // 
            // QuanLyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(124)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1229, 554);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyMenu";
            this.Text = "Quản Lý Menu";
            this.Load += new System.EventHandler(this.QuanLyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnDelC;
        private System.Windows.Forms.Button btnAddD;
        private System.Windows.Forms.Button btnDelD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

