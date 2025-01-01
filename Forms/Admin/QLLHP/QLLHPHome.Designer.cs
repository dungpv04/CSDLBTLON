namespace QuanLiSinhVien.Forms.Admin.QLLHP
{
    partial class QLLHPHome
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
            addBtn = new Button();
            label2 = new Label();
            khoa = new ComboBox();
            lql = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(456, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản lí lớp học phần";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1015, 586);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1042, 159);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(170, 58);
            addBtn.TabIndex = 2;
            addBtn.Text = "Thêm lớp học phần";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Khoa";
            // 
            // khoa
            // 
            khoa.FormattingEnabled = true;
            khoa.Location = new Point(61, 124);
            khoa.Name = "khoa";
            khoa.Size = new Size(301, 28);
            khoa.TabIndex = 4;
            khoa.SelectedIndexChanged += khoa_SelectedIndexChanged;
            // 
            // lql
            // 
            lql.FormattingEnabled = true;
            lql.Location = new Point(478, 118);
            lql.Name = "lql";
            lql.Size = new Size(226, 28);
            lql.TabIndex = 6;
            lql.SelectedIndexChanged += lql_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 121);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Lớp quản lí";
            // 
            // QLLHPHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 807);
            Controls.Add(lql);
            Controls.Add(label3);
            Controls.Add(khoa);
            Controls.Add(label2);
            Controls.Add(addBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "QLLHPHome";
            Text = "QLLHPHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button addBtn;
        private Label label2;
        private ComboBox khoa;
        private ComboBox lql;
        private Label label3;
    }
}