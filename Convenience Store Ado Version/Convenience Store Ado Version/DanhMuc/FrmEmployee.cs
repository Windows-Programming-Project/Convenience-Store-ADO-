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
                //
                dgvEMPLOYEE_CellContentClick(null, null);
                Add = true;
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
        private void dgvEMPLOYEE_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        }
        #region Button EMP
        private void btnAddEMP_Click(object sender, EventArgs e)
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
                    blEMP.AddEmployee(txtIDEmployee.Text,txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text), ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadDataEMP();
                    // Thông báo 
                    MessageBox.Show("Add Successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Adding EMP!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLEmployee blemp = new BLEmployee();
                if (txtGenderEMP.Text == "True")
                {
                    gender = 1;
                }
                blemp.AddEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text), ref err);           // Load lại dữ liệu trên DataGridView 

            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();
            // Thông báo 
            MessageBox.Show("Successfully!");
        }

        private void btnChanged_Click(object sender, EventArgs e)
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
                    bool isSuccess = blemp.UpdateEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text), ref err);           // Load lại dữ liệu trên DataGridView 

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
                blemp.UpdateEmployee(txtIDEmployee.Text, txtNameEMP.Text, DateTime.Parse(this.txtDateofBirthEMP.Text), gender, txtPhoneEMP.Text, txtAddEMP.Text, txtPosition.Text, Int32.Parse(txtSalaryEMP.Text), ref err);    
                
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();
            // Thông báo 
            MessageBox.Show("Update Successfully!");
        }

        private void btnDeleteEMP_Click(object sender, EventArgs e)
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
                    bool isSuccess = blemp.DeleteEmployee(txtIDEmployee.Text, ref err);

                    if (isSuccess)
                    {
                        MessageBox.Show("Employee delete successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error delete employee: {err}");
                    }
                    LoadDataEMP();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Error delete!");
                }
            }
            else
            {

                BLEmployee blemp = new BLEmployee();
                if (txtGenderEMP.Text == "True")
                {
                    gender = 1;
                }
                blemp.DeleteEmployee(txtIDEmployee.Text, ref err);
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataEMP();
            // Thông báo 
            MessageBox.Show("Delete Successfully!");
        }

        private void btSaveEMP_Click(object sender, EventArgs e)
        {

        }

        private void btnReloadEMP_Click(object sender, EventArgs e)
        {
            LoadDataEMP();
        }

        private void btnExitEMP_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }

        #endregion


    }
}
