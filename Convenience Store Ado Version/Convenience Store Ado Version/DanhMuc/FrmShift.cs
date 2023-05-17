using Convenience_Store_Ado_Version.BS_Layer;
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

namespace Convenience_Store_Ado_Version.DanhMuc
{
    public partial class FrmShift : Form
    {
        DataTable dtShift = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLShift dbSHIFT = new BLShift();
        public FrmShift()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtShift = new DataTable();
                dtShift.Clear();
                DataSet ds = dbSHIFT.TakeShift();
                dtShift = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvSHIFT.DataSource = dtShift;
                DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
                newStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                dgvSHIFT.DefaultCellStyle = newStyle;
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                headerStyle.ForeColor = Color.Red;
                foreach (DataGridViewColumn column in dgvSHIFT.Columns)
                {
                    column.HeaderCell.Style = headerStyle;
                }
                dgvSHIFT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong Panel
                this.txtshID.ResetText();
                this.txtStartTime.ResetText();
                this.txtEndTime.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                dgvSHIFT_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table SHIFT. Lỗi rồi!!!");
            }
        }
        private void FrmShift_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtshID.Enabled = true;
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtshID.ResetText();
            this.txtStartTime.ResetText();
            this.txtEndTime.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtshID
            this.txtshID.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvSHIFT_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtshID.Enabled = false;
            this.txtStartTime.Focus();
        }
        private void dgvSHIFT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvSHIFT.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtshID.Text =
            dgvSHIFT.Rows[r].Cells[0].Value.ToString();
            this.txtStartTime.Text =
            dgvSHIFT.Rows[r].Cells[1].Value.ToString();
            this.txtEndTime.Text =
            dgvSHIFT.Rows[r].Cells[2].Value.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtshID.ResetText();
            this.txtStartTime.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvSHIFT_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLShift blShift = new BLShift();
                    blShift.AddShift(this.txtshID.Text, TimeSpan.Parse(this.txtStartTime.Text), TimeSpan.Parse(this.txtEndTime.Text), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLShift blShift = new BLShift();
                blShift.UpdateShift(this.txtshID.Text, TimeSpan.Parse(this.txtStartTime.Text), TimeSpan.Parse(this.txtEndTime.Text), ref err);

                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvSHIFT.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strSHIFT = dgvSHIFT.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbSHIFT.DeleteShift(ref err, strSHIFT);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
    }
}
