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
    public partial class FrmLoyalCustomer : Form
    {
        #region global Var
        DataTable tbCTM = null;
        BLLoyalCustomer dbCustomer = new BLLoyalCustomer();
        string err;
        bool Add;
        #endregion
        public FrmLoyalCustomer()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                tbCTM = new DataTable();
                tbCTM.Clear();
                DataSet dataSet = dbCustomer.TakeCustomer();
                tbCTM = dataSet.Tables[0];
                // push on data GRV
                dgvLoyalCustomer.DataSource = tbCTM;
                DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
                newStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                dgvLoyalCustomer.DefaultCellStyle = newStyle;
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                headerStyle.ForeColor = Color.Red;
                foreach (DataGridViewColumn column in dgvLoyalCustomer.Columns)
                {
                    column.HeaderCell.Style = headerStyle;
                }
                dgvLoyalCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;
                dgvLoyalCustomer_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
       
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgvLoyalCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoyalCustomer.CurrentCell.RowIndex;
            txtcID.Text = dgvLoyalCustomer.Rows[r].Cells[0].Value.ToString();
            txtName.Text = dgvLoyalCustomer.Rows[r].Cells[1].Value.ToString();
            txtPhone.Text = dgvLoyalCustomer.Rows[r].Cells[3].Value.ToString();
            txtrName.Text = dgvLoyalCustomer.Rows[r].Cells[4].Value.ToString();
        }
        #region Button Customer

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtcID.Enabled = true;
            // Kich hoạt biến Add
            Add = true;
            // Xóa trống các đối tượng trong Panel
            this.txtcID.ResetText();
            this.txtName.ResetText();
            this.txtPhone.ResetText();
            this.txtrName.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtbatchID
            this.txtcID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Add = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvLoyalCustomer_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtcID.Enabled = false;
            this.txtrName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvLoyalCustomer.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strELate1 = dgvLoyalCustomer.Rows[r].Cells[0].Value.ToString();
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
                    dbCustomer.DeleteCustomer(strELate1, ref err);
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtcID.ResetText();
            this.txtName.ResetText();
            this.txtPhone.ResetText();
            this.txtrName.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvLoyalCustomer_CellClick(null, null);
        }


        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    // Thực hiện lệnh
                    BLLoyalCustomer blCus = new BLLoyalCustomer();
                    blCus.AddCustomer(this.txtcID.Text, this.txtName.Text,this.txtPhone.Text, this.txtrName.Text, ref err);
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
                BLLoyalCustomer blCus = new BLLoyalCustomer();
                blCus.UpdateCustomer(this.txtcID.Text, this.txtName.Text,this.txtPhone.Text, this.txtrName.Text, ref err);

                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
    }
}
