namespace QuanLiSinhVien.Forms.Admin.QLLHP
{
    partial class QLLHPAdd
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
            cbK = new ComboBox();
            cbGV = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            addBtn = new Button();
            label2 = new Label();
            tenLop = new TextBox();
            labelsss = new Label();
            label1 = new Label();
            maLop = new TextBox();
            cbLQL = new ComboBox();
            label5 = new Label();
            cbHK = new ComboBox();
            label6 = new Label();
            cbMH = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // cbK
            // 
            cbK.FormattingEnabled = true;
            cbK.Location = new Point(132, 348);
            cbK.Name = "cbK";
            cbK.Size = new Size(241, 28);
            cbK.TabIndex = 39;
            cbK.SelectedIndexChanged += cbK_SelectedIndexChanged;
            cbK.SelectedValueChanged += cbK_SelectedValueChanged;
            // 
            // cbGV
            // 
            cbGV.FormattingEnabled = true;
            cbGV.Location = new Point(134, 281);
            cbGV.Name = "cbGV";
            cbGV.Size = new Size(200, 28);
            cbGV.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 348);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 37;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 281);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 36;
            label4.Text = "Giảng viên";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(321, 421);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(156, 57);
            addBtn.TabIndex = 35;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 214);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 34;
            label2.Text = "Tên lớp";
            // 
            // tenLop
            // 
            tenLop.Location = new Point(132, 207);
            tenLop.Name = "tenLop";
            tenLop.Size = new Size(202, 27);
            tenLop.TabIndex = 33;
            // 
            // labelsss
            // 
            labelsss.AutoSize = true;
            labelsss.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsss.Location = new Point(223, 32);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(423, 60);
            labelsss.TabIndex = 32;
            labelsss.Text = "Thêm lớp học phần";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 147);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 31;
            label1.Text = "Mã lớp";
            // 
            // maLop
            // 
            maLop.Location = new Point(132, 144);
            maLop.Name = "maLop";
            maLop.Size = new Size(202, 27);
            maLop.TabIndex = 30;
            // 
            // cbLQL
            // 
            cbLQL.FormattingEnabled = true;
            cbLQL.Location = new Point(499, 207);
            cbLQL.Name = "cbLQL";
            cbLQL.Size = new Size(241, 28);
            cbLQL.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 211);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 40;
            label5.Text = "Lớp quản lí";
            // 
            // cbHK
            // 
            cbHK.FormattingEnabled = true;
            cbHK.Location = new Point(508, 273);
            cbHK.Name = "cbHK";
            cbHK.Size = new Size(241, 28);
            cbHK.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 277);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 42;
            label6.Text = "Học kỳ";
            // 
            // cbMH
            // 
            cbMH.FormattingEnabled = true;
            cbMH.Location = new Point(499, 139);
            cbMH.Name = "cbMH";
            cbMH.Size = new Size(241, 28);
            cbMH.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 143);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 44;
            label7.Text = "Môn học";
            // 
            // QLLHPAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 648);
            Controls.Add(cbMH);
            Controls.Add(label7);
            Controls.Add(cbHK);
            Controls.Add(label6);
            Controls.Add(cbLQL);
            Controls.Add(label5);
            Controls.Add(cbK);
            Controls.Add(cbGV);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(tenLop);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(maLop);
            Name = "QLLHPAdd";
            Text = "QLLHPAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbK;
        private ComboBox cbGV;
        private Label label3;
        private Label label4;
        private Button addBtn;
        private Label label2;
        private TextBox tenLop;
        private Label labelsss;
        private Label label1;
        private TextBox maLop;
        private ComboBox cbLQL;
        private Label label5;
        private ComboBox cbHK;
        private Label label6;
        private ComboBox cbMH;
        private Label label7;
    }
}