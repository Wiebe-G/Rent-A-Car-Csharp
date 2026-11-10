namespace RentACar
{
    partial class frmUserProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTabProfile = new TableLayoutPanel();
            lblName = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            lblAddress = new Label();
            pnlTabAddress = new TableLayoutPanel();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            txtStreetname = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            btnEdit = new Button();
            btnCancel = new Button();
            pnlTabProfile.SuspendLayout();
            pnlTabAddress.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabProfile
            // 
            pnlTabProfile.ColumnCount = 3;
            pnlTabProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabProfile.Controls.Add(lblName, 0, 0);
            pnlTabProfile.Controls.Add(txtFname, 1, 0);
            pnlTabProfile.Controls.Add(txtLname, 2, 0);
            pnlTabProfile.Controls.Add(lblAddress, 0, 1);
            pnlTabProfile.Controls.Add(pnlTabAddress, 1, 1);
            pnlTabProfile.Controls.Add(txtStreetname, 2, 1);
            pnlTabProfile.Controls.Add(lblEmail, 0, 2);
            pnlTabProfile.Controls.Add(txtEmail, 1, 2);
            pnlTabProfile.Controls.Add(lblPassword, 0, 3);
            pnlTabProfile.Controls.Add(txtPassword, 1, 3);
            pnlTabProfile.Controls.Add(txtPasswordConfirm, 2, 3);
            pnlTabProfile.Controls.Add(btnEdit, 1, 4);
            pnlTabProfile.Controls.Add(btnCancel, 2, 4);
            pnlTabProfile.Dock = DockStyle.Fill;
            pnlTabProfile.Location = new Point(0, 0);
            pnlTabProfile.Name = "pnlTabProfile";
            pnlTabProfile.RowCount = 5;
            pnlTabProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabProfile.Size = new Size(1116, 461);
            pnlTabProfile.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Name = "lblName";
            lblName.TabIndex = 0;
            lblName.Text = "Naam";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFname
            // 
            txtFname.BackColor = SystemColors.ControlLight;
            txtFname.Dock = DockStyle.Fill;
            txtFname.Margin = new Padding(10);
            txtFname.Multiline = true;
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = "Voornaam";
            txtFname.TabIndex = 1;
            // 
            // txtLname
            // 
            txtLname.BackColor = SystemColors.ControlLight;
            txtLname.Dock = DockStyle.Fill;
            txtLname.Margin = new Padding(10);
            txtLname.Multiline = true;
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = "Achternaam";
            txtLname.TabIndex = 2;
            // 
            // lblAddress
            // 
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Name = "lblAddress";
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Adresgegevens:";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTabAddress
            // 
            pnlTabAddress.ColumnCount = 2;
            pnlTabAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAddress.Controls.Add(txtCity, 0, 0);
            pnlTabAddress.Controls.Add(txtZipCode, 1, 0);
            pnlTabAddress.Dock = DockStyle.Fill;
            pnlTabAddress.Name = "pnlTabAddress";
            pnlTabAddress.RowCount = 1;
            pnlTabAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabAddress.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.ControlLight;
            txtCity.Dock = DockStyle.Fill;
            txtCity.Margin = new Padding(10);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Stad";
            txtCity.TabIndex = 0;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = SystemColors.ControlLight;
            txtZipCode.Dock = DockStyle.Fill;
            txtZipCode.Margin = new Padding(10);
            txtZipCode.Multiline = true;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "Postcode";
            txtZipCode.TabIndex = 1;
            // 
            // txtStreetname
            // 
            txtStreetname.BackColor = SystemColors.ControlLight;
            txtStreetname.Dock = DockStyle.Fill;
            txtStreetname.Margin = new Padding(10);
            txtStreetname.Multiline = true;
            txtStreetname.Name = "txtStreetname";
            txtStreetname.PlaceholderText = "Straatnaam en huisnummer";
            txtStreetname.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Margin = new Padding(10);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email-adres";
            txtEmail.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Name = "lblPassword";
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Nieuw wachtwoord";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Margin = new Padding(10);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Nieuw wachtwoord (optioneel)";
            txtPassword.TabIndex = 9;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BackColor = SystemColors.ControlLight;
            txtPasswordConfirm.Dock = DockStyle.Fill;
            txtPasswordConfirm.Margin = new Padding(10);
            txtPasswordConfirm.Multiline = true;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.PlaceholderText = "Bevestig nieuw wachtwoord";
            txtPasswordConfirm.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrchid;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Margin = new Padding(15);
            btnEdit.Name = "btnEdit";
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Bewerken";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.CadetBlue;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Margin = new Padding(15);
            btnCancel.Name = "btnCancel";
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Annuleren";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmUserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1116, 461);
            Controls.Add(pnlTabProfile);
            Name = "frmUserProfile";
            Text = "Mijn profiel";
            pnlTabProfile.ResumeLayout(false);
            pnlTabProfile.PerformLayout();
            pnlTabAddress.ResumeLayout(false);
            pnlTabAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabProfile;
        private Label lblName;
        private TextBox txtFname;
        private TextBox txtLname;
        private Label lblAddress;
        private TableLayoutPanel pnlTabAddress;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtStreetname;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Button btnEdit;
        private Button btnCancel;
    }
}