namespace QuanLiSinhVien.Forms.Admin.QLLQL
{
    partial class QLLQLAdd
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
            addBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            cbGV = new ComboBox();
            cbK = new ComboBox();
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
            label1.Location = new Point(42, 115);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã lớp";
            // 
            // labelsss
            // 
            labelsss.AutoSize = true;
            labelsss.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsss.Location = new Point(42, 9);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(376, 60);
            labelsss.TabIndex = 2;
            labelsss.Text = "Thêm lớp quản lí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 182);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên lớp";
            // 
            // tensv
            // 
            tensv.Location = new Point(139, 175);
            tensv.Name = "tensv";
            tensv.Size = new Size(202, 27);
            tensv.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(141, 384);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(156, 57);
            addBtn.TabIndex = 25;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 316);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 27;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 249);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 26;
            label4.Text = "Giảng viên";
            // 
            // cbGV
            // 
            cbGV.FormattingEnabled = true;
            cbGV.Location = new Point(141, 249);
            cbGV.Name = "cbGV";
            cbGV.Size = new Size(200, 28);
            cbGV.TabIndex = 28;
            // 
            // cbK
            // 
            cbK.FormattingEnabled = true;
            cbK.Location = new Point(139, 316);
            cbK.Name = "cbK";
            cbK.Size = new Size(241, 28);
            cbK.TabIndex = 29;
            // 
            // QLLQLAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 617);
            Controls.Add(cbK);
            Controls.Add(cbGV);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(tensv);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(masv);
            Name = "QLLQLAdd";
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
        private Button addBtn;
        private Label label3;
        private Label label4;
        private ComboBox cbGV;
        private ComboBox cbK;
    }
}