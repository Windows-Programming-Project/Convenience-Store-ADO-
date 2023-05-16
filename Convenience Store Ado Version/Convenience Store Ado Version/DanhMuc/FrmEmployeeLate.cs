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
    public partial class FrmEmployeeLate : Form
    {
        DataTable dtELate = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLEmployeeLate dbELate = new BLEmployeeLate();
        public FrmEmployeeLate()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtELate = new DataTable();
                dtELate.Clear();
                DataSet ds = dbELate.TakeEmployeeLate();
                dtELate = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvEMPLOYEELATE.DataSource = dtELate;
                DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
                newStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                dgvEMPLOYEELATE.DefaultCellStyle = newStyle;
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                headerStyle.ForeColor = Color.Red;
                foreach (DataGridViewColumn column in dgvEMPLOYEELATE.Columns)
                {
                    column.HeaderCell.Style = headerStyle;
                }
                dgvEMPLOYEELATE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong Panel
                this.txteID.ResetText();
                this.txtLateDate.ResetText();
                this.txtStartTime.ResetText();
                this.txtEndTime.ResetText();
                this.txtshID.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                dgvEMPLOYEELATE_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table EMPLOYEELATE. Lỗi rồi!!!");
            }
        }
        private void dgvEMPLOYEELATE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvEMPLOYEELATE.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txteID.Text = dgvEMPLOYEELATE.Rows[r].Cells[0].Value.ToString();
            this.txtLateDate.Text = dgvEMPLOYEELATE.Rows[r].Cells[1].Value.ToString();
            this.txtStartTime.Text = dgvEMPLOYEELATE.Rows[r].Cells[2].Value.ToString();
            this.txtEndTime.Text = dgvEMPLOYEELATE.Rows[r].Cells[3].Value.ToString();
            this.txtshID.Text = dgvEMPLOYEELATE.Rows[r].Cells[4].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txteID.Enabled = true;
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txteID.ResetText();
            this.txtLateDate.ResetText();
            this.txtStartTime.ResetText();
            this.txtEndTime.ResetText();
            this.txtshID.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;
          
            this.txteID.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvEMPLOYEELATE_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txteID.Enabled = false;
            this.txtshID.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLEmployeeLate blELate = new BLEmployeeLate();
                    blELate.AddEmployeeLate(this.txteID.Text, Convert.ToDateTime(this.txtLateDate.Text), TimeSpan.Parse(this.txtStartTime.Text), TimeSpan.Parse(this.txtEndTime.Text), this.txtshID.Text, ref err);
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
                BLEmployeeLate blELate = new BLEmployeeLate();
                blELate.UpdateEmployeeLate(this.txteID.Text, Convert.ToDateTime(this.txtLateDate.Text), TimeSpan.Parse(this.txtStartTime.Text), TimeSpan.Parse(this.txtEndTime.Text), this.txtshID.Text, ref err);

                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txteID.ResetText();
            this.txtLateDate.ResetText();
            this.txtStartTime.ResetText();
            this.txtEndTime.ResetText();
            this.txtshID.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvEMPLOYEELATE_CellClick(null, null);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvEMPLOYEELATE.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strELate1 = dgvEMPLOYEELATE.Rows[r].Cells[0].Value.ToString();
                string strELate2 = dgvEMPLOYEELATE.Rows[r].Cells[4].Value.ToString();
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
                    dbELate.DeleteEmployeeLate(strELate1, strELate2,ref err);
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
        private void FrmEmployeeLate_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
