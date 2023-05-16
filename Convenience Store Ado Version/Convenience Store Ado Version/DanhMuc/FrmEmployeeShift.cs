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
    public partial class FrmEmployeeShift : Form
    {
        DataTable dtES = null;
        bool Them;
        string err;
        BLEmployeeShift dbES = new BLEmployeeShift();
        public FrmEmployeeShift()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtES = new DataTable();
                dtES.Clear();
                DataSet ds = dbES.TakeEmployeeShift();
                dtES = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvEMPLOYEESHIFT.DataSource = dtES;
                DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
                newStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                dgvEMPLOYEESHIFT.DefaultCellStyle = newStyle;
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                headerStyle.ForeColor = Color.Red;
                foreach (DataGridViewColumn column in dgvEMPLOYEESHIFT.Columns)
                {
                    column.HeaderCell.Style = headerStyle;
                }
                dgvEMPLOYEESHIFT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong Panel
                this.txteID.ResetText();
                this.txtshID.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                dgvEMPLOYEESHIFT_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table EMPLOYEESHIFT. Lỗi rồi!!!");
            }
        }
        private void FrmEmployeeShift_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txteID.Enabled = true;
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txteID.ResetText();
            this.txtshID.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txteID
            this.txteID.Focus();
        }
        private void dgvEMPLOYEESHIFT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvEMPLOYEESHIFT.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txteID.Text = dgvEMPLOYEESHIFT.Rows[r].Cells[0].Value.ToString();
            this.txtshID.Text = dgvEMPLOYEESHIFT.Rows[r].Cells[1].Value.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txteID.ResetText();
            this.txtshID.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvEMPLOYEESHIFT_CellClick(null, null);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLEmployeeShift blES = new BLEmployeeShift();
                    blES.AddEmployeeShift(this.txteID.Text, this.txtshID.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.InnerException.Message);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvEMPLOYEESHIFT.CurrentCell.RowIndex;
                string strES1 =
                dgvEMPLOYEESHIFT.Rows[r].Cells[0].Value.ToString();
                string strES2 =
                dgvEMPLOYEESHIFT.Rows[r].Cells[1].Value.ToString();
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
                    dbES.DeleteEmployeeShift(strES1,strES2,ref err);
                    // Cập nhật lại DataGridView
                    LoadData();
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
