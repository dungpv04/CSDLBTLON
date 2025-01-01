namespace QuanLiSinhVien.Forms.Admin.QLLHP
{
    partial class QLLHPDetail
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
            cbHK = new ComboBox();
            label6 = new Label();
            cbLQL = new ComboBox();
            label5 = new Label();
            cbK = new ComboBox();
            cbGV = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            updateBtn = new Button();
            label2 = new Label();
            tenLop = new TextBox();
            labelsss = new Label();
            label1 = new Label();
            maLop = new TextBox();
            deleteBtn = new Button();
            cbMH = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // cbHK
            // 
            cbHK.FormattingEnabled = true;
            cbHK.Location = new Point(519, 234);
            cbHK.Name = "cbHK";
            cbHK.Size = new Size(241, 28);
            cbHK.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 238);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 56;
            label6.Text = "Học kỳ";
            // 
            // cbLQL
            // 
            cbLQL.FormattingEnabled = true;
            cbLQL.Location = new Point(519, 170);
            cbLQL.Name = "cbLQL";
            cbLQL.Size = new Size(241, 28);
            cbLQL.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 174);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 54;
            label5.Text = "Lớp quản lí";
            // 
            // cbK
            // 
            cbK.FormattingEnabled = true;
            cbK.Location = new Point(145, 318);
            cbK.Name = "cbK";
            cbK.Size = new Size(241, 28);
            cbK.TabIndex = 53;
            cbK.SelectedValueChanged += cbK_SelectedValueChanged;
            // 
            // cbGV
            // 
            cbGV.FormattingEnabled = true;
            cbGV.Location = new Point(147, 251);
            cbGV.Name = "cbGV";
            cbGV.Size = new Size(200, 28);
            cbGV.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 318);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 51;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 251);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 50;
            label4.Text = "Giảng viên";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(219, 391);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(156, 57);
            updateBtn.TabIndex = 49;
            updateBtn.Text = "Cập nhật";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 184);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 48;
            label2.Text = "Tên lớp";
            // 
            // tenLop
            // 
            tenLop.Location = new Point(145, 177);
            tenLop.Name = "tenLop";
            tenLop.Size = new Size(202, 27);
            tenLop.TabIndex = 47;
            // 
            // labelsss
            // 
            labelsss.AutoSize = true;
            labelsss.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsss.Location = new Point(178, 9);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(509, 60);
            labelsss.TabIndex = 46;
            labelsss.Text = "Thông tin lớp học phần";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 117);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 45;
            label1.Text = "Mã lớp";
            // 
            // maLop
            // 
            maLop.Enabled = false;
            maLop.Location = new Point(145, 114);
            maLop.Name = "maLop";
            maLop.Size = new Size(202, 27);
            maLop.TabIndex = 44;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(407, 391);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(156, 57);
            deleteBtn.TabIndex = 58;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cbMH
            // 
            cbMH.FormattingEnabled = true;
            cbMH.Location = new Point(519, 109);
            cbMH.Name = "cbMH";
            cbMH.Size = new Size(241, 28);
            cbMH.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 113);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 59;
            label7.Text = "Môn học";
            // 
            // QLLHPDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 619);
            Controls.Add(cbMH);
            Controls.Add(label7);
            Controls.Add(deleteBtn);
            Controls.Add(cbHK);
            Controls.Add(label6);
            Controls.Add(cbLQL);
            Controls.Add(label5);
            Controls.Add(cbK);
            Controls.Add(cbGV);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(updateBtn);
            Controls.Add(label2);
            Controls.Add(tenLop);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(maLop);
            Name = "QLLHPDetail";
            Text = "QLLHPDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbHK;
        private Label label6;
        private ComboBox cbLQL;
        private Label label5;
        private ComboBox cbK;
        private ComboBox cbGV;
        private Label label3;
        private Label label4;
        private Button updateBtn;
        private Label label2;
        private TextBox tenLop;
        private Label labelsss;
        private Label label1;
        private TextBox maLop;
        private Button deleteBtn;
        private ComboBox cbMH;
        private Label label7;
    }
}