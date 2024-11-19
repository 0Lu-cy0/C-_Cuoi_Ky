namespace quanlynhanvien
{
    partial class FormSalary
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearcch = new System.Windows.Forms.Button();
            this.tbSalary = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbSalary.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH LƯƠNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbSalary);
            this.panel1.Controls.Add(this.btnSearcch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.ListSearch);
            this.panel1.Location = new System.Drawing.Point(1, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 542);
            this.panel1.TabIndex = 2;
            // 
            // ListSearch
            // 
            this.ListSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(111)))));
            this.ListSearch.ForeColor = System.Drawing.Color.White;
            this.ListSearch.FormattingEnabled = true;
            this.ListSearch.Items.AddRange(new object[] {
            "STT",
            "Mã nhân viên",
            "Tháng",
            "Ngày nghỉ",
            "Lương cơ bản",
            "Thưởng",
            "Lương ròng"});
            this.ListSearch.Location = new System.Drawing.Point(47, 18);
            this.ListSearch.Name = "ListSearch";
            this.ListSearch.Size = new System.Drawing.Size(138, 28);
            this.ListSearch.TabIndex = 2;
            this.ListSearch.Text = "Mã nhân viên";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(259, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(444, 26);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearcch
            // 
            this.btnSearcch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(111)))));
            this.btnSearcch.ForeColor = System.Drawing.Color.White;
            this.btnSearcch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearcch.Location = new System.Drawing.Point(769, 20);
            this.btnSearcch.Name = "btnSearcch";
            this.btnSearcch.Size = new System.Drawing.Size(124, 41);
            this.btnSearcch.TabIndex = 5;
            this.btnSearcch.Text = "Tìm kiếm";
            this.btnSearcch.UseVisualStyleBackColor = false;
            // 
            // tbSalary
            // 
            this.tbSalary.BackColor = System.Drawing.Color.White;
            this.tbSalary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbSalary.ColumnCount = 7;
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.48387F));
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.51613F));
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tbSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tbSalary.Controls.Add(this.label7, 6, 0);
            this.tbSalary.Controls.Add(this.label6, 5, 0);
            this.tbSalary.Controls.Add(this.label3, 2, 0);
            this.tbSalary.Controls.Add(this.label2, 0, 0);
            this.tbSalary.Controls.Add(this.label8, 1, 0);
            this.tbSalary.Controls.Add(this.label4, 3, 0);
            this.tbSalary.Controls.Add(this.label5, 4, 0);
            this.tbSalary.Location = new System.Drawing.Point(47, 85);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.RowCount = 2;
            this.tbSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.11321F));
            this.tbSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.8868F));
            this.tbSalary.Size = new System.Drawing.Size(846, 213);
            this.tbSalary.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(733, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lương ròng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(610, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thưởng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(478, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lương cơ bản";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(334, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nghỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(207, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "STT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(76, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nhân viên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(126)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnOutput);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.btnSalary);
            this.panel3.Controls.Add(this.txtBonus);
            this.panel3.Controls.Add(this.txtBaseSalary);
            this.panel3.Controls.Add(this.txtMonth);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 213);
            this.panel3.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tháng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lương cơ bản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(39, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Thưởng";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(211, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(447, 26);
            this.txtID.TabIndex = 4;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(211, 64);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(447, 26);
            this.txtMonth.TabIndex = 5;
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.Location = new System.Drawing.Point(211, 113);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(447, 26);
            this.txtBaseSalary.TabIndex = 6;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(211, 162);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(447, 26);
            this.txtBonus.TabIndex = 7;
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(765, 14);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(125, 32);
            this.btnSalary.TabIndex = 8;
            this.btnSalary.Text = "Tính lương";
            this.btnSalary.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(766, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 32);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Làm mới";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(766, 110);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(125, 32);
            this.btnOutput.TabIndex = 10;
            this.btnOutput.Text = "Xuất EXEL";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(766, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 32);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormSalary";
            this.Text = "FormSalary";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbSalary.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ListSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearcch;
        private System.Windows.Forms.TableLayoutPanel tbSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtBaseSalary;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSalary;
    }
}