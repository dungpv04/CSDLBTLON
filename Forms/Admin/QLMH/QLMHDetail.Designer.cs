namespace QuanLiSinhVien.Forms.Admin.QLMH
{
    partial class QLMHDetail
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
            tc = new TextBox();
            label6 = new Label();
            label8 = new Label();
            gioitinh = new ComboBox();
            khoa = new ComboBox();
            update = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // masv
            // 
            masv.Enabled = false;
            masv.Location = new Point(139, 112);
            masv.Name = "masv";
            masv.Size = new Size(202, 27);
            masv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 115);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã môn học";
            // 
            // labelsss
            // 
            labelsss.AutoSize = true;
            labelsss.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsss.Location = new Point(254, 9);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(419, 60);
            labelsss.TabIndex = 2;
            labelsss.Text = "Thông tin môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 182);
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
            label4.Location = new Point(42, 231);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 8;
            label4.Text = "Tín chỉ";
            // 
            // tc
            // 
            tc.Location = new Point(139, 226);
            tc.Name = "tc";
            tc.Size = new Size(202, 27);
            tc.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 122);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 12;
            label6.Text = "Học kỳ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(562, 182);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 16;
            label8.Text = "Khoa";
            // 
            // gioitinh
            // 
            gioitinh.FormattingEnabled = true;
            gioitinh.Location = new Point(618, 119);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(151, 28);
            gioitinh.TabIndex = 22;
            // 
            // khoa
            // 
            khoa.FormattingEnabled = true;
            khoa.Location = new Point(618, 182);
            khoa.Name = "khoa";
            khoa.Size = new Size(202, 28);
            khoa.TabIndex = 23;
            // 
            // update
            // 
            update.Location = new Point(286, 312);
            update.Name = "update";
            update.Size = new Size(119, 29);
            update.TabIndex = 25;
            update.Text = "Cập nhật";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(524, 312);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 26;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // QLMHDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 376);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(khoa);
            Controls.Add(gioitinh);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(tc);
            Controls.Add(label2);
            Controls.Add(tensv);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(masv);
            Name = "QLMHDetail";
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
        private TextBox tc;
        private Label label6;
        private Label label8;
        private ComboBox gioitinh;
        private ComboBox khoa;
        private Button update;
        private Button delete;
    }
}