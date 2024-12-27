namespace QuanLiSinhVien.Forms.SinhVien
{
    partial class HocPhi
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
            dataGridView1 = new DataGridView();
            totalFee = new Label();
            backBtn = new Button();
            tongHP = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 34);
            label1.Name = "label1";
            label1.Size = new Size(181, 54);
            label1.TabIndex = 0;
            label1.Text = "Học phí";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1088, 526);
            dataGridView1.TabIndex = 1;
            // 
            // totalFee
            // 
            totalFee.AutoSize = true;
            totalFee.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalFee.Location = new Point(12, 725);
            totalFee.Name = "totalFee";
            totalFee.Size = new Size(103, 46);
            totalFee.TabIndex = 2;
            totalFee.Text = "Tổng";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(21, 55);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(100, 55);
            backBtn.TabIndex = 4;
            backBtn.Text = "Quay lại";
            backBtn.UseVisualStyleBackColor = true;
            // 
            // tongHP
            // 
            tongHP.AutoSize = true;
            tongHP.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tongHP.Location = new Point(121, 725);
            tongHP.Name = "tongHP";
            tongHP.Size = new Size(80, 46);
            tongHP.TabIndex = 5;
            tongHP.Text = "vnd";
            // 
            // HocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 915);
            Controls.Add(tongHP);
            Controls.Add(backBtn);
            Controls.Add(totalFee);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HocPhi";
            Text = "HocPhi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalFee;
        private System.Windows.Forms.Button backBtn;
        private Label tongHP;
    }
}