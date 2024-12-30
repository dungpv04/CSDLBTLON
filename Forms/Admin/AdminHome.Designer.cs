namespace QuanLiSinhVien.Forms.Admin
{
    partial class AdminHome
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
            qlsv = new Button();
            qlgv = new Button();
            qlmh = new Button();
            qlk = new Button();
            qlLopQL = new Button();
            qlLHP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 36);
            label1.Name = "label1";
            label1.Size = new Size(351, 50);
            label1.TabIndex = 0;
            label1.Text = "Trang quản trị viên";
            // 
            // qlsv
            // 
            qlsv.Location = new Point(32, 131);
            qlsv.Name = "qlsv";
            qlsv.Size = new Size(209, 72);
            qlsv.TabIndex = 1;
            qlsv.Text = "Quản lí sinh viên";
            qlsv.UseVisualStyleBackColor = true;
            qlsv.Click += qlsv_Click;
            // 
            // qlgv
            // 
            qlgv.Location = new Point(263, 131);
            qlgv.Name = "qlgv";
            qlgv.Size = new Size(209, 72);
            qlgv.TabIndex = 2;
            qlgv.Text = "Quản lí giảng viên";
            qlgv.UseVisualStyleBackColor = true;
            qlgv.Click += qlgv_Click;
            // 
            // qlmh
            // 
            qlmh.Location = new Point(491, 131);
            qlmh.Name = "qlmh";
            qlmh.Size = new Size(209, 72);
            qlmh.TabIndex = 3;
            qlmh.Text = "Quản lí môn học";
            qlmh.UseVisualStyleBackColor = true;
            qlmh.Click += qlmh_Click;
            // 
            // qlk
            // 
            qlk.Location = new Point(32, 223);
            qlk.Name = "qlk";
            qlk.Size = new Size(209, 72);
            qlk.TabIndex = 4;
            qlk.Text = "Quản lí khoa";
            qlk.UseVisualStyleBackColor = true;
            qlk.Click += qlk_Click;
            // 
            // qlLopQL
            // 
            qlLopQL.Location = new Point(263, 223);
            qlLopQL.Name = "qlLopQL";
            qlLopQL.Size = new Size(209, 72);
            qlLopQL.TabIndex = 5;
            qlLopQL.Text = "Quản lí lớp quản lí";
            qlLopQL.UseVisualStyleBackColor = true;
            qlLopQL.Click += qlLopQL_Click;
            // 
            // qlLHP
            // 
            qlLHP.Location = new Point(491, 223);
            qlLHP.Name = "qlLHP";
            qlLHP.Size = new Size(209, 72);
            qlLHP.TabIndex = 6;
            qlLHP.Text = "Quản lí lớp học phần";
            qlLHP.UseVisualStyleBackColor = true;
            qlLHP.Click += qlLHP_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 347);
            Controls.Add(qlLHP);
            Controls.Add(qlLopQL);
            Controls.Add(qlk);
            Controls.Add(qlmh);
            Controls.Add(qlgv);
            Controls.Add(qlsv);
            Controls.Add(label1);
            Name = "AdminHome";
            Text = "AdminHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button qlsv;
        private Button qlgv;
        private Button qlmh;
        private Button qlk;
        private Button qlLopQL;
        private Button qlLHP;
    }
}