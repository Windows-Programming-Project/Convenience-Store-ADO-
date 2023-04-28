using Convenience_Store_Ado_Version.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Ado_Version.DanhMuc
{
    public partial class FrmCustomer : Form
    {
        #region global Var
        DataTable tbCTM = null;
        BLCustomer dbCustomer = new BLCustomer();
        string err;
        bool Add;
        #endregion
        public FrmCustomer()
        {
            InitializeComponent();
        }

        void LoadDataCustomer()
        {
            try
            {
                tbCTM = new DataTable();
                tbCTM.Clear();
                DataSet dataSet = dbCustomer.TakeCustomer();
                tbCTM = dataSet.Tables[0];
                // push on data GRV
                dgvCustomer.DataSource = tbCTM;
                // chang size table
                dgvCustomer.AutoResizeColumns();
                //
                dgvCustomer_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
       
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadDataCustomer();
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCustomer.CurrentCell.RowIndex;
            txtIDCustomer.Text = dgvCustomer.Rows[r].Cells[0].Value.ToString();
            txtNameCustomer.Text = dgvCustomer.Rows[r].Cells[1].Value.ToString();
            txtTotalPayCustomer.Text = dgvCustomer.Rows[r].Cells[2].Value.ToString();
            txtPhoneCustomer.Text = dgvCustomer.Rows[r].Cells[3].Value.ToString();
        }
        #region Button Customer

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnChangedCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnReloadCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnExitCustomer_Click(object sender, EventArgs e)
        {

        }
        #endregion
        
    }
}
