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
using System.Xml.Linq;

namespace Convenience_Store_Ado_Version.DanhMuc
{
    public partial class FrmEmployee : Form
    {
        #region global Var
        DataTable tbEMP = null;
        BLEmployee dbEmployee = new BLEmployee();
        string err;
        bool Add;
        #endregion
        public FrmEmployee()
        {
            InitializeComponent();
        }

        void LoadDataEMP()
        {
            try
            {
                tbEMP = new DataTable();
                tbEMP.Clear();
                DataSet dataSet = dbEmployee.TakeEmployee();
                tbEMP = dataSet.Tables[0];
                // push on data GRV
                dgvEMPLOYEE.DataSource = tbEMP;
                DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
                newStyle.Font = new Font("Arial", 12, FontStyle.Regular);
                dgvEMPLOYEE.DefaultCellStyle = newStyle;
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                headerStyle.ForeColor = Color.Red;
                foreach (DataGridViewColumn column in dgvEMPLOYEE.Columns)
                {
                    column.HeaderCell.Style = headerStyle;
                }
                dgvEMPLOYEE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong Panel
                txtIDEmployee.ResetText();
                txtNameEMP.ResetText();
                txtDateofBirthEMP.ResetText();
                txtGenderEMP.ResetText();
                txtPhoneEMP.ResetText();
                txtAddEMP.ResetText();
                txtPosition.ResetText();
                txtSalaryEMP.ResetText();
                txtUsername.ResetText();
                txtPassword.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnExit.Enabled = true;
                dgvEMPLOYEE_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadDataEMP();
        }
        #region Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int gender = 0;
            if (Add)
            {
                try
                {
                    
                    BLEmployee blemp = new BLEmployee();
                    if (txtGenderEMP.Text == "True")
                    {
                        gender = 1;
                    }
                    bool isSuccess = blemp.UpdateEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text),txtUsername.Text,txtPassword.Text, ref err);           // Load lại dữ liệu trên DataGridView 

                    if (isSuccess)
                    {
                        MessageBox.Show("Employee update successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error update employee: {err}");
                    }
                    LoadDataEMP();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Error update!");
                }
            }
            else
            {
                
                BLEmployee blemp = new BLEmployee();
                if (txtGenderEMP.Text == "True")
                {
                    gender = 1;
                }
                blemp.UpdateEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text),txtUsername.Text,txtPassword.Text, ref err);    
                
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();
            // Thông báo 
            MessageBox.Show("Update Successfully!");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtIDEmployee.Enabled = true;
            // Kich hoạt biến Them
            Add = true;
            // Xóa trống các đối tượng trong Panel
            txtIDEmployee.ResetText();
            txtNameEMP.ResetText();
            txtDateofBirthEMP.ResetText();
            txtGenderEMP.ResetText();
            txtPhoneEMP.ResetText();
            txtAddEMP.ResetText();
            txtPosition.ResetText();
            txtSalaryEMP.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnExit.Enabled = false;
            // Đưa con trỏ đến TextField txtbatchID
            this.txtIDEmployee.Focus();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Add = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvEMPLOYEE_CellClick(null, null);

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnExit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtIDEmployee.Enabled = false;
            this.txtNameEMP.Focus();
        }

        private void dgvEMPLOYEE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvEMPLOYEE.CurrentCell.RowIndex;
            txtIDEmployee.Text = dgvEMPLOYEE.Rows[r].Cells[0].Value.ToString();
            txtNameEMP.Text = dgvEMPLOYEE.Rows[r].Cells[1].Value.ToString();
            txtDateofBirthEMP.Text = dgvEMPLOYEE.Rows[r].Cells[2].Value.ToString();
            txtGenderEMP.Text = dgvEMPLOYEE.Rows[r].Cells[3].Value.ToString();
            txtPhoneEMP.Text = dgvEMPLOYEE.Rows[r].Cells[4].Value.ToString();
            txtAddEMP.Text = dgvEMPLOYEE.Rows[r].Cells[5].Value.ToString();
            txtPosition.Text = dgvEMPLOYEE.Rows[r].Cells[6].Value.ToString();
            txtSalaryEMP.Text = dgvEMPLOYEE.Rows[r].Cells[7].Value.ToString();
            txtUsername.Text = dgvEMPLOYEE.Rows[r].Cells[8].Value.ToString();
            txtPassword.Text = dgvEMPLOYEE.Rows[r].Cells[9].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            txtIDEmployee.ResetText();
            txtNameEMP.ResetText();
            txtDateofBirthEMP.ResetText();
            txtGenderEMP.ResetText();
            txtPhoneEMP.ResetText();
            txtAddEMP.ResetText();
            txtPosition.ResetText();
            txtSalaryEMP.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvEMPLOYEE_CellClick(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int gender = 0;
            if (Add)
            {

                try
                {
                    BLEmployee blEMP = new BLEmployee();
                    if (txtGenderEMP.Text == "True")
                    {
                        gender = 1;
                    }
                    blEMP.AddEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text), txtUsername.Text, txtPassword.Text, ref err);
                    LoadDataEMP();
                    MessageBox.Show("Add Successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Adding EMP!");
                }
            }
            else
            {
                BLEmployee blemp = new BLEmployee();
                if (txtGenderEMP.Text == "True")
                {
                    gender = 1;
                }
                blemp.UpdateEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text), txtUsername.Text, txtPassword.Text, ref err);
                LoadDataEMP();
                MessageBox.Show("Update successfully!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvEMPLOYEE.CurrentCell.RowIndex;
                string strEM = dgvEMPLOYEE.Rows[r].Cells[0].Value.ToString();
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
                    dbEmployee.DeleteEmployee(strEM,ref err);
                    // Cập nhật lại DataGridView
                    LoadDataEMP();
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
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }
    }
}
