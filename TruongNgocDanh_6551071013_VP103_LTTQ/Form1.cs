using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TruongNgocDanh_6551071013_VP103_LTTQ.Models;
namespace TruongNgocDanh_6551071013_VP103_LTTQ
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.CellClick += dataGridView1_CellClick;
            btnSua.Click += btnSua_Click;

            TrangThaiBanDau();
            HienThiDanhSachSach();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow dong = dataGridView1.Rows[e.RowIndex];

            textBox3.Text = dong.Cells["MaSach"].Value?.ToString();
            textBox2.Text = dong.Cells["TenSach"].Value?.ToString();
            textBox1.Text = dong.Cells["GiaTien"].Value?.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool daChonDong = dataGridView1.SelectedRows.Count > 0
                              && dataGridView1.CurrentRow != null
                              && !dataGridView1.CurrentRow.IsNewRow;

            btnSua.Enabled = daChonDong;
            btnXoa.Enabled = daChonDong;
        }
        private void TrangThaiBanDau()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();

            dataGridView1.ClearSelection();
        }
        private void HienThiDanhSachSach()
        {
            try
            {
                using (var db = new DuLieuContext(
                    new DbContextOptionsBuilder<DuLieuContext>().Options))
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = db.CongViecs
                        .AsNoTracking()
                        .ToList();
                }

                dataGridView1.ClearSelection();
                TrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSach = textBox3.Text.Trim();
            string tenSach = textBox2.Text.Trim();
            string giaTien = textBox1.Text.Trim();

            if (maSach == "" || tenSach == "" || giaTien == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(giaTien, out decimal gia))
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                textBox1.Focus();
                return;
            }

            try
            {
                using (var db = new DuLieuContext(
                    new DbContextOptionsBuilder<DuLieuContext>().Options))
                {
                    bool trungMa = db.CongViecs.Any(s => s.MaSach == maSach);

                    if (trungMa)
                    {
                        MessageBox.Show("Mã sách đã tồn tại! Vui lòng nhập mã khác.");
                        textBox3.Focus();
                        textBox3.SelectAll();
                        return;
                    }

                    var sach = new CongViec
                    {
                        MaSach = maSach,
                        TenSach = tenSach,
                        GiaTien = giaTien
                    };

                    db.CongViecs.Add(sach);
                    db.SaveChanges();

                    dataGridView1.DataSource = db.CongViecs.ToList();
                }

                MessageBox.Show("Thêm sách thành công!");

                textBox3.Clear();
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            MessageBox.Show("Thêm sách thành công!");

            HienThiDanhSachSach();

            textBox3.Focus();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox1.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!");
                return;
            }

            string maSach = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sách này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DuLieuContext(
                        new DbContextOptionsBuilder<DuLieuContext>().Options))
                    {
                        var sach = db.CongViecs.Find(maSach);

                        if (sach != null)
                        {
                            db.CongViecs.Remove(sach);
                            db.SaveChanges();

                            MessageBox.Show("Xóa sách thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách cần xóa!");
                        }

                        dataGridView1.DataSource = db.CongViecs.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
                    HienThiDanhSachSach();
                    TrangThaiBanDau();
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
            private void btnSua_Click(object sender, EventArgs e)
        {
            string maSach = textBox3.Text.Trim();
            string tenSach = textBox2.Text.Trim();
            string giaTien = textBox1.Text.Trim();

            if (maSach == "" || tenSach == "" || giaTien == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(giaTien, out decimal gia) || gia < 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                textBox1.Focus();
                return;
            }

            try
            {
                using (var db = new DuLieuContext(
                    new DbContextOptionsBuilder<DuLieuContext>().Options))
                {
                    var sach = db.CongViecs.Find(maSach);

                    if (sach == null)
                    {
                        MessageBox.Show("Không tìm thấy sách!");
                        return;
                    }

                    sach.TenSach = tenSach;
                    sach.GiaTien = giaTien;

                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật sách thành công!");

                HienThiDanhSachSach();
                TrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }
    }
    }


