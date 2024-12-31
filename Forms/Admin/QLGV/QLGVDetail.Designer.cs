namespace QuanLiSinhVien.Forms.Admin.QLGV
{
    partial class QLGVDetail
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
            label3 = new Label();
            label4 = new Label();
            dienthoai = new TextBox();
            label5 = new Label();
            email = new TextBox();
            label6 = new Label();
            label8 = new Label();
            ngaysinh = new DateTimePicker();
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
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã giảng viên";
            // 
            // labelsss
            // 
            labelsss.AutoSize = true;
            labelsss.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsss.Location = new Point(254, 9);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(457, 60);
            labelsss.TabIndex = 2;
            labelsss.Text = "Thông tin giảng viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 182);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên giảng viên";
            // 
            // tensv
            // 
            tensv.Location = new Point(139, 175);
            tensv.Name = "tensv";
            tensv.Size = new Size(202, 27);
            tensv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 241);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 295);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Điện thoại";
            // 
            // dienthoai
            // 
            dienthoai.Location = new Point(139, 290);
            dienthoai.Name = "dienthoai";
            dienthoai.Size = new Size(202, 27);
            dienthoai.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 353);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(139, 344);
            email.Name = "email";
            email.Size = new Size(202, 27);
            email.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 122);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Giới tính";
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
            // ngaysinh
            // 
            ngaysinh.Location = new Point(139, 234);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(250, 27);
            ngaysinh.TabIndex = 21;
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
            update.Location = new Point(199, 436);
            update.Name = "update";
            update.Size = new Size(119, 29);
            update.TabIndex = 25;
            update.Text = "Cập nhật";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(437, 436);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 26;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // QLGVDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 500);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(khoa);
            Controls.Add(gioitinh);
            Controls.Add(ngaysinh);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(dienthoai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tensv);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(masv);
            Name = "QLGVDetail";
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
        private Label label3;
        private Label label4;
        private TextBox dienthoai;
        private Label label5;
        private TextBox email;
        private Label label6;
        private Label label8;
        private DateTimePicker ngaysinh;
        private ComboBox gioitinh;
        private ComboBox khoa;
        private Button update;
        private Button delete;
    }
}