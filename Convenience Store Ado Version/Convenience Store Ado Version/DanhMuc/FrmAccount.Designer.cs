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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNamAccount
            // 
            this.txtUserNamAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNamAccount.Location = new System.Drawing.Point(18, 17);
            this.txtUserNamAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserNamAccount.Multiline = true;
            this.txtUserNamAccount.Name = "txtUserNamAccount";
            this.txtUserNamAccount.Size = new System.Drawing.Size(154, 39);
            this.txtUserNamAccount.TabIndex = 0;
            // 
            // blUserNameAC
            // 
            this.blUserNameAC.AutoSize = true;
            this.blUserNameAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.blUserNameAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blUserNameAC.Location = new System.Drawing.Point(51, 49);
            this.blUserNameAC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blUserNameAC.Name = "blUserNameAC";
            this.blUserNameAC.Size = new System.Drawing.Size(85, 16);
            this.blUserNameAC.TabIndex = 1;
            this.blUserNameAC.Text = "User Name";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(289, 374);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 50;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(917, 176);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Teal;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(671, 92);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(81, 40);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtPassAccount
            // 
            this.txtPassAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassAccount.Location = new System.Drawing.Point(18, 80);
            this.txtPassAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassAccount.Multiline = true;
            this.txtPassAccount.Name = "txtPassAccount";
            this.txtPassAccount.Size = new System.Drawing.Size(154, 39);
            this.txtPassAccount.TabIndex = 0;
            // 
            // lbPassACC
            // 
            this.lbPassACC.AutoSize = true;
            this.lbPassACC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbPassACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassACC.Location = new System.Drawing.Point(53, 113);
            this.lbPassACC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassACC.Name = "lbPassACC";
            this.lbPassACC.Size = new System.Drawing.Size(83, 16);
            this.lbPassACC.TabIndex = 1;
            this.lbPassACC.Text = "Pass Word";
            // 
            // btnChangedAccount
            // 
            this.btnChangedAccount.BackColor = System.Drawing.Color.Teal;
            this.btnChangedAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangedAccount.ForeColor = System.Drawing.Color.White;
            this.btnChangedAccount.Location = new System.Drawing.Point(671, 147);
            this.btnChangedAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangedAccount.Name = "btnChangedAccount";
            this.btnChangedAccount.Size = new System.Drawing.Size(81, 40);
            this.btnChangedAccount.TabIndex = 3;
            this.btnChangedAccount.Text = "Changed";
            this.btnChangedAccount.UseVisualStyleBackColor = false;
            this.btnChangedAccount.Click += new System.EventHandler(this.btnChangedAccount_Click);
            // 
            // txtEIDAccount
            // 
            this.txtEIDAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEIDAccount.Location = new System.Drawing.Point(18, 146);
            this.txtEIDAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtEIDAccount.Multiline = true;
            this.txtEIDAccount.Name = "txtEIDAccount";
            this.txtEIDAccount.Size = new System.Drawing.Size(154, 39);
            this.txtEIDAccount.TabIndex = 0;
            // 
            // lbEIDAcc
            // 
            this.lbEIDAcc.AutoSize = true;
            this.lbEIDAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbEIDAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEIDAcc.Location = new System.Drawing.Point(79, 174);
            this.lbEIDAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEIDAcc.Name = "lbEIDAcc";
            this.lbEIDAcc.Size = new System.Drawing.Size(36, 16);
            this.lbEIDAcc.TabIndex = 1;
            this.lbEIDAcc.Text = "E ID";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(671, 203);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(81, 40);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // txtAcctiveACC
            // 
            this.txtAcctiveACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctiveACC.Location = new System.Drawing.Point(186, 113);
            this.txtAcctiveACC.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctiveACC.Multiline = true;
            this.txtAcctiveACC.Name = "txtAcctiveACC";
            this.txtAcctiveACC.Size = new System.Drawing.Size(157, 39);
            this.txtAcctiveACC.TabIndex = 0;
            // 
            // lbAcctiveACC
            // 
            this.lbAcctiveACC.AutoSize = true;
            this.lbAcctiveACC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbAcctiveACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcctiveACC.Location = new System.Drawing.Point(241, 146);
            this.lbAcctiveACC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAcctiveACC.Name = "lbAcctiveACC";
            this.lbAcctiveACC.Size = new System.Drawing.Size(58, 16);
            this.lbAcctiveACC.TabIndex = 1;
            this.lbAcctiveACC.Text = "Acctive";
            // 
            // btnExitAccount
            // 
            this.btnExitAccount.BackColor = System.Drawing.Color.Teal;
            this.btnExitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAccount.ForeColor = System.Drawing.Color.White;
            this.btnExitAccount.Location = new System.Drawing.Point(671, 312);
            this.btnExitAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitAccount.Name = "btnExitAccount";
            this.btnExitAccount.Size = new System.Drawing.Size(81, 40);
            this.btnExitAccount.TabIndex = 3;
            this.btnExitAccount.Text = "Exit";
            this.btnExitAccount.UseVisualStyleBackColor = false;
            this.btnExitAccount.Click += new System.EventHandler(this.btnExitAccount_Click);
            // 
            // txtEmailAccount
            // 
            this.txtEmailAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAccount.Location = new System.Drawing.Point(189, 49);
            this.txtEmailAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAccount.Multiline = true;
            this.txtEmailAccount.Name = "txtEmailAccount";
            this.txtEmailAccount.Size = new System.Drawing.Size(154, 39);
            this.txtEmailAccount.TabIndex = 0;
            // 
            // lbEmailACC
            // 
            this.lbEmailACC.AutoSize = true;
            this.lbEmailACC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbEmailACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailACC.Location = new System.Drawing.Point(241, 80);
            this.lbEmailACC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmailACC.Name = "lbEmailACC";
            this.lbEmailACC.Size = new System.Drawing.Size(46, 16);
            this.lbEmailACC.TabIndex = 1;
            this.lbEmailACC.Text = "Email";
            // 
            // btnReloadAccount
            // 
            this.btnReloadAccount.BackColor = System.Drawing.Color.Teal;
            this.btnReloadAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadAccount.ForeColor = System.Drawing.Color.White;
            this.btnReloadAccount.Location = new System.Drawing.Point(671, 258);
            this.btnReloadAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnReloadAccount.Name = "btnReloadAccount";
            this.btnReloadAccount.Size = new System.Drawing.Size(81, 40);
            this.btnReloadAccount.TabIndex = 3;
            this.btnReloadAccount.Text = "Reload";
            this.btnReloadAccount.UseVisualStyleBackColor = false;
            this.btnReloadAccount.Click += new System.EventHandler(this.btnReloadAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbEmailACC);
            this.panel1.Controls.Add(this.lbEIDAcc);
            this.panel1.Controls.Add(this.lbAcctiveACC);
            this.panel1.Controls.Add(this.blUserNameAC);
            this.panel1.Controls.Add(this.lbPassACC);
            this.panel1.Controls.Add(this.txtUserNamAccount);
            this.panel1.Controls.Add(this.txtPassAccount);
            this.panel1.Controls.Add(this.txtEIDAccount);
            this.panel1.Controls.Add(this.txtAcctiveACC);
            this.panel1.Controls.Add(this.txtEmailAccount);
            this.panel1.Location = new System.Drawing.Point(289, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 220);
            this.panel1.TabIndex = 4;
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReloadAccount);
            this.Controls.Add(this.btnExitAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnChangedAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.dgvAccount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAccount";
            this.Text = "FrmAccount";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}