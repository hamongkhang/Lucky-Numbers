namespace TimerGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.table = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.text106 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.text105 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.text104 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.text103 = new System.Windows.Forms.TextBox();
            this.text107 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.text102 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.text101 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text100 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.text108 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 62);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "BẤM SỐ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.table);
            this.tabControl1.Location = new System.Drawing.Point(12, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 381);
            this.tabControl1.TabIndex = 1;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Maroon;
            this.table.Controls.Add(this.textBox9);
            this.table.Controls.Add(this.tableLayoutPanel1);
            this.table.Controls.Add(this.text108);
            this.table.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.Location = new System.Drawing.Point(4, 22);
            this.table.Name = "table";
            this.table.Padding = new System.Windows.Forms.Padding(3);
            this.table.Size = new System.Drawing.Size(888, 355);
            this.table.TabIndex = 0;
            this.table.Text = "KẾT QUẢ";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Red;
            this.textBox9.Location = new System.Drawing.Point(8, 275);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(319, 72);
            this.textBox9.TabIndex = 1;
            this.textBox9.Text = "\r\nGIẢI ĐẶC BIỆT";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.91403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.08597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.Controls.Add(this.text106, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox17, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.text105, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.text104, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.text103, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.text107, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.text102, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.text101, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.text2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.text100, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox13, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 271);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // text106
            // 
            this.text106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text106.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text106.Location = new System.Drawing.Point(614, 131);
            this.text106.Multiline = true;
            this.text106.Name = "text106";
            this.text106.Size = new System.Drawing.Size(262, 63);
            this.text106.TabIndex = 15;
            this.text106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox17.Location = new System.Drawing.Point(444, 131);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(162, 63);
            this.textBox17.TabIndex = 14;
            this.textBox17.Text = "GIẢI BẢY";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text105
            // 
            this.text105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text105.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text105.Location = new System.Drawing.Point(614, 65);
            this.text105.Multiline = true;
            this.text105.Name = "text105";
            this.text105.Size = new System.Drawing.Size(262, 58);
            this.text105.TabIndex = 13;
            this.text105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox15.Location = new System.Drawing.Point(444, 65);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(162, 58);
            this.textBox15.TabIndex = 12;
            this.textBox15.Text = "GIẢI SÁU";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text104
            // 
            this.text104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text104.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text104.Location = new System.Drawing.Point(614, 5);
            this.text104.Multiline = true;
            this.text104.Name = "text104";
            this.text104.Size = new System.Drawing.Size(262, 52);
            this.text104.TabIndex = 11;
            this.text104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox12.Location = new System.Drawing.Point(5, 202);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(163, 64);
            this.textBox12.TabIndex = 9;
            this.textBox12.Text = "GIẢI BỐN";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text103
            // 
            this.text103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text103.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text103.Location = new System.Drawing.Point(176, 202);
            this.text103.Multiline = true;
            this.text103.Name = "text103";
            this.text103.Size = new System.Drawing.Size(260, 64);
            this.text103.TabIndex = 8;
            this.text103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text107
            // 
            this.text107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text107.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text107.Location = new System.Drawing.Point(614, 202);
            this.text107.Multiline = true;
            this.text107.Name = "text107";
            this.text107.Size = new System.Drawing.Size(262, 64);
            this.text107.TabIndex = 7;
            this.text107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox7.Location = new System.Drawing.Point(444, 202);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 64);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "GIẢI TÁM";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text102
            // 
            this.text102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text102.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text102.Location = new System.Drawing.Point(176, 131);
            this.text102.Multiline = true;
            this.text102.Name = "text102";
            this.text102.Size = new System.Drawing.Size(260, 63);
            this.text102.TabIndex = 5;
            this.text102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox5.Location = new System.Drawing.Point(5, 131);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 63);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "GIẢI BA";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text101
            // 
            this.text101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text101.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text101.Location = new System.Drawing.Point(176, 65);
            this.text101.Multiline = true;
            this.text101.Name = "text101";
            this.text101.Size = new System.Drawing.Size(260, 58);
            this.text101.TabIndex = 3;
            this.text101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.text2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(5, 65);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(163, 58);
            this.text2.TabIndex = 2;
            this.text2.Text = "GIẢI NHÌ";
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text100
            // 
            this.text100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text100.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text100.Location = new System.Drawing.Point(176, 5);
            this.text100.Multiline = true;
            this.text100.Name = "text100";
            this.text100.Size = new System.Drawing.Size(260, 52);
            this.text100.TabIndex = 2;
            this.text100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.text1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(5, 5);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(163, 52);
            this.text1.TabIndex = 2;
            this.text1.Text = "GIẢI NHẤT";
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox13.Location = new System.Drawing.Point(444, 5);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(162, 52);
            this.textBox13.TabIndex = 10;
            this.textBox13.Text = "GIẢI NĂM";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text108
            // 
            this.text108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text108.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text108.Location = new System.Drawing.Point(333, 275);
            this.text108.Multiline = true;
            this.text108.Name = "text108";
            this.text108.Size = new System.Drawing.Size(549, 74);
            this.text108.TabIndex = 1;
            this.text108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Hà Mộng Khang";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Aqua;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(764, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Xổ số Bình Định";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimerGUI.Properties.Resources.Free_vector_000115_qua_bong_xo_so_dong_tien_vang_bay_va_dai_bang_do_quang_cao_kinh_doanh_co_bac;
            this.ClientSize = new System.Drawing.Size(920, 510);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage table;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox text107;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox text102;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox text101;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text100;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text108;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox text103;
        private System.Windows.Forms.TextBox text106;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox text105;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox text104;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
