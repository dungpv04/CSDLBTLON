namespace QuanLiSinhVien.Forms.GiangVien
{
    partial class GiangVienHome
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
            seeAllSubClassBtn = new Button();
            showRegisteredSubjectsBtn = new Button();
            userInforBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // seeAllSubClassBtn
            // 
            seeAllSubClassBtn.Location = new Point(192, 171);
            seeAllSubClassBtn.Margin = new Padding(3, 4, 3, 4);
            seeAllSubClassBtn.Name = "seeAllSubClassBtn";
            seeAllSubClassBtn.Size = new Size(235, 91);
            seeAllSubClassBtn.TabIndex = 13;
            seeAllSubClassBtn.Text = "Xem danh sách lớp giảng dạy";
            seeAllSubClassBtn.UseVisualStyleBackColor = true;
            seeAllSubClassBtn.Click += seeAllSubClassBtn_Click;
            // 
            // showRegisteredSubjectsBtn
            // 
            showRegisteredSubjectsBtn.Location = new Point(444, 171);
            showRegisteredSubjectsBtn.Margin = new Padding(3, 4, 3, 4);
            showRegisteredSubjectsBtn.Name = "showRegisteredSubjectsBtn";
            showRegisteredSubjectsBtn.Size = new Size(235, 91);
            showRegisteredSubjectsBtn.TabIndex = 12;
            showRegisteredSubjectsBtn.Text = "Xem danh sách sinh viên thuộc lớp quản lí";
            showRegisteredSubjectsBtn.UseVisualStyleBackColor = true;
            showRegisteredSubjectsBtn.Click += showRegisteredSubjectsBtn_Click;
            // 
            // userInforBtn
            // 
            userInforBtn.Location = new Point(44, 92);
            userInforBtn.Margin = new Padding(3, 4, 3, 4);
            userInforBtn.Name = "userInforBtn";
            userInforBtn.Size = new Size(140, 29);
            userInforBtn.TabIndex = 11;
            userInforBtn.Text = "Thông tin cá nhân";
            userInforBtn.UseVisualStyleBackColor = true;
            userInforBtn.Click += userInforBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 321);
            label2.Name = "label2";
            label2.Size = new Size(0, 54);
            label2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 54);
            label1.Name = "label1";
            label1.Size = new Size(370, 54);
            label1.TabIndex = 9;
            label1.Text = "Trang giảng viên";
            // 
            // GiangVienHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(seeAllSubClassBtn);
            Controls.Add(showRegisteredSubjectsBtn);
            Controls.Add(userInforBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GiangVienHome";
            Text = "GiangVienHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button seeAllSubClassBtn;
        private System.Windows.Forms.Button showRegisteredSubjectsBtn;
        private System.Windows.Forms.Button userInforBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}