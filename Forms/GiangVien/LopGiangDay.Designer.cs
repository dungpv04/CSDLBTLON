namespace QuanLiSinhVien.Forms.GiangVien
{
    partial class LopGiangDay
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 35);
            label1.Name = "label1";
            label1.Size = new Size(651, 54);
            label1.TabIndex = 0;
            label1.Text = "Danh sách lớp đang giảng dạy";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 186);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(908, 718);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(80, 124);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(100, 55);
            backBtn.TabIndex = 4;
            backBtn.Text = "Quay lại";
            backBtn.UseVisualStyleBackColor = true;
            // 
            // LopGiangDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 908);
            Controls.Add(backBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LopGiangDay";
            Text = "LopGiangDay";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
    }
}