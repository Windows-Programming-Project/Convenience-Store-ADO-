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
    public partial class FrmAccount : Form
    {
        #region global Var
        DataTable tbACC = null;
        BLAccount dbAccount = new BLAccount();
        string err;
        bool Add;
        #endregion
        public FrmAccount()
        {
            InitializeComponent();
        }
       void LoadDataAccount()
        {
            try
            {
                tbACC = new DataTable();
                tbACC.Clear();
                DataSet dataSet = dbAccount.TakeAccount();
                tbACC = dataSet.Tables[0];
                // push on data GRV
                dgvAccount.DataSource = tbACC;
                // chang size table
                dgvAccount.AutoResizeColumns();
                //
                dgvAccount_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAccount.CurrentCell.RowIndex;
            txtUserNamAccount.Text = dgvAccount.Rows[r].Cells[0].Value.ToString();
            txtPassAccount.Text = dgvAccount.Rows[r].Cells[1].Value.ToString();
            txtEIDAccount.Text = dgvAccount.Rows[r].Cells[2].Value.ToString();
            txtEmailAccount.Text = dgvAccount.Rows[r].Cells[3].Value.ToString();
            txtAcctiveACC.Text = dgvAccount.Rows[r].Cells[4].Value.ToString();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            LoadDataAccount();
        }
        #region button Account
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            int active = 0;
            if (Add)
            {
                try
                {
                    BLAccount blACC = new BLAccount();
                    if (txtAcctiveACC.Text == "True")
                    {
                        active = 1;
                    }
                    blACC.AddAccount(txtUserNamAccount.Text,txtPassAccount.Text,txtEIDAccount.Text,txtEmailAccount.Text,active,ref err);
                    // Thông báo 
                    MessageBox.Show("Add Successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Adding Account!");
                }
            }
            else
            {
                BLAccount blACC = new BLAccount();
                if (txtAcctiveACC.Text == "True")
                {
                    active = 1;
                }
                blACC.AddAccount(txtUserNamAccount.Text, txtPassAccount.Text, txtEIDAccount.Text, txtEmailAccount.Text, active, ref err);
                // Thông báo 
            }
            // Load lại dữ liệu trên DataGridView 
           LoadDataAccount();
            // Thông báo 
            MessageBox.Show("Successfully!");
        }

        private void btnChangedAccount_Click(object sender, EventArgs e)
        {
            int active = 0;
            if (Add)
            {
                try
                {
                    BLAccount blACC = new BLAccount();
                    if (txtAcctiveACC.Text == "True")
                    {
                        active = 1;
                    }
                    blACC.UpdateAccount(txtUserNamAccount.Text, txtPassAccount.Text, txtEIDAccount.Text, txtEmailAccount.Text, active, ref err);
                    // Thông báo 
                    MessageBox.Show("Update Successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Updating Account!");
                }
            }
            else
            {
                BLAccount blACC = new BLAccount();
                if (txtAcctiveACC.Text == "True")
                {
                    active = 1;
                }
                blACC.UpdateAccount(txtUserNamAccount.Text, txtPassAccount.Text, txtEIDAccount.Text, txtEmailAccount.Text, active, ref err);
                // Thông báo 
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataAccount();
            // Thông báo 
            MessageBox.Show("Successfully!");
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            
            if (Add)
            {
                try
                {
                    BLAccount blACC = new BLAccount();
                    blACC.DeleteAccount(txtUserNamAccount.Text, ref err);
                    // Thông báo 
                    MessageBox.Show("Delete Successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error Delete Account!");
                }
            }
            else
            {
                BLAccount blACC = new BLAccount();
                blACC.DeleteAccount(txtUserNamAccount.Text, ref err);
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataAccount();
            // Thông báo 
            MessageBox.Show("Successfully!");
        }

        private void btnReloadAccount_Click(object sender, EventArgs e)
        {
            LoadDataAccount();
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
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
