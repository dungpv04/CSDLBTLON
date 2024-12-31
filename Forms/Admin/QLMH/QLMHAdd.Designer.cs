namespace QuanLiSinhVien.Forms.Admin.QLMH
{
    partial class QLMHAdd
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
            masv = new TextBox();
            label1 = new Label();
            labelsss = new Label();
            label2 = new Label();
            tensv = new TextBox();
            label4 = new Label();
            dienthoai = new TextBox();
            label6 = new Label();
            label8 = new Label();
            gioitinh = new ComboBox();
            khoa = new ComboBox();
            addBtn = new Button();
            SuspendLayout();
            // 
            // masv
            // 
            masv.Location = new Point(139, 112);
            masv.Name = "masv";
            masv.Size = new Size(202, 27);
            masv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 115);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã môn học";
            // 
            // labelsss
            // 
            labelsss.AutoSize = true;
            labelsss.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsss.Location = new Point(224, 9);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(333, 60);
            labelsss.TabIndex = 2;
            labelsss.Text = "Thêm môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 182);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên môn học";
            // 
            // tensv
            // 
            tensv.Location = new Point(139, 175);
            tensv.Name = "tensv";
            tensv.Size = new Size(202, 27);
            tensv.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 236);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Số tín chỉ";
            // 
            // dienthoai
            // 
            dienthoai.Location = new Point(139, 231);
            dienthoai.Name = "dienthoai";
            dienthoai.Size = new Size(202, 27);
            dienthoai.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 125);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 12;
            label6.Text = "Học kỳ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 182);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 16;
            label8.Text = "Khoa";
            // 
            // gioitinh
            // 
            gioitinh.FormattingEnabled = true;
            gioitinh.Location = new Point(543, 122);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(151, 28);
            gioitinh.TabIndex = 22;
            // 
            // khoa
            // 
            khoa.FormattingEnabled = true;
            khoa.Location = new Point(543, 182);
            khoa.Name = "khoa";
            khoa.Size = new Size(202, 28);
            khoa.TabIndex = 24;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(295, 309);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(156, 57);
            addBtn.TabIndex = 25;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // QLMHAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 502);
            Controls.Add(addBtn);
            Controls.Add(khoa);
            Controls.Add(gioitinh);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dienthoai);
            Controls.Add(label2);
            Controls.Add(tensv);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(masv);
            Name = "QLMHAdd";
            Text = "QLSVDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox masv;
        private Label label1;
        private Label labelsss;
        private Label label2;
        private TextBox tensv;
        private Label label4;
        private TextBox dienthoai;
        private Label label6;
        private Label label8;
        private ComboBox gioitinh;
        private ComboBox khoa;
        private Button addBtn;
    }
}