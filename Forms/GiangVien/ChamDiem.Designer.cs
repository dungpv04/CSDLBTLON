namespace QuanLiSinhVien.Forms.GiangVien
{
    partial class ChamDiem
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
            dqt = new TextBox();
            dt = new TextBox();
            submit = new Button();
            labss = new Label();
            label2 = new Label();
            warning = new Label();
            SuspendLayout();
            // 
            // dqt
            // 
            dqt.Location = new Point(175, 113);
            dqt.Name = "dqt";
            dqt.Size = new Size(134, 27);
            dqt.TabIndex = 0;
            // 
            // dt
            // 
            dt.Location = new Point(175, 146);
            dt.Name = "dt";
            dt.Size = new Size(134, 27);
            dt.TabIndex = 1;
            // 
            // submit
            // 
            submit.Location = new Point(195, 192);
            submit.Name = "submit";
            submit.Size = new Size(94, 32);
            submit.TabIndex = 2;
            submit.Text = "Cập nhật";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // labss
            // 
            labss.AutoSize = true;
            labss.Location = new Point(61, 116);
            labss.Name = "labss";
            labss.Size = new Size(108, 20);
            labss.TabIndex = 3;
            labss.Text = "Điểm quá trình";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 146);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Điểm thi";
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.ForeColor = Color.Red;
            warning.Location = new Point(120, 237);
            warning.Name = "warning";
            warning.Size = new Size(189, 20);
            warning.TabIndex = 5;
            warning.Text = "Vui lòng nhập đủ đầu điểm";
            warning.Visible = false;
            // 
            // ChamDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 318);
            Controls.Add(warning);
            Controls.Add(label2);
            Controls.Add(labss);
            Controls.Add(submit);
            Controls.Add(dt);
            Controls.Add(dqt);
            Name = "ChamDiem";
            Text = "Nhập điểm sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dqt;
        private TextBox dt;
        private Button submit;
        private Label labss;
        private Label label2;
        private Label warning;
    }
}