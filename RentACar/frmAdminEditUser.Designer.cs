namespace RentACar
{
    partial class frmAdminEditUser
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
            pnlTabEditUser = new TableLayoutPanel();
            lblName = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            pnlTabAddress = new TableLayoutPanel();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            lblAddress = new Label();
            lblEmail = new Label();
            txtStreetname = new TextBox();
            txtEmail = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnUpdateUser = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            lstStatus = new ListBox();
            pnlTabEditUser.SuspendLayout();
            pnlTabAddress.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabEditUser
            // 
            pnlTabEditUser.BackColor = SystemColors.ControlLight;
            pnlTabEditUser.ColumnCount = 3;
            pnlTabEditUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabEditUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabEditUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabEditUser.Controls.Add(lblName, 0, 0);
            pnlTabEditUser.Controls.Add(txtFname, 1, 0);
            pnlTabEditUser.Controls.Add(txtLname, 2, 0);
            pnlTabEditUser.Controls.Add(pnlTabAddress, 1, 1);
            pnlTabEditUser.Controls.Add(lblAddress, 0, 1);
            pnlTabEditUser.Controls.Add(lblEmail, 0, 2);
            pnlTabEditUser.Controls.Add(txtStreetname, 2, 1);
            pnlTabEditUser.Controls.Add(txtEmail, 1, 2);
            pnlTabEditUser.Controls.Add(lblRole, 0, 3);
            pnlTabEditUser.Controls.Add(cmbRole, 1, 3);
            pnlTabEditUser.Controls.Add(btnUpdateUser, 1, 5);
            pnlTabEditUser.Controls.Add(btnCancel, 0, 5);
            pnlTabEditUser.Controls.Add(lblStatus, 0, 4);
            pnlTabEditUser.Controls.Add(lstStatus, 1, 4);
            pnlTabEditUser.Dock = DockStyle.Fill;
            pnlTabEditUser.Location = new Point(0, 0);
            pnlTabEditUser.Name = "pnlTabEditUser";
            pnlTabEditUser.RowCount = 6;
            pnlTabEditUser.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabEditUser.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabEditUser.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabEditUser.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabEditUser.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabEditUser.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabEditUser.Size = new Size(1147, 471);
            pnlTabEditUser.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(223, 78);
            lblName.TabIndex = 0;
            lblName.Text = "Naam";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFname
            // 
            txtFname.BackColor = SystemColors.ControlLight;
            txtFname.Dock = DockStyle.Fill;
            txtFname.Location = new Point(239, 10);
            txtFname.Margin = new Padding(10);
            txtFname.Multiline = true;
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = "Voornaam";
            txtFname.Size = new Size(438, 58);
            txtFname.TabIndex = 1;
            // 
            // txtLname
            // 
            txtLname.BackColor = SystemColors.ControlLight;
            txtLname.Dock = DockStyle.Fill;
            txtLname.Location = new Point(697, 10);
            txtLname.Margin = new Padding(10);
            txtLname.Multiline = true;
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = "Achternaam";
            txtLname.Size = new Size(440, 58);
            txtLname.TabIndex = 4;
            // 
            // pnlTabAddress
            // 
            pnlTabAddress.ColumnCount = 2;
            pnlTabAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAddress.Controls.Add(txtCity, 0, 0);
            pnlTabAddress.Controls.Add(txtZipCode, 1, 0);
            pnlTabAddress.Dock = DockStyle.Fill;
            pnlTabAddress.Location = new Point(232, 81);
            pnlTabAddress.Name = "pnlTabAddress";
            pnlTabAddress.RowCount = 1;
            pnlTabAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAddress.Size = new Size(452, 72);
            pnlTabAddress.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.ControlLight;
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(10, 10);
            txtCity.Margin = new Padding(10);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Stad";
            txtCity.Size = new Size(206, 52);
            txtCity.TabIndex = 0;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = SystemColors.ControlLight;
            txtZipCode.Dock = DockStyle.Fill;
            txtZipCode.Location = new Point(236, 10);
            txtZipCode.Margin = new Padding(10);
            txtZipCode.Multiline = true;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "Postcode";
            txtZipCode.Size = new Size(206, 52);
            txtZipCode.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Location = new Point(3, 78);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(223, 78);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Adresgegevens:";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(3, 156);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(223, 78);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStreetname
            // 
            txtStreetname.BackColor = SystemColors.ControlLight;
            txtStreetname.Dock = DockStyle.Fill;
            txtStreetname.Location = new Point(697, 88);
            txtStreetname.Margin = new Padding(10);
            txtStreetname.Multiline = true;
            txtStreetname.Name = "txtStreetname";
            txtStreetname.PlaceholderText = "Straatnaam en huisnummer";
            txtStreetname.Size = new Size(440, 58);
            txtStreetname.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(239, 166);
            txtEmail.Margin = new Padding(10);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email-adres";
            txtEmail.Size = new Size(438, 58);
            txtEmail.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Fill;
            lblRole.Location = new Point(3, 234);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(223, 78);
            lblRole.TabIndex = 11;
            lblRole.Text = "Rol";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = SystemColors.ControlLight;
            cmbRole.Dock = DockStyle.Fill;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(232, 237);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(452, 28);
            cmbRole.TabIndex = 13;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.DarkOrchid;
            btnUpdateUser.Dock = DockStyle.Fill;
            btnUpdateUser.Location = new Point(244, 405);
            btnUpdateUser.Margin = new Padding(15);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(428, 51);
            btnUpdateUser.TabIndex = 2;
            btnUpdateUser.Text = "Update gebruiker";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(15, 405);
            btnCancel.Margin = new Padding(15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(199, 51);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Annuleren";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(3, 312);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(223, 78);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstStatus
            // 
            lstStatus.FormattingEnabled = true;
            lstStatus.Location = new Point(232, 315);
            lstStatus.Name = "lstStatus";
            lstStatus.Size = new Size(150, 64);
            lstStatus.TabIndex = 15;
            // 
            // frmAdminEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1147, 471);
            Controls.Add(pnlTabEditUser);
            Name = "frmAdminEditUser";
            Text = "Bewerk gebruiker";
            pnlTabEditUser.ResumeLayout(false);
            pnlTabEditUser.PerformLayout();
            pnlTabAddress.ResumeLayout(false);
            pnlTabAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabEditUser;
        private Label lblName;
        private TextBox txtFname;
        private Button btnUpdateUser;
        private Button btnCancel;
        private TextBox txtLname;
        private TableLayoutPanel pnlTabAddress;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private Label lblAddress;
        private Label lblEmail;
        private TextBox txtStreetname;
        private TextBox txtEmail;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblStatus;
        private ListBox lstStatus;
    }
}