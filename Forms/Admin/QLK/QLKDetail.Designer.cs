﻿namespace QuanLiSinhVien.Forms.Admin.QLK
{
    partial class QLKDetail
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
            update = new Button();
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
            labelsss.Location = new Point(42, 9);
            labelsss.Name = "labelsss";
            labelsss.Size = new Size(341, 60);
            labelsss.TabIndex = 2;
            labelsss.Text = "Thông tin khoa";
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
            // update
            // 
            update.Location = new Point(139, 263);
            update.Name = "update";
            update.Size = new Size(119, 29);
            update.TabIndex = 25;
            update.Text = "Cập nhật";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // QLKDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 376);
            Controls.Add(update);
            Controls.Add(label2);
            Controls.Add(tensv);
            Controls.Add(labelsss);
            Controls.Add(label1);
            Controls.Add(masv);
            Name = "QLKDetail";
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
        private Button update;
    }
}