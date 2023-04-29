namespace Convenience_Store_Ado_Version.DanhMuc
{
    partial class FrmAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserNamAccount = new System.Windows.Forms.TextBox();
            this.blUserNameAC = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtPassAccount = new System.Windows.Forms.TextBox();
            this.lbPassACC = new System.Windows.Forms.Label();
            this.btnChangedAccount = new System.Windows.Forms.Button();
            this.txtEIDAccount = new System.Windows.Forms.TextBox();
            this.lbEIDAcc = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.txtAcctiveACC = new System.Windows.Forms.TextBox();
            this.lbAcctiveACC = new System.Windows.Forms.Label();
            this.btnExitAccount = new System.Windows.Forms.Button();
            this.txtEmailAccount = new System.Windows.Forms.TextBox();
            this.lbEmailACC = new System.Windows.Forms.Label();
            this.btnReloadAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserNamAccount
            // 
            this.txtUserNamAccount.Location = new System.Drawing.Point(43, 13);
            this.txtUserNamAccount.Multiline = true;
            this.txtUserNamAccount.Name = "txtUserNamAccount";
            this.txtUserNamAccount.Size = new System.Drawing.Size(204, 47);
            this.txtUserNamAccount.TabIndex = 0;
            // 
            // blUserNameAC
            // 
            this.blUserNameAC.AutoSize = true;
            this.blUserNameAC.Location = new System.Drawing.Point(57, 44);
            this.blUserNameAC.Name = "blUserNameAC";
            this.blUserNameAC.Size = new System.Drawing.Size(76, 16);
            this.blUserNameAC.TabIndex = 1;
            this.blUserNameAC.Text = "User Name";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccount.Location = new System.Drawing.Point(0, 401);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(1343, 270);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(791, 15);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(94, 45);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtPassAccount
            // 
            this.txtPassAccount.Location = new System.Drawing.Point(43, 81);
            this.txtPassAccount.Multiline = true;
            this.txtPassAccount.Name = "txtPassAccount";
            this.txtPassAccount.Size = new System.Drawing.Size(204, 47);
            this.txtPassAccount.TabIndex = 0;
            // 
            // lbPassACC
            // 
            this.lbPassACC.AutoSize = true;
            this.lbPassACC.Location = new System.Drawing.Point(57, 112);
            this.lbPassACC.Name = "lbPassACC";
            this.lbPassACC.Size = new System.Drawing.Size(74, 16);
            this.lbPassACC.TabIndex = 1;
            this.lbPassACC.Text = "Pass Word";
            // 
            // btnChangedAccount
            // 
            this.btnChangedAccount.Location = new System.Drawing.Point(791, 83);
            this.btnChangedAccount.Name = "btnChangedAccount";
            this.btnChangedAccount.Size = new System.Drawing.Size(94, 45);
            this.btnChangedAccount.TabIndex = 3;
            this.btnChangedAccount.Text = "Changed";
            this.btnChangedAccount.UseVisualStyleBackColor = true;
            this.btnChangedAccount.Click += new System.EventHandler(this.btnChangedAccount_Click);
            // 
            // txtEIDAccount
            // 
            this.txtEIDAccount.Location = new System.Drawing.Point(43, 149);
            this.txtEIDAccount.Multiline = true;
            this.txtEIDAccount.Name = "txtEIDAccount";
            this.txtEIDAccount.Size = new System.Drawing.Size(204, 47);
            this.txtEIDAccount.TabIndex = 0;
            // 
            // lbEIDAcc
            // 
            this.lbEIDAcc.AutoSize = true;
            this.lbEIDAcc.Location = new System.Drawing.Point(57, 180);
            this.lbEIDAcc.Name = "lbEIDAcc";
            this.lbEIDAcc.Size = new System.Drawing.Size(32, 16);
            this.lbEIDAcc.TabIndex = 1;
            this.lbEIDAcc.Text = "E ID";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(791, 151);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(94, 45);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // txtAcctiveACC
            // 
            this.txtAcctiveACC.Location = new System.Drawing.Point(43, 283);
            this.txtAcctiveACC.Multiline = true;
            this.txtAcctiveACC.Name = "txtAcctiveACC";
            this.txtAcctiveACC.Size = new System.Drawing.Size(204, 47);
            this.txtAcctiveACC.TabIndex = 0;
            // 
            // lbAcctiveACC
            // 
            this.lbAcctiveACC.AutoSize = true;
            this.lbAcctiveACC.Location = new System.Drawing.Point(57, 314);
            this.lbAcctiveACC.Name = "lbAcctiveACC";
            this.lbAcctiveACC.Size = new System.Drawing.Size(51, 16);
            this.lbAcctiveACC.TabIndex = 1;
            this.lbAcctiveACC.Text = "Acctive";
            // 
            // btnExitAccount
            // 
            this.btnExitAccount.Location = new System.Drawing.Point(791, 285);
            this.btnExitAccount.Name = "btnExitAccount";
            this.btnExitAccount.Size = new System.Drawing.Size(94, 45);
            this.btnExitAccount.TabIndex = 3;
            this.btnExitAccount.Text = "Exit";
            this.btnExitAccount.UseVisualStyleBackColor = true;
            this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
            // 
            // txtEmailAccount
            // 
            this.txtEmailAccount.Location = new System.Drawing.Point(43, 217);
            this.txtEmailAccount.Multiline = true;
            this.txtEmailAccount.Name = "txtEmailAccount";
            this.txtEmailAccount.Size = new System.Drawing.Size(204, 47);
            this.txtEmailAccount.TabIndex = 0;
            // 
            // lbEmailACC
            // 
            this.lbEmailACC.AutoSize = true;
            this.lbEmailACC.Location = new System.Drawing.Point(57, 248);
            this.lbEmailACC.Name = "lbEmailACC";
            this.lbEmailACC.Size = new System.Drawing.Size(41, 16);
            this.lbEmailACC.TabIndex = 1;
            this.lbEmailACC.Text = "Email";
            // 
            // btnReloadAccount
            // 
            this.btnReloadAccount.Location = new System.Drawing.Point(791, 219);
            this.btnReloadAccount.Name = "btnReloadAccount";
            this.btnReloadAccount.Size = new System.Drawing.Size(94, 45);
            this.btnReloadAccount.TabIndex = 3;
            this.btnReloadAccount.Text = "Reload";
            this.btnReloadAccount.UseVisualStyleBackColor = true;
            this.btnReloadAccount.Click += new System.EventHandler(this.btnReloadAccount_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 671);
            this.Controls.Add(this.btnReloadAccount);
            this.Controls.Add(this.btnExitAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnChangedAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.lbEmailACC);
            this.Controls.Add(this.lbAcctiveACC);
            this.Controls.Add(this.lbEIDAcc);
            this.Controls.Add(this.lbPassACC);
            this.Controls.Add(this.blUserNameAC);
            this.Controls.Add(this.txtEmailAccount);
            this.Controls.Add(this.txtAcctiveACC);
            this.Controls.Add(this.txtEIDAccount);
            this.Controls.Add(this.txtPassAccount);
            this.Controls.Add(this.txtUserNamAccount);
            this.Name = "FrmAccount";
            this.Text = "FrmAccount";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNamAccount;
        private System.Windows.Forms.Label blUserNameAC;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtPassAccount;
        private System.Windows.Forms.Label lbPassACC;
        private System.Windows.Forms.Button btnChangedAccount;
        private System.Windows.Forms.TextBox txtEIDAccount;
        private System.Windows.Forms.Label lbEIDAcc;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.TextBox txtAcctiveACC;
        private System.Windows.Forms.Label lbAcctiveACC;
        private System.Windows.Forms.Button btnExitAccount;
        private System.Windows.Forms.TextBox txtEmailAccount;
        private System.Windows.Forms.Label lbEmailACC;
        private System.Windows.Forms.Button btnReloadAccount;
    }
}