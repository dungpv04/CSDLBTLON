namespace QuanLiSinhVien.Forms.SinhVien
{
    partial class KetQuaHocTap
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
            backBtn = new Button();
            label2 = new Label();
            txtDTB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 11);
            label1.Name = "label1";
            label1.Size = new Size(348, 54);
            label1.TabIndex = 0;
            label1.Text = "Kết quả học tập";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 146);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(998, 476);
            dataGridView1.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(55, 72);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(100, 55);
            backBtn.TabIndex = 4;
            backBtn.Text = "Quay lại";
            backBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 679);
            label2.Name = "label2";
            label2.Size = new Size(302, 46);
            label2.TabIndex = 5;
            label2.Text = "Điểm trung bình: ";
            // 
            // txtDTB
            // 
            txtDTB.AutoSize = true;
            txtDTB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDTB.Location = new Point(336, 679);
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(302, 46);
            txtDTB.TabIndex = 6;
            txtDTB.Text = "Điểm trung bình: ";
            // 
            // KetQuaHocTap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 928);
            Controls.Add(txtDTB);
            Controls.Add(label2);
            Controls.Add(backBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KetQuaHocTap";
            Text = "KetQuaHocTap";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private Label label2;
        private Label txtDTB;
    }
}