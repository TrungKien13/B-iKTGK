using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De01
{
    public partial class frmSinhvien : Form
    {
        SinhvienModel sv;

        public frmSinhvien()
        {
            InitializeComponent();
            sv = new SinhvienModel();   
        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            try
            {
                SinhvienModel context = new SinhvienModel();
                List<Lop> listLop = context.Lop.ToList();  
                List<Sinhvien> listSinhvien = context.Sinhvien.ToList();  

                FillLopCombobox(listLop);  
                BindGrid(listSinhvien);  

                btnLuu.Enabled = false;  
                btnKLuu.Enabled = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sinh viên: " + ex.Message);
            }
        }

        private void FillLopCombobox(List<Lop> listLop)
        {
            cboLop.DataSource = listLop;
            cboLop.DisplayMember = "TenLop";  
            cboLop.ValueMember = "MaLop";     
        }

        private void BindGrid(List<Sinhvien> listSinhvien)
        {
            dgvSV.Rows.Clear();  
            foreach (var sv in listSinhvien)
            {
                int index = dgvSV.Rows.Add();
                dgvSV.Rows[index].Cells[0].Value = sv.MaSV;
                dgvSV.Rows[index].Cells[1].Value = sv.HotenSV;
                dgvSV.Rows[index].Cells[2].Value = sv.NgaySinh;
                dgvSV.Rows[index].Cells[3].Value = sv.Lop.TenLop;
            }
        }


        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSV.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                cboLop.Text = row.Cells[3].Value.ToString();

                
                btnLuu.Enabled = true;
                btnKLuu.Enabled = true;
            }


        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                SinhvienModel context = new SinhvienModel();
                Sinhvien sv = new Sinhvien
                {
                    MaSV = txtMaSV.Text,
                    HotenSV = txtHoTen.Text,
                    NgaySinh = dtNgaySinh.Value,
                    Lop = context.Lop.Find(cboLop.SelectedValue)
                };

                context.Sinhvien.Add(sv);
                context.SaveChanges();  

                BindGrid(context.Sinhvien.ToList());  

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();  
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                SinhvienModel context = new SinhvienModel();
                string maSV = txtMaSV.Text;
                Sinhvien sv = context.Sinhvien.FirstOrDefault(p => p.MaSV == maSV);

                if (sv != null)
                {
                    
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                          "Xác nhận",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        context.Sinhvien.Remove(sv);
                        context.SaveChanges();  

                        BindGrid(context.Sinhvien.ToList()); 

                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                SinhvienModel context = new SinhvienModel();
                string maSV = txtMaSV.Text;
                Sinhvien sv = context.Sinhvien.FirstOrDefault(p => p.MaSV == maSV);

                if (sv != null)
                {
                    sv.HotenSV = txtHoTen.Text;
                    sv.NgaySinh = dtNgaySinh.Value;
                    sv.Lop = context.Lop.Find(cboLop.SelectedValue);

                    context.SaveChanges();  
                    BindGrid(context.Sinhvien.ToList());  

                    MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SinhvienModel context = new SinhvienModel();
                string keyword = txtTim.Text.Trim();  

                List<Sinhvien> listSinhvien = context.Sinhvien
                    .Where(p => p.HotenSV.Contains(keyword))  
                    .ToList();

                if (listSinhvien.Count > 0)
                {
                    BindGrid(listSinhvien);  
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid(context.Sinhvien.ToList());  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SinhvienModel context = new SinhvienModel();
                string maSV = txtMaSV.Text;
                Sinhvien sv = context.Sinhvien.FirstOrDefault(p => p.MaSV == maSV);

                if (sv != null)
                {
                    sv.HotenSV = txtHoTen.Text;
                    sv.NgaySinh = dtNgaySinh.Value;
                    sv.Lop = context.Lop.Find(cboLop.SelectedValue);

                    context.SaveChanges();  
                    BindGrid(context.Sinhvien.ToList());  

                    MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnKLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy thay đổi không?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtMaSV.Clear();
                txtHoTen.Clear();
                dtNgaySinh.Value = DateTime.Now;
                cboLop.SelectedIndex = 0;  

                MessageBox.Show("Thay đổi đã được hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
