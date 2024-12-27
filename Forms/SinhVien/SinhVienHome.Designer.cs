namespace QuanLiSinhVien.Forms
{
    partial class SinhVienHome
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
            label1 = new Label();
            label2 = new Label();
            userInforBtn = new Button();
            showRegisteredSubjectsBtn = new Button();
            showGradeBtn = new Button();
            showSchoolFeeBtn = new Button();
            seeAllSubjectsBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 39);
            label1.Name = "label1";
            label1.Size = new Size(342, 54);
            label1.TabIndex = 0;
            label1.Text = "Trang sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 306);
            label2.Name = "label2";
            label2.Size = new Size(0, 54);
            label2.TabIndex = 1;
            // 
            // userInforBtn
            // 
            userInforBtn.Location = new Point(133, 390);
            userInforBtn.Margin = new Padding(3, 4, 3, 4);
            userInforBtn.Name = "userInforBtn";
            userInforBtn.Size = new Size(235, 88);
            userInforBtn.TabIndex = 2;
            userInforBtn.Text = "Thông tin cá nhân";
            userInforBtn.UseVisualStyleBackColor = true;
            userInforBtn.Click += userInforBtn_Click;
            // 
            // showRegisteredSubjectsBtn
            // 
            showRegisteredSubjectsBtn.Location = new Point(12, 146);
            showRegisteredSubjectsBtn.Margin = new Padding(3, 4, 3, 4);
            showRegisteredSubjectsBtn.Name = "showRegisteredSubjectsBtn";
            showRegisteredSubjectsBtn.Size = new Size(235, 91);
            showRegisteredSubjectsBtn.TabIndex = 3;
            showRegisteredSubjectsBtn.Text = "Kết quả đăng ký môn ";
            showRegisteredSubjectsBtn.UseVisualStyleBackColor = true;
            showRegisteredSubjectsBtn.Click += showRegisteredSubjectsBtn_Click;
            // 
            // showGradeBtn
            // 
            showGradeBtn.Location = new Point(12, 261);
            showGradeBtn.Margin = new Padding(3, 4, 3, 4);
            showGradeBtn.Name = "showGradeBtn";
            showGradeBtn.Size = new Size(235, 91);
            showGradeBtn.TabIndex = 6;
            showGradeBtn.Text = "Tra cứu điểm";
            showGradeBtn.UseVisualStyleBackColor = true;
            showGradeBtn.Click += showGradeBtn_Click;
            // 
            // showSchoolFeeBtn
            // 
            showSchoolFeeBtn.Location = new Point(264, 261);
            showSchoolFeeBtn.Margin = new Padding(3, 4, 3, 4);
            showSchoolFeeBtn.Name = "showSchoolFeeBtn";
            showSchoolFeeBtn.Size = new Size(235, 91);
            showSchoolFeeBtn.TabIndex = 7;
            showSchoolFeeBtn.Text = "Tra cứu học phí";
            showSchoolFeeBtn.UseVisualStyleBackColor = true;
            showSchoolFeeBtn.Click += showSchoolFeeBtn_Click;
            // 
            // seeAllSubjectsBtn
            // 
            seeAllSubjectsBtn.Location = new Point(264, 146);
            seeAllSubjectsBtn.Margin = new Padding(3, 4, 3, 4);
            seeAllSubjectsBtn.Name = "seeAllSubjectsBtn";
            seeAllSubjectsBtn.Size = new Size(235, 91);
            seeAllSubjectsBtn.TabIndex = 8;
            seeAllSubjectsBtn.Text = "Xem chương trình đào tạo";
            seeAllSubjectsBtn.UseVisualStyleBackColor = true;
            seeAllSubjectsBtn.Click += seeAllSubjectsBtn_Click;
            // 
            // SinhVienHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 535);
            Controls.Add(seeAllSubjectsBtn);
            Controls.Add(showSchoolFeeBtn);
            Controls.Add(showGradeBtn);
            Controls.Add(showRegisteredSubjectsBtn);
            Controls.Add(userInforBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SinhVienHome";
            Text = "Trang chủ sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button userInforBtn;
        private System.Windows.Forms.Button showRegisteredSubjectsBtn;
        private System.Windows.Forms.Button showGradeBtn;
        private System.Windows.Forms.Button showSchoolFeeBtn;
        private System.Windows.Forms.Button seeAllSubjectsBtn;
    }
}