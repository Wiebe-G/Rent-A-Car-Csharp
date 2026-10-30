namespace RentACar
{
    partial class frmRegister
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
            pnlTabRegister = new TableLayoutPanel();
            lblName = new Label();
            txtFname = new TextBox();
            btnRegister = new Button();
            btnLoginForm = new Button();
            txtLname = new TextBox();
            pnlTabAddress = new TableLayoutPanel();
            txtCity = new TextBox();
            txtZipCode = new TextBox();
            lblAddress = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            txtStreetname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            pnlTabRegister.SuspendLayout();
            pnlTabAddress.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabRegister
            // 
            pnlTabRegister.ColumnCount = 3;
            pnlTabRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabRegister.Controls.Add(lblName, 0, 0);
            pnlTabRegister.Controls.Add(txtFname, 1, 0);
            pnlTabRegister.Controls.Add(btnRegister, 1, 4);
            pnlTabRegister.Controls.Add(btnLoginForm, 2, 4);
            pnlTabRegister.Controls.Add(txtLname, 2, 0);
            pnlTabRegister.Controls.Add(pnlTabAddress, 1, 1);
            pnlTabRegister.Controls.Add(lblAddress, 0, 1);
            pnlTabRegister.Controls.Add(lblEmail, 0, 2);
            pnlTabRegister.Controls.Add(lblPassword, 0, 3);
            pnlTabRegister.Controls.Add(txtStreetname, 2, 1);
            pnlTabRegister.Controls.Add(txtEmail, 1, 2);
            pnlTabRegister.Controls.Add(txtPassword, 1, 3);
            pnlTabRegister.Controls.Add(txtPasswordConfirm, 2, 3);
            pnlTabRegister.Dock = DockStyle.Fill;
            pnlTabRegister.Location = new Point(0, 0);
            pnlTabRegister.Name = "pnlTabRegister";
            pnlTabRegister.RowCount = 5;
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabRegister.Size = new Size(1116, 461);
            pnlTabRegister.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 92);
            lblName.TabIndex = 0;
            lblName.Text = "Naam";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFname
            // 
            txtFname.BackColor = SystemColors.ControlLight;
            txtFname.Dock = DockStyle.Fill;
            txtFname.Location = new Point(233, 10);
            txtFname.Margin = new Padding(10);
            txtFname.Multiline = true;
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = "Voornaam";
            txtFname.Size = new Size(426, 72);
            txtFname.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkOrchid;
            btnRegister.Dock = DockStyle.Fill;
            btnRegister.Location = new Point(238, 383);
            btnRegister.Margin = new Padding(15);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(416, 63);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Registreer";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.CadetBlue;
            btnLoginForm.Dock = DockStyle.Fill;
            btnLoginForm.Location = new Point(684, 383);
            btnLoginForm.Margin = new Padding(15);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.Size = new Size(417, 63);
            btnLoginForm.TabIndex = 3;
            btnLoginForm.Text = "Al een account? Log in";
            btnLoginForm.UseVisualStyleBackColor = false;
            // 
            // txtLname
            // 
            txtLname.BackColor = SystemColors.ControlLight;
            txtLname.Dock = DockStyle.Fill;
            txtLname.Location = new Point(679, 10);
            txtLname.Margin = new Padding(10);
            txtLname.Multiline = true;
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = "Achternaam";
            txtLname.Size = new Size(427, 72);
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
            pnlTabAddress.Location = new Point(226, 95);
            pnlTabAddress.Name = "pnlTabAddress";
            pnlTabAddress.RowCount = 1;
            pnlTabAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabAddress.Size = new Size(440, 86);
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
            txtCity.Size = new Size(200, 66);
            txtCity.TabIndex = 0;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = SystemColors.ControlLight;
            txtZipCode.Dock = DockStyle.Fill;
            txtZipCode.Location = new Point(230, 10);
            txtZipCode.Margin = new Padding(10);
            txtZipCode.Multiline = true;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "Postcode";
            txtZipCode.Size = new Size(200, 66);
            txtZipCode.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Location = new Point(3, 92);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(217, 92);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Adresgegevens:";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(3, 184);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(217, 92);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(3, 276);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(217, 92);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Wachtwoord";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStreetname
            // 
            txtStreetname.BackColor = SystemColors.ControlLight;
            txtStreetname.Dock = DockStyle.Fill;
            txtStreetname.Location = new Point(679, 102);
            txtStreetname.Margin = new Padding(10);
            txtStreetname.Multiline = true;
            txtStreetname.Name = "txtStreetname";
            txtStreetname.PlaceholderText = "Straatnaam en huisnummer";
            txtStreetname.Size = new Size(427, 72);
            txtStreetname.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(233, 194);
            txtEmail.Margin = new Padding(10);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email-adres";
            txtEmail.Size = new Size(426, 72);
            txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(233, 286);
            txtPassword.Margin = new Padding(10);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Wachtwoord";
            txtPassword.Size = new Size(426, 72);
            txtPassword.TabIndex = 11;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BackColor = SystemColors.ControlLight;
            txtPasswordConfirm.Dock = DockStyle.Fill;
            txtPasswordConfirm.Location = new Point(679, 286);
            txtPasswordConfirm.Margin = new Padding(10);
            txtPasswordConfirm.Multiline = true;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.PlaceholderText = "Bevestig wachtwoord";
            txtPasswordConfirm.Size = new Size(427, 72);
            txtPasswordConfirm.TabIndex = 12;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1116, 461);
            Controls.Add(pnlTabRegister);
            Name = "frmRegister";
            Text = "Maak een account aan";
            pnlTabRegister.ResumeLayout(false);
            pnlTabRegister.PerformLayout();
            pnlTabAddress.ResumeLayout(false);
            pnlTabAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabRegister;
        private Label lblName;
        private TextBox txtFname;
        private TextBox txtLname;
        private TableLayoutPanel pnlTabAddress;
        private Button btnRegister;
        private Button btnLoginForm;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtCity;
        private TextBox txtZipCode;
        private TextBox txtStreetname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
    }
}