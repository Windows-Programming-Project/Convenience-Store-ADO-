namespace Convenience_Store_Ado_Version.DanhMuc
{
    partial class FrmEmployee
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
            this.lbIDEmp = new System.Windows.Forms.Label();
            this.txtIDEmployee = new System.Windows.Forms.TextBox();
            this.dgvEMPLOYEE = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNameEMP = new System.Windows.Forms.TextBox();
            this.blNameEMP = new System.Windows.Forms.Label();
            this.txtDateofBirthEMP = new System.Windows.Forms.TextBox();
            this.lbDateOfBirthEMP = new System.Windows.Forms.Label();
            this.txtGenderEMP = new System.Windows.Forms.TextBox();
            this.lbGenderEMP = new System.Windows.Forms.Label();
            this.txtPhoneEMP = new System.Windows.Forms.TextBox();
            this.txtAddEMP = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalaryEMP = new System.Windows.Forms.TextBox();
            this.lbPhoneEMP = new System.Windows.Forms.Label();
            this.lbAddEMP = new System.Windows.Forms.Label();
            this.lbPostitionEMP = new System.Windows.Forms.Label();
            this.lbSalaryEMP = new System.Windows.Forms.Label();
            this.btnAddEMP = new System.Windows.Forms.Button();
            this.btnChanged = new System.Windows.Forms.Button();
            this.btnDeleteEMP = new System.Windows.Forms.Button();
            this.btSaveEMP = new System.Windows.Forms.Button();
            this.btnReloadEMP = new System.Windows.Forms.Button();
            this.btnExitEMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIDEmp
            // 
            this.lbIDEmp.AutoSize = true;
            this.lbIDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDEmp.Location = new System.Drawing.Point(36, 85);
            this.lbIDEmp.Name = "lbIDEmp";
            this.lbIDEmp.Size = new System.Drawing.Size(26, 20);
            this.lbIDEmp.TabIndex = 0;
            this.lbIDEmp.Text = "ID";
            // 
            // txtIDEmployee
            // 
            this.txtIDEmployee.Location = new System.Drawing.Point(27, 55);
            this.txtIDEmployee.Multiline = true;
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.Size = new System.Drawing.Size(260, 50);
            this.txtIDEmployee.TabIndex = 1;
            // 
            // dgvEMPLOYEE
            // 
            this.dgvEMPLOYEE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMPLOYEE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEMPLOYEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMPLOYEE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEMPLOYEE.Location = new System.Drawing.Point(0, 376);
            this.dgvEMPLOYEE.Name = "dgvEMPLOYEE";
            this.dgvEMPLOYEE.RowHeadersWidth = 51;
            this.dgvEMPLOYEE.RowTemplate.Height = 24;
            this.dgvEMPLOYEE.Size = new System.Drawing.Size(1574, 275);
            this.dgvEMPLOYEE.TabIndex = 2;
            this.dgvEMPLOYEE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEMPLOYEE_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbSalaryEMP);
            this.panel1.Controls.Add(this.lbGenderEMP);
            this.panel1.Controls.Add(this.lbPostitionEMP);
            this.panel1.Controls.Add(this.lbDateOfBirthEMP);
            this.panel1.Controls.Add(this.lbAddEMP);
            this.panel1.Controls.Add(this.blNameEMP);
            this.panel1.Controls.Add(this.lbPhoneEMP);
            this.panel1.Controls.Add(this.lbIDEmp);
            this.panel1.Controls.Add(this.txtSalaryEMP);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtGenderEMP);
            this.panel1.Controls.Add(this.txtAddEMP);
            this.panel1.Controls.Add(this.txtDateofBirthEMP);
            this.panel1.Controls.Add(this.txtPhoneEMP);
            this.panel1.Controls.Add(this.txtNameEMP);
            this.panel1.Controls.Add(this.txtIDEmployee);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 368);
            this.panel1.TabIndex = 3;
            // 
            // txtNameEMP
            // 
            this.txtNameEMP.Location = new System.Drawing.Point(27, 119);
            this.txtNameEMP.Multiline = true;
            this.txtNameEMP.Name = "txtNameEMP";
            this.txtNameEMP.Size = new System.Drawing.Size(260, 46);
            this.txtNameEMP.TabIndex = 1;
            // 
            // blNameEMP
            // 
            this.blNameEMP.AutoSize = true;
            this.blNameEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blNameEMP.Location = new System.Drawing.Point(36, 145);
            this.blNameEMP.Name = "blNameEMP";
            this.blNameEMP.Size = new System.Drawing.Size(53, 20);
            this.blNameEMP.TabIndex = 0;
            this.blNameEMP.Text = "Name";
            // 
            // txtDateofBirthEMP
            // 
            this.txtDateofBirthEMP.Location = new System.Drawing.Point(27, 189);
            this.txtDateofBirthEMP.Multiline = true;
            this.txtDateofBirthEMP.Name = "txtDateofBirthEMP";
            this.txtDateofBirthEMP.Size = new System.Drawing.Size(260, 53);
            this.txtDateofBirthEMP.TabIndex = 1;
            // 
            // lbDateOfBirthEMP
            // 
            this.lbDateOfBirthEMP.AutoSize = true;
            this.lbDateOfBirthEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirthEMP.Location = new System.Drawing.Point(36, 222);
            this.lbDateOfBirthEMP.Name = "lbDateOfBirthEMP";
            this.lbDateOfBirthEMP.Size = new System.Drawing.Size(105, 20);
            this.lbDateOfBirthEMP.TabIndex = 0;
            this.lbDateOfBirthEMP.Text = "Date of Birth";
            // 
            // txtGenderEMP
            // 
            this.txtGenderEMP.Location = new System.Drawing.Point(27, 260);
            this.txtGenderEMP.Multiline = true;
            this.txtGenderEMP.Name = "txtGenderEMP";
            this.txtGenderEMP.Size = new System.Drawing.Size(260, 49);
            this.txtGenderEMP.TabIndex = 1;
            // 
            // lbGenderEMP
            // 
            this.lbGenderEMP.AutoSize = true;
            this.lbGenderEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderEMP.Location = new System.Drawing.Point(36, 289);
            this.lbGenderEMP.Name = "lbGenderEMP";
            this.lbGenderEMP.Size = new System.Drawing.Size(64, 20);
            this.lbGenderEMP.TabIndex = 0;
            this.lbGenderEMP.Text = "Gender";
            // 
            // txtPhoneEMP
            // 
            this.txtPhoneEMP.Location = new System.Drawing.Point(546, 55);
            this.txtPhoneEMP.Multiline = true;
            this.txtPhoneEMP.Name = "txtPhoneEMP";
            this.txtPhoneEMP.Size = new System.Drawing.Size(260, 50);
            this.txtPhoneEMP.TabIndex = 1;
            // 
            // txtAddEMP
            // 
            this.txtAddEMP.Location = new System.Drawing.Point(546, 119);
            this.txtAddEMP.Multiline = true;
            this.txtAddEMP.Name = "txtAddEMP";
            this.txtAddEMP.Size = new System.Drawing.Size(260, 46);
            this.txtAddEMP.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(546, 189);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(260, 53);
            this.txtPosition.TabIndex = 1;
            // 
            // txtSalaryEMP
            // 
            this.txtSalaryEMP.Location = new System.Drawing.Point(546, 260);
            this.txtSalaryEMP.Multiline = true;
            this.txtSalaryEMP.Name = "txtSalaryEMP";
            this.txtSalaryEMP.Size = new System.Drawing.Size(260, 49);
            this.txtSalaryEMP.TabIndex = 1;
            // 
            // lbPhoneEMP
            // 
            this.lbPhoneEMP.AutoSize = true;
            this.lbPhoneEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneEMP.Location = new System.Drawing.Point(555, 85);
            this.lbPhoneEMP.Name = "lbPhoneEMP";
            this.lbPhoneEMP.Size = new System.Drawing.Size(56, 20);
            this.lbPhoneEMP.TabIndex = 0;
            this.lbPhoneEMP.Text = "Phone";
            // 
            // lbAddEMP
            // 
            this.lbAddEMP.AutoSize = true;
            this.lbAddEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEMP.Location = new System.Drawing.Point(555, 145);
            this.lbAddEMP.Name = "lbAddEMP";
            this.lbAddEMP.Size = new System.Drawing.Size(71, 20);
            this.lbAddEMP.TabIndex = 0;
            this.lbAddEMP.Text = "Address";
            // 
            // lbPostitionEMP
            // 
            this.lbPostitionEMP.AutoSize = true;
            this.lbPostitionEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostitionEMP.Location = new System.Drawing.Point(555, 222);
            this.lbPostitionEMP.Name = "lbPostitionEMP";
            this.lbPostitionEMP.Size = new System.Drawing.Size(69, 20);
            this.lbPostitionEMP.TabIndex = 0;
            this.lbPostitionEMP.Text = "Position";
            // 
            // lbSalaryEMP
            // 
            this.lbSalaryEMP.AutoSize = true;
            this.lbSalaryEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalaryEMP.Location = new System.Drawing.Point(555, 289);
            this.lbSalaryEMP.Name = "lbSalaryEMP";
            this.lbSalaryEMP.Size = new System.Drawing.Size(56, 20);
            this.lbSalaryEMP.TabIndex = 0;
            this.lbSalaryEMP.Text = "Salary";
            // 
            // btnAddEMP
            // 
            this.btnAddEMP.Location = new System.Drawing.Point(1108, 57);
            this.btnAddEMP.Name = "btnAddEMP";
            this.btnAddEMP.Size = new System.Drawing.Size(127, 50);
            this.btnAddEMP.TabIndex = 4;
            this.btnAddEMP.Text = "ADD";
            this.btnAddEMP.UseVisualStyleBackColor = true;
            this.btnAddEMP.Click += new System.EventHandler(this.btnAddEMP_Click);
            // 
            // btnChanged
            // 
            this.btnChanged.Location = new System.Drawing.Point(1108, 133);
            this.btnChanged.Name = "btnChanged";
            this.btnChanged.Size = new System.Drawing.Size(127, 50);
            this.btnChanged.TabIndex = 4;
            this.btnChanged.Text = "Changed";
            this.btnChanged.UseVisualStyleBackColor = true;
            this.btnChanged.Click += new System.EventHandler(this.btnChanged_Click);
            // 
            // btnDeleteEMP
            // 
            this.btnDeleteEMP.Location = new System.Drawing.Point(1108, 210);
            this.btnDeleteEMP.Name = "btnDeleteEMP";
            this.btnDeleteEMP.Size = new System.Drawing.Size(127, 50);
            this.btnDeleteEMP.TabIndex = 4;
            this.btnDeleteEMP.Text = "Delete";
            this.btnDeleteEMP.UseVisualStyleBackColor = true;
            this.btnDeleteEMP.Click += new System.EventHandler(this.btnDeleteEMP_Click);
            // 
            // btSaveEMP
            // 
            this.btSaveEMP.Location = new System.Drawing.Point(1108, 291);
            this.btSaveEMP.Name = "btSaveEMP";
            this.btSaveEMP.Size = new System.Drawing.Size(127, 50);
            this.btSaveEMP.TabIndex = 4;
            this.btSaveEMP.Text = "Save";
            this.btSaveEMP.UseVisualStyleBackColor = true;
            this.btSaveEMP.Click += new System.EventHandler(this.btSaveEMP_Click);
            // 
            // btnReloadEMP
            // 
            this.btnReloadEMP.Location = new System.Drawing.Point(1375, 117);
            this.btnReloadEMP.Name = "btnReloadEMP";
            this.btnReloadEMP.Size = new System.Drawing.Size(127, 50);
            this.btnReloadEMP.TabIndex = 4;
            this.btnReloadEMP.Text = "Reload";
            this.btnReloadEMP.UseVisualStyleBackColor = true;
            this.btnReloadEMP.Click += new System.EventHandler(this.btnReloadEMP_Click);
            // 
            // btnExitEMP
            // 
            this.btnExitEMP.Location = new System.Drawing.Point(1375, 191);
            this.btnExitEMP.Name = "btnExitEMP";
            this.btnExitEMP.Size = new System.Drawing.Size(127, 50);
            this.btnExitEMP.TabIndex = 4;
            this.btnExitEMP.Text = "Exit";
            this.btnExitEMP.UseVisualStyleBackColor = true;
            this.btnExitEMP.Click += new System.EventHandler(this.btnExitEMP_Click);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 651);
            this.Controls.Add(this.btnReloadEMP);
            this.Controls.Add(this.btSaveEMP);
            this.Controls.Add(this.btnDeleteEMP);
            this.Controls.Add(this.btnExitEMP);
            this.Controls.Add(this.btnChanged);
            this.Controls.Add(this.btnAddEMP);
            this.Controls.Add(this.dgvEMPLOYEE);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIDEmp;
        private System.Windows.Forms.TextBox txtIDEmployee;
        private System.Windows.Forms.DataGridView dgvEMPLOYEE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGenderEMP;
        private System.Windows.Forms.Label lbDateOfBirthEMP;
        private System.Windows.Forms.Label blNameEMP;
        private System.Windows.Forms.TextBox txtGenderEMP;
        private System.Windows.Forms.TextBox txtDateofBirthEMP;
        private System.Windows.Forms.TextBox txtNameEMP;
        private System.Windows.Forms.Label lbSalaryEMP;
        private System.Windows.Forms.Label lbPostitionEMP;
        private System.Windows.Forms.Label lbAddEMP;
        private System.Windows.Forms.Label lbPhoneEMP;
        private System.Windows.Forms.TextBox txtSalaryEMP;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtAddEMP;
        private System.Windows.Forms.TextBox txtPhoneEMP;
        private System.Windows.Forms.Button btnAddEMP;
        private System.Windows.Forms.Button btnChanged;
        private System.Windows.Forms.Button btnDeleteEMP;
        private System.Windows.Forms.Button btSaveEMP;
        private System.Windows.Forms.Button btnReloadEMP;
        private System.Windows.Forms.Button btnExitEMP;
    }
}