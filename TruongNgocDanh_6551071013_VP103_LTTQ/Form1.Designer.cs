namespace TruongNgocDanh_6551071013_VP103_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(214, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 33);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(349, 19);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 28);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(485, 19);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(627, 20);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, GiaTien });
            dataGridView1.Location = new Point(220, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(557, 332);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaSach
            // 
            MaSach.HeaderText = "Column1";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.Width = 125;
            // 
            // TenSach
            // 
            TenSach.HeaderText = "Column1";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.Width = 125;
            // 
            // GiaTien
            // 
            GiaTien.HeaderText = "Column1";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            GiaTien.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 380);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 27);
            textBox3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 63);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 9;
            label1.Text = "Danh sách Sách";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 10;
            label2.Text = "Thông tin Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 50);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 210);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 12;
            label4.Text = "Tên sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 346);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 13;
            label5.Text = "Giá tiền";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridView dataGridView1;
        
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn GiaTien;
    }
}
