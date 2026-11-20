namespace RentACar
{
    partial class userCtrlAdminEmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabAdminEmployees = new TabControl();
            tabAdminAllEmployees = new TabPage();
            pnlTabGioIsEenTeringlijer = new TableLayoutPanel();
            pnlTabAdminSearchEmployee = new TableLayoutPanel();
            txtSearchEmployeeByLastName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblStatus = new Label();
            lblEditButton = new Label();
            lblRole = new Label();
            pnlTabAdminEmployeesLayout = new TableLayoutPanel();
            tabAdminMakeEmployee = new TabPage();
            pnlTabCreateEmployee = new TableLayoutPanel();
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
            lblCreateRole = new Label();
            cmbRole = new ComboBox();
            btnCreateEmployee = new Button();
            btnCancel = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtPassConfirm = new TextBox();
            tabAdminEmployees.SuspendLayout();
            tabAdminAllEmployees.SuspendLayout();
            pnlTabGioIsEenTeringlijer.SuspendLayout();
            pnlTabAdminSearchEmployee.SuspendLayout();
            tabAdminMakeEmployee.SuspendLayout();
            pnlTabCreateEmployee.SuspendLayout();
            pnlTabAddress.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdminEmployees
            // 
            tabAdminEmployees.Controls.Add(tabAdminAllEmployees);
            tabAdminEmployees.Controls.Add(tabAdminMakeEmployee);
            tabAdminEmployees.Dock = DockStyle.Fill;
            tabAdminEmployees.Location = new Point(0, 0);
            tabAdminEmployees.Name = "tabAdminEmployees";
            tabAdminEmployees.SelectedIndex = 0;
            tabAdminEmployees.Size = new Size(1212, 512);
            tabAdminEmployees.TabIndex = 0;
            // 
            // tabAdminAllEmployees
            // 
            tabAdminAllEmployees.BackColor = SystemColors.ControlLight;
            tabAdminAllEmployees.Controls.Add(pnlTabGioIsEenTeringlijer);
            tabAdminAllEmployees.Location = new Point(4, 29);
            tabAdminAllEmployees.Name = "tabAdminAllEmployees";
            tabAdminAllEmployees.Padding = new Padding(3);
            tabAdminAllEmployees.Size = new Size(1204, 479);
            tabAdminAllEmployees.TabIndex = 0;
            tabAdminAllEmployees.Text = "Alle medewerkers";
            // 
            // pnlTabGioIsEenTeringlijer
            // 
            pnlTabGioIsEenTeringlijer.ColumnCount = 1;
            pnlTabGioIsEenTeringlijer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabGioIsEenTeringlijer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlTabGioIsEenTeringlijer.Controls.Add(pnlTabAdminSearchEmployee, 0, 0);
            pnlTabGioIsEenTeringlijer.Controls.Add(pnlTabAdminEmployeesLayout, 0, 1);
            pnlTabGioIsEenTeringlijer.Dock = DockStyle.Fill;
            pnlTabGioIsEenTeringlijer.Location = new Point(3, 3);
            pnlTabGioIsEenTeringlijer.Name = "pnlTabGioIsEenTeringlijer";
            pnlTabGioIsEenTeringlijer.RowCount = 2;
            pnlTabGioIsEenTeringlijer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabGioIsEenTeringlijer.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabGioIsEenTeringlijer.Size = new Size(1198, 473);
            pnlTabGioIsEenTeringlijer.TabIndex = 1;
            // 
            // pnlTabAdminSearchEmployee
            // 
            pnlTabAdminSearchEmployee.ColumnCount = 5;
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminSearchEmployee.Controls.Add(txtSearchEmployeeByLastName, 1, 0);
            pnlTabAdminSearchEmployee.Controls.Add(lblLastName, 0, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblFirstName, 1, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblStatus, 2, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblEditButton, 4, 1);
            pnlTabAdminSearchEmployee.Controls.Add(lblRole, 3, 1);
            pnlTabAdminSearchEmployee.Dock = DockStyle.Fill;
            pnlTabAdminSearchEmployee.Location = new Point(3, 3);
            pnlTabAdminSearchEmployee.Name = "pnlTabAdminSearchEmployee";
            pnlTabAdminSearchEmployee.RowCount = 2;
            pnlTabAdminSearchEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminSearchEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminSearchEmployee.Size = new Size(1192, 88);
            pnlTabAdminSearchEmployee.TabIndex = 0;
            // 
            // txtSearchEmployeeByLastName
            // 
            txtSearchEmployeeByLastName.BackColor = SystemColors.ControlDark;
            txtSearchEmployeeByLastName.Dock = DockStyle.Fill;
            txtSearchEmployeeByLastName.Location = new Point(241, 3);
            txtSearchEmployeeByLastName.Multiline = true;
            txtSearchEmployeeByLastName.Name = "txtSearchEmployeeByLastName";
            txtSearchEmployeeByLastName.PlaceholderText = "Zoek op achternaam...";
            txtSearchEmployeeByLastName.Size = new Size(232, 38);
            txtSearchEmployeeByLastName.TabIndex = 0;
            txtSearchEmployeeByLastName.TextChanged += txtSearchEmployeeByLastName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(3, 44);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(232, 44);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Achternaam";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(241, 44);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(232, 44);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Voornaam";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(479, 44);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(232, 44);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditButton
            // 
            lblEditButton.AutoSize = true;
            lblEditButton.Dock = DockStyle.Fill;
            lblEditButton.Location = new Point(955, 44);
            lblEditButton.Name = "lblEditButton";
            lblEditButton.Size = new Size(234, 44);
            lblEditButton.TabIndex = 4;
            lblEditButton.Text = "Bewerk";
            lblEditButton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Fill;
            lblRole.Location = new Point(717, 44);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(232, 44);
            lblRole.TabIndex = 5;
            lblRole.Text = "Rol";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTabAdminEmployeesLayout
            // 
            pnlTabAdminEmployeesLayout.ColumnCount = 1;
            pnlTabAdminEmployeesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabAdminEmployeesLayout.Dock = DockStyle.Fill;
            pnlTabAdminEmployeesLayout.Location = new Point(3, 97);
            pnlTabAdminEmployeesLayout.Name = "pnlTabAdminEmployeesLayout";
            pnlTabAdminEmployeesLayout.RowCount = 1;
            pnlTabAdminEmployeesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAdminEmployeesLayout.Size = new Size(1192, 373);
            pnlTabAdminEmployeesLayout.TabIndex = 1;
            // 
            // tabAdminMakeEmployee
            // 
            tabAdminMakeEmployee.BackColor = SystemColors.ControlLight;
            tabAdminMakeEmployee.Controls.Add(pnlTabCreateEmployee);
            tabAdminMakeEmployee.Location = new Point(4, 29);
            tabAdminMakeEmployee.Name = "tabAdminMakeEmployee";
            tabAdminMakeEmployee.Padding = new Padding(3);
            tabAdminMakeEmployee.Size = new Size(1204, 479);
            tabAdminMakeEmployee.TabIndex = 1;
            tabAdminMakeEmployee.Text = "Maak medewerker aan";
            // 
            // pnlTabCreateEmployee
            // 
            pnlTabCreateEmployee.BackColor = SystemColors.ControlLight;
            pnlTabCreateEmployee.ColumnCount = 3;
            pnlTabCreateEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabCreateEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabCreateEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabCreateEmployee.Controls.Add(lblName, 0, 0);
            pnlTabCreateEmployee.Controls.Add(txtFname, 1, 0);
            pnlTabCreateEmployee.Controls.Add(txtLname, 2, 0);
            pnlTabCreateEmployee.Controls.Add(pnlTabAddress, 1, 1);
            pnlTabCreateEmployee.Controls.Add(lblAddress, 0, 1);
            pnlTabCreateEmployee.Controls.Add(lblEmail, 0, 2);
            pnlTabCreateEmployee.Controls.Add(txtStreetname, 2, 1);
            pnlTabCreateEmployee.Controls.Add(txtEmail, 1, 2);
            pnlTabCreateEmployee.Controls.Add(lblCreateRole, 0, 3);
            pnlTabCreateEmployee.Controls.Add(cmbRole, 1, 3);
            pnlTabCreateEmployee.Controls.Add(btnCreateEmployee, 1, 5);
            pnlTabCreateEmployee.Controls.Add(btnCancel, 0, 5);
            pnlTabCreateEmployee.Controls.Add(lblPassword, 0, 4);
            pnlTabCreateEmployee.Controls.Add(txtPassword, 1, 4);
            pnlTabCreateEmployee.Controls.Add(txtPassConfirm, 2, 4);
            pnlTabCreateEmployee.Dock = DockStyle.Fill;
            pnlTabCreateEmployee.Location = new Point(3, 3);
            pnlTabCreateEmployee.Name = "pnlTabCreateEmployee";
            pnlTabCreateEmployee.RowCount = 6;
            pnlTabCreateEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabCreateEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabCreateEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabCreateEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabCreateEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabCreateEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            pnlTabCreateEmployee.Size = new Size(1198, 473);
            pnlTabCreateEmployee.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(233, 78);
            lblName.TabIndex = 0;
            lblName.Text = "Naam";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFname
            // 
            txtFname.BackColor = SystemColors.ControlLight;
            txtFname.Dock = DockStyle.Fill;
            txtFname.Location = new Point(249, 10);
            txtFname.Margin = new Padding(10);
            txtFname.Multiline = true;
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = "Voornaam";
            txtFname.Size = new Size(459, 58);
            txtFname.TabIndex = 1;
            // 
            // txtLname
            // 
            txtLname.BackColor = SystemColors.ControlLight;
            txtLname.Dock = DockStyle.Fill;
            txtLname.Location = new Point(728, 10);
            txtLname.Margin = new Padding(10);
            txtLname.Multiline = true;
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = "Achternaam";
            txtLname.Size = new Size(460, 58);
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
            pnlTabAddress.Location = new Point(242, 81);
            pnlTabAddress.Name = "pnlTabAddress";
            pnlTabAddress.RowCount = 1;
            pnlTabAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAddress.Size = new Size(473, 72);
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
            txtCity.Size = new Size(216, 52);
            txtCity.TabIndex = 0;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = SystemColors.ControlLight;
            txtZipCode.Dock = DockStyle.Fill;
            txtZipCode.Location = new Point(246, 10);
            txtZipCode.Margin = new Padding(10);
            txtZipCode.Multiline = true;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "Postcode";
            txtZipCode.Size = new Size(217, 52);
            txtZipCode.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Location = new Point(3, 78);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(233, 78);
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
            lblEmail.Size = new Size(233, 78);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStreetname
            // 
            txtStreetname.BackColor = SystemColors.ControlLight;
            txtStreetname.Dock = DockStyle.Fill;
            txtStreetname.Location = new Point(728, 88);
            txtStreetname.Margin = new Padding(10);
            txtStreetname.Multiline = true;
            txtStreetname.Name = "txtStreetname";
            txtStreetname.PlaceholderText = "Straatnaam en huisnummer";
            txtStreetname.Size = new Size(460, 58);
            txtStreetname.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(249, 166);
            txtEmail.Margin = new Padding(10);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email-adres";
            txtEmail.Size = new Size(459, 58);
            txtEmail.TabIndex = 10;
            // 
            // lblCreateRole
            // 
            lblCreateRole.AutoSize = true;
            lblCreateRole.Dock = DockStyle.Fill;
            lblCreateRole.Location = new Point(3, 234);
            lblCreateRole.Name = "lblCreateRole";
            lblCreateRole.Size = new Size(233, 78);
            lblCreateRole.TabIndex = 11;
            lblCreateRole.Text = "Rol";
            lblCreateRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = SystemColors.ControlLight;
            cmbRole.Dock = DockStyle.Fill;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(242, 237);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(473, 28);
            cmbRole.TabIndex = 13;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.LimeGreen;
            btnCreateEmployee.Dock = DockStyle.Fill;
            btnCreateEmployee.Location = new Point(254, 405);
            btnCreateEmployee.Margin = new Padding(15);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(449, 53);
            btnCreateEmployee.TabIndex = 2;
            btnCreateEmployee.Text = "Maak medewerker aan";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(15, 405);
            btnCancel.Margin = new Padding(15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(209, 53);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Annuleren";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(3, 312);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(233, 78);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Wachtwoord";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(242, 315);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Wachtwoord...";
            txtPassword.Size = new Size(473, 72);
            txtPassword.TabIndex = 15;
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.BackColor = SystemColors.ControlLight;
            txtPassConfirm.Dock = DockStyle.Fill;
            txtPassConfirm.Location = new Point(721, 315);
            txtPassConfirm.Multiline = true;
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.PasswordChar = '*';
            txtPassConfirm.PlaceholderText = "Herhaal wachtwoord...";
            txtPassConfirm.Size = new Size(474, 72);
            txtPassConfirm.TabIndex = 16;
            // 
            // userCtrlAdminEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(tabAdminEmployees);
            Name = "userCtrlAdminEmployees";
            Size = new Size(1212, 512);
            tabAdminEmployees.ResumeLayout(false);
            tabAdminAllEmployees.ResumeLayout(false);
            pnlTabGioIsEenTeringlijer.ResumeLayout(false);
            pnlTabAdminSearchEmployee.ResumeLayout(false);
            pnlTabAdminSearchEmployee.PerformLayout();
            tabAdminMakeEmployee.ResumeLayout(false);
            pnlTabCreateEmployee.ResumeLayout(false);
            pnlTabCreateEmployee.PerformLayout();
            pnlTabAddress.ResumeLayout(false);
            pnlTabAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdminEmployees;
        private TabPage tabAdminAllEmployees;
        private TableLayoutPanel pnlTabGioIsEenTeringlijer;
        private TableLayoutPanel pnlTabAdminSearchEmployee;
        private TextBox txtSearchEmployeeByLastName;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblStatus;
        private Label lblEditButton;
        private TableLayoutPanel pnlTabAdminEmployeesLayout;
        private TabPage tabAdminMakeEmployee;
        private Label lblRole;
        private TableLayoutPanel pnlTabCreateEmployee;
        private Label lblName;
        private TextBox txtFname;
        private TextBox txtLname;
        private TableLayoutPanel pnlTabAddress;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private Label lblAddress;
        private Label lblEmail;
        private TextBox txtStreetname;
        private TextBox txtEmail;
        private Button btnCreateEmployee;
        private Button btnCancel;
        private Label lblCreateRole;
        private ComboBox cmbRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtPassConfirm;
    }
}
