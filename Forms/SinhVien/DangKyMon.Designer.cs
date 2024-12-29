namespace QuanLiSinhVien.Forms.SinhVien
{
    partial class DangKyMon
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
            dsChuaDk = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dsDaDk = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dsChuaDk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dsDaDk).BeginInit();
            SuspendLayout();
            // 
            // dsChuaDk
            // 
            dsChuaDk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsChuaDk.Location = new Point(44, 62);
            dsChuaDk.Name = "dsChuaDk";
            dsChuaDk.RowHeadersWidth = 51;
            dsChuaDk.Size = new Size(960, 303);
            dsChuaDk.TabIndex = 0;
            dsChuaDk.CellClick += dsChuaDk_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(434, 31);
            label1.TabIndex = 1;
            label1.Text = "Danh sách lớp học phần có thể đăng ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 403);
            label2.Name = "label2";
            label2.Size = new Size(395, 31);
            label2.TabIndex = 3;
            label2.Text = "Danh sách lớp học phần đã đăng ký";
            // 
            // dsDaDk
            // 
            dsDaDk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsDaDk.Location = new Point(44, 450);
            dsDaDk.Name = "dsDaDk";
            dsDaDk.RowHeadersWidth = 51;
            dsDaDk.Size = new Size(960, 341);
            dsDaDk.TabIndex = 2;
            dsDaDk.CellClick += dsDaDk_CellClick;
            // 
            // DangKyMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 823);
            Controls.Add(label2);
            Controls.Add(dsDaDk);
            Controls.Add(label1);
            Controls.Add(dsChuaDk);
            Name = "DangKyMon";
            Text = "DangKyMon";
            ((System.ComponentModel.ISupportInitialize)dsChuaDk).EndInit();
            ((System.ComponentModel.ISupportInitialize)dsDaDk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dsChuaDk;
        private Label label1;
        private Label label2;
        private DataGridView dsDaDk;
    }
}