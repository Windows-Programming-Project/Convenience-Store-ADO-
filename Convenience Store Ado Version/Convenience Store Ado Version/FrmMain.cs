using Convenience_Store_Ado_Version.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Ado_Version
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;
            this.Location = new Point(x, y);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            FrmAccount frm = new FrmAccount();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm); 
            frm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FrmDetail frm = new FrmDetail();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnManuafacture_Click(object sender, EventArgs e)
        {
            FrmManuafacture frm = new FrmManuafacture();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Form))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStock frm = new FrmStock();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier frm = new FrmSupplier();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            FrmType frm = new FrmType();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(Panel))
                {
                    this.Controls.Remove(control);
                }
            }
            this.Controls.Add(frm);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
