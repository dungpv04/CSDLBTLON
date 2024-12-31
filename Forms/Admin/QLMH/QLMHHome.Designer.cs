namespace QuanLiSinhVien.Forms.Admin.QLMH
{
    partial class QLMHHome
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
            add = new Button();
            label2 = new Label();
            khoa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(461, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản lí môn học";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1126, 580);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // add
            // 
            add.Location = new Point(1174, 104);
            add.Name = "add";
            add.Size = new Size(164, 29);
            add.TabIndex = 2;
            add.Text = "Thêm môn học";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Khoa";
            // 
            // khoa
            // 
            khoa.FormattingEnabled = true;
            khoa.Location = new Point(76, 66);
            khoa.Name = "khoa";
            khoa.Size = new Size(259, 28);
            khoa.TabIndex = 4;
            khoa.SelectedValueChanged += khoa_SelectedValueChanged;
            // 
            // QLMHHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 714);
            Controls.Add(khoa);
            Controls.Add(label2);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "QLMHHome";
            Text = "QLSVHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button add;
        private Label label2;
        private ComboBox khoa;
    }
}